#pragma checksum "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf62a85ca478c8fbbce85e9ba5b44cd5ccff7e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Abouts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Abouts/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Cv.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Cv.Domain.Business.ResumeModule.Bio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Cv.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Cv.Domain.Business.ProjectsModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf62a85ca478c8fbbce85e9ba5b44cd5ccff7e4", @"/Areas/Admin/Views/Abouts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003e65bab233b8d93719096e285881bba37f813e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Abouts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<About>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n <p>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf62a85ca478c8fbbce85e9ba5b44cd5ccff7e45284", async() => {
                WriteLiteral("Create One");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   \r\n</p>\r\n\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 17 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n             <td>\r\n                 ");
#nullable restore
#line 23 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
            Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n         <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Experince));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Experince));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Degree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Degree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CareerLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CareerLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                    ");
#nullable restore
#line 68 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                    ");
#nullable restore
#line 71 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 84 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                    ");
#nullable restore
#line 92 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                    ");
#nullable restore
#line 95 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n         <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 100 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n         <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 108 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 111 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.Raw(item.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 116 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"d-flex\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf62a85ca478c8fbbce85e9ba5b44cd5ccff7e415609", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n              \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 129 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Areas\Admin\Views\Abouts\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n<style>\r\n\r\n    .table tr td{\r\n        white-space: normal;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
