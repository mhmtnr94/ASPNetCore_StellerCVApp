#pragma checksum "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35e2dcc6ffb53275e03012d8ebd09e8df537cdd61a68d1c5aa7022d69964250d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"35e2dcc6ffb53275e03012d8ebd09e8df537cdd61a68d1c5aa7022d69964250d", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2f4f056741db09c5b51dcaadcde0f68c0f1f606638a5fd3144a887667eb0e306", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeatureList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/steller/public_html/assets/imgs/man.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<header class=\"header\" id=\"home\">\n    <div class=\"container\">\n");
#nullable restore
#line 5 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"infos\">\n            <h6 class=\"subtitle\">");
            Write(
#nullable restore
#line 7 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml"
                                  item.Header

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\n            <h6 class=\"title\" style=\"font-size:50px\">");
            Write(
#nullable restore
#line 8 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml"
                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\n            <br />\n            <p>");
            Write(
#nullable restore
#line 10 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml"
                item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\n\n            <div class=\"buttons pt-3\">\n                <button class=\"btn btn-primary rounded\">BANA ULAŞIN</button>\n            </div>\n        </div>\n");
#nullable restore
#line 16 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\FeatureList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"img-holder\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "35e2dcc6ffb53275e03012d8ebd09e8df537cdd61a68d1c5aa7022d69964250d6079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

    <!-- Header-widget -->
    <div class=""widget"">
        <div class=""widget-item"">
            <h2>124</h2>
            <p>Happy Clients</p>
        </div>
        <div class=""widget-item"">
            <h2>456</h2>
            <p>Project Completed</p>
        </div>
        <div class=""widget-item"">
            <h2>789</h2>
            <p>Awards Won</p>
        </div>
    </div>
</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
