#pragma checksum "C:\Users\ESMERALDA GONZALEZ\OneDrive\Documentos\AppBootstrap\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a93f80fbfc40b4fbb4dc3458655f6abebae7d1d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
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
#line 1 "C:\Users\ESMERALDA GONZALEZ\OneDrive\Documentos\AppBootstrap\Views\_ViewImports.cshtml"
using AppBootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESMERALDA GONZALEZ\OneDrive\Documentos\AppBootstrap\Views\_ViewImports.cshtml"
using AppBootstrap.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93f80fbfc40b4fbb4dc3458655f6abebae7d1d6", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f427f5195ac2cfc56dc242b3d1d4ac905ae93d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ESMERALDA GONZALEZ\OneDrive\Documentos\AppBootstrap\Views\Home\Welcome.cshtml"
  
    ViewData["Title"] = "Bienvenidos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 class=""text-center m-2""> Welcome </h2>

 

        <div class=""col-12 d-flex flex-column align-items-center flex-md-row flex-lg-row justify-content-md-center justify-content-lg-center align-items-md-start  align-items-lg-start"">
            <div class=""col-12 col-md-6 col-lg-6 bg-white p-3 border rounded m-2"">

                <h2 class=""text-center m-2""> Bienvenido ");
#nullable restore
#line 13 "C:\Users\ESMERALDA GONZALEZ\OneDrive\Documentos\AppBootstrap\Views\Home\Welcome.cshtml"
                                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"col-12 col-md-6 col-lg-6 bg-white p-3 border rounded m-2\">\r\n\r\n                <p>Bienvenido a mi pagina  ");
#nullable restore
#line 20 "C:\Users\ESMERALDA GONZALEZ\OneDrive\Documentos\AppBootstrap\Views\Home\Welcome.cshtml"
                                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n");
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