#pragma checksum "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Shared\HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bd4dda8b2a7af3355e29ce1df92837c33000ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/HeaderPartial.cshtml")]
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
#line 1 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\_ViewImports.cshtml"
using kpssLiveDinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\_ViewImports.cshtml"
using kpssLiveDinner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\_ViewImports.cshtml"
using kpssLiveDinner.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38bd4dda8b2a7af3355e29ce1df92837c33000ec", @"/Views/Shared/HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c064d63c831746c8eac0d60cdb522b91804af59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header class=\"top-navbar\">\r\n    <nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n        <div class=\"container\">\r\n            <a class=\"navbar-brand\" href=\"index.html\">\r\n                <img src=\"images/logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 225, "\"", 231, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbars-rs-food"" aria-controls=""navbars-rs-food"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbars-rs-food"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item active""><a class=""nav-link"" href=""index.html"">Home</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""menu.html"">Menu</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""about.html"">About</a></li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""dropdown-a"" data-toggle=""dropdown"">Pages</a>
                        <div class=""dropdown-menu"" aria-labelledby=""dropdown-a"">
                            <a class=""dropdown-item"" href");
            WriteLiteral(@"=""reservation.html"">Reservation</a>
                            <a class=""dropdown-item"" href=""stuff.html"">Stuff</a>
                            <a class=""dropdown-item"" href=""gallery.html"">Gallery</a>
                        </div>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""dropdown-a"" data-toggle=""dropdown"">Blog</a>
                        <div class=""dropdown-menu"" aria-labelledby=""dropdown-a"">
                            <a class=""dropdown-item"" href=""blog.html"">blog</a>
                            <a class=""dropdown-item"" href=""blog-details.html"">blog Single</a>
                        </div>
                    </li>
                    <li class=""nav-item""><a class=""nav-link"" href=""contact.html"">Contact</a></li>
                </ul>
            </div>
        </div>
    </nav>
</header>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591