using Cv.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.AppCode.Providers
{
    public class AppClaimProvider : IClaimsTransformation
    {
        private readonly CvWebDbContext db;

        public AppClaimProvider(CvWebDbContext db)
        {
            this.db = db;
        }
        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (principal.Identity.IsAuthenticated && principal.Identity is ClaimsIdentity currentIdentity)
            {
                var userId = Convert.ToInt32(currentIdentity.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value);

                var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userId);

                if (user != null)
                {
                    currentIdentity.AddClaim(new Claim("name", user.Name));
                    currentIdentity.AddClaim(new Claim("surname", user.Surname));
                }
            }

            return principal;
        }
    }
}
