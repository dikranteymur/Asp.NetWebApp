#pragma checksum "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/Merhaba/ViewliHosgeldiniz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1c8cff7878573ffad9804ff323260084d7543b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Merhaba_ViewliHosgeldiniz), @"mvc.1.0.view", @"/Views/Merhaba/ViewliHosgeldiniz.cshtml")]
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
#line 1 "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/_ViewImports.cshtml"
using ViewYazmak;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/_ViewImports.cshtml"
using ViewYazmak.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1c8cff7878573ffad9804ff323260084d7543b", @"/Views/Merhaba/ViewliHosgeldiniz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf2d86992c07e1b29052996e0df3e722628c1c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Merhaba_ViewliHosgeldiniz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<p>Merhaba <b>");
#nullable restore
#line 5 "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/Merhaba/ViewliHosgeldiniz.cshtml"
         Write(ViewBag.isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n\n");
            WriteLiteral("<p>Merhaba <span class=\"btn btn-primary\">");
#nullable restore
#line 8 "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/Merhaba/ViewliHosgeldiniz.cshtml"
                                    Write(ViewBag.isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>, uygulamamiza hosgeldiniz.</p>\n<p>Merhaba <span class=\"btn btn-danger\">");
#nullable restore
#line 9 "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/Merhaba/ViewliHosgeldiniz.cshtml"
                                   Write(ViewBag.isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>, uygulamamiza hosgeldiniz.</p>\n<p>Merhaba <span class=\"text-danger\">");
#nullable restore
#line 10 "/Users/mdt/Documents/Projelerim/MVCProjeleri/ViewYazmak/Views/Merhaba/ViewliHosgeldiniz.cshtml"
                                Write(ViewBag.isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>, uygulamamiza hosgeldiniz.</p>");
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
