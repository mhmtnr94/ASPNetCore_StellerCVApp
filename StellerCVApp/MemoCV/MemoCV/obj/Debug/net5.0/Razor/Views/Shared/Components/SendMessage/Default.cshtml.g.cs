#pragma checksum "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\SendMessage\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "eefa5e1f77167eff1dde64cde0b3eeaad068de4816816d2180a327047d747abb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SendMessage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SendMessage/Default.cshtml")]
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
#line 1 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\SendMessage\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"eefa5e1f77167eff1dde64cde0b3eeaad068de4816816d2180a327047d747abb", @"/Views/Shared/Components/SendMessage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2f4f056741db09c5b51dcaadcde0f68c0f1f606638a5fd3144a887667eb0e306", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SendMessage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\SendMessage\Default.cshtml"
 foreach(var item in Model) {

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"form\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eefa5e1f77167eff1dde64cde0b3eeaad068de4816816d2180a327047d747abb4207", async() => {
                WriteLiteral("\n        <div class=\"form-group\">\n            ");
                Write(
#nullable restore
#line 7 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\SendMessage\Default.cshtml"
             item.Email

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            <input type=\"email\" name=\"Mail\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"Enter email\" required>\n        </div>\n        <div class=\"form-group\">\n            ");
                Write(
#nullable restore
#line 11 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\SendMessage\Default.cshtml"
             item.Content

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            <textarea name=\"Content\"");
                BeginWriteAttribute("id", " id=\"", 444, "\"", 449, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"5\" class=\"form-control\" placeholder=\"Message\"></textarea>\n        </div>\n        <button type=\"submit\" class=\"btn btn-primary btn-block rounded w-lg\">Send Message</button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
#nullable restore
#line 17 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\SendMessage\Default.cshtml"
}

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
