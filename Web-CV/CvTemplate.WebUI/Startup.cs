using Cv.Domain.AppCode.Services;
using Cv.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Cv.Domain.AppCode.Providers;
using Microsoft.AspNetCore.Authentication;
using Cv.Domain.Models.DataContext;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Cv.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;   
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg => {

                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddDbContext<CvWebDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));
            })
            .AddIdentity<CvUser, CvRole>()
            .AddEntityFrameworkStores<CvWebDbContext>()
            .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(cfg => {
                cfg.User.RequireUniqueEmail = true; 
                cfg.Password.RequireDigit = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredUniqueChars = 1; //123
                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 1, 0);
                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Password.RequiredLength = 3;

            });

            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accesdenied.html";

                cfg.Cookie.Name = "bigon";
                cfg.Cookie.HttpOnly = true;
                cfg.ExpireTimeSpan = new TimeSpan(0, 15, 0);
            });



            services.AddAuthentication();
            services.AddAuthorization();

            services.AddScoped<UserManager<CvUser>>();
            services.AddScoped<SignInManager<CvUser>>();



            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            }); 

            services.Configure<EmailServiceOptions>(cfg =>
            {
                configuration.GetSection("emailAccount").Bind(cfg);
            });
            services.AddSingleton<EmailService>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IClaimsTransformation, AppClaimProvider>();
            var asemblies = AppDomain.CurrentDomain.GetAssemblies().AsEnumerable().Where(a => a.FullName.StartsWith("Cv."));

            services.AddMediatR(asemblies.ToArray());


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<CvRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.SeedMembership();
            CvDbSeed.SeedUserRole(roleManager);

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(cfg =>
            {
                cfg.MapAreaControllerRoute("defaultAdmin", "admin", "admin/{controller=dashboard}/{action=index}/{id?}");


                cfg.MapControllerRoute(
                name: "default-accesdenied",
                pattern: "accesdenied.html",
                defaults: new
                {
                    area = "",
                    controller = "account",
                    action = "accesdenied"
                });

                cfg.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");



            });
        }
    }
}