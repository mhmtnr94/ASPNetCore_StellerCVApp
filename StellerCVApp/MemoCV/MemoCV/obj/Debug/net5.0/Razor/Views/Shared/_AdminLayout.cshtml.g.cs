#pragma checksum "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d8762906b0db78322700690bb7b53e54b9325eaec2e744d701a08e36d51a3f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d8762906b0db78322700690bb7b53e54b9325eaec2e744d701a08e36d51a3f48", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2f4f056741db09c5b51dcaadcde0f68c0f1f606638a5fd3144a887667eb0e306", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\_AdminLayout.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<!DOCTYPE html>\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            Write(
#nullable restore
#line 7 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\_AdminLayout.cshtml"
 await Html.PartialAsync("/Views/Admin2/PartialHead.cshtml")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8762906b0db78322700690bb7b53e54b9325eaec2e744d701a08e36d51a3f483791", async() => {
                WriteLiteral(@"
	<div id=""wrapper"">
		<nav class=""navbar navbar-default navbar-cls-top "" role=""navigation"" style=""margin-bottom: 0"">
			<div class=""navbar-header"">
				<button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".sidebar-collapse"">
					<span class=""sr-only"">Toggle navigation</span>
					<span class=""icon-bar""></span>
					<span class=""icon-bar""></span>
					<span class=""icon-bar""></span>
				</button>
				<a class=""navbar-brand"" href=""index.html"">Binary admin</a>
			</div>
			<div style=""color: white;
padding: 15px 50px 5px 50px;
float: right;
font-size: 16px;"">
				Last access : 30 May 2014 &nbsp; <a href=""#"" class=""btn btn-danger square-btn-adjust"">Logout</a>
			</div>
		</nav>
		<!-- /. NAV TOP  -->
		");
                Write(
#nullable restore
#line 28 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\_AdminLayout.cshtml"
   await Html.PartialAsync("/Views/Admin2/PartialSideBar.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n\t\t<!-- /. NAV SIDE  -->\n\t\t<div id=\"page-wrapper\">\n\t\t\t<div id=\"page-inner\">\n\t\t\t\t");
                Write(
#nullable restore
#line 32 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\_AdminLayout.cshtml"
     RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n\t\t\t\t<!-- /. ROW  -->\n\t\t\t\t<hr />\n\n\t\t\t\t");
                Write(
#nullable restore
#line 36 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\_AdminLayout.cshtml"
     await Html.PartialAsync("/Views/Admin2/PartialScript.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n\t\t\t</div>\n\t\t</div>\n\t</div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
