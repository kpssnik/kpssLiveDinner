#pragma checksum "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Home\Stuff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f946fac601e3f73f8159c738f0ec60c62bff95c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Stuff), @"mvc.1.0.view", @"/Views/Home/Stuff.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f946fac601e3f73f8159c738f0ec60c62bff95c3", @"/Views/Home/Stuff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c064d63c831746c8eac0d60cdb522b91804af59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Stuff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/stuff-img-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Home\Stuff.cshtml"
  
    ViewData["Title"] = "Stuff";
    ViewData["Heading"] = "Our stuff";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Start Stuff -->
<div class=""stuff-box"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""heading-title text-center"">
                    <h2>Stuff</h2>
                    <p>Lorem Ipsum is simply dummy text of the printing and typesetting</p>
                </div>
            </div>
        </div>

        <div class=""row"">

");
#nullable restore
#line 21 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Home\Stuff.cshtml"
              
                for (int i = 0; i < 6; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 col-sm-6\">\r\n                        <div class=\"our-team\">\r\n                            <div class=\"pic\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f946fac601e3f73f8159c738f0ec60c62bff95c34778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <ul class=""social"">
                                    <li><a href=""#"" class=""fa fa-facebook""></a></li>
                                    <li><a href=""#"" class=""fa fa-google-plus""></a></li>
                                    <li><a href=""#"" class=""fa fa-instagram""></a></li>
                                    <li><a href=""#"" class=""fa fa-linkedin""></a></li>
                                </ul>
                            </div>
                            <div class=""team-content"">
                                <h3 class=""title"">Williamson</h3>
                                <span class=""post"">Web Developer</span>
                            </div>
                        </div>

                    </div>
");
#nullable restore
#line 42 "E:\Programming\PROJECTS\kpssLiveDinner\kpssLiveDinner\Views\Home\Stuff.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End Stuff -->");
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