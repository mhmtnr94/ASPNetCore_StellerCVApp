#pragma checksum "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Service\AddService.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fdf913ed0b9cb83e62c30583c7f89f8a5c84dd90164fe8501c4a75ecb70f0e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_AddService), @"mvc.1.0.view", @"/Views/Service/AddService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fdf913ed0b9cb83e62c30583c7f89f8a5c84dd90164fe8501c4a75ecb70f0e5c", @"/Views/Service/AddService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2f4f056741db09c5b51dcaadcde0f68c0f1f606638a5fd3144a887667eb0e306", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_AddService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Service\AddService.cshtml"
  
	ViewData["Title"] = "AddService";
	Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h3>Hizmet Ekleme Sayfası</h3>\n");
#nullable restore
#line 8 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Service\AddService.cshtml"
 using (Html.BeginForm("AddService", "Service", FormMethod.Post))
{
	

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 10 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Service\AddService.cshtml"
  Html.Label("Hizmet Başlığı")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 11 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Service\AddService.cshtml"
  Html.TextBoxFor(x => x.Title, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\t<br />\n\t<button class=\"btn btn-info\">Kaydet</button>\n");
#nullable restore
#line 14 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Service\AddService.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
