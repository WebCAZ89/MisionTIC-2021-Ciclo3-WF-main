#pragma checksum "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\Saludos\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d06713a5f84b4ccc320c1ade38b7f6af3230793e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HolaWeb.App.Frontend.Pages.Saludos.Pages_Saludos_List), @"mvc.1.0.razor-page", @"/Pages/Saludos/List.cshtml")]
namespace HolaWeb.App.Frontend.Pages.Saludos
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
#line 1 "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\_ViewImports.cshtml"
using HolaWeb.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d06713a5f84b4ccc320c1ade38b7f6af3230793e", @"/Pages/Saludos/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"727676028a32bd1748031e664459573a646d94d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Saludos_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Saludos en Varios Idiomas</h1>\n<table class=\"table\">\n");
#nullable restore
#line 7 "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\Saludos\List.cshtml"
     foreach (var saludo in Model.Saludos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 10 "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\Saludos\List.cshtml"
           Write(saludo.EnEspañol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 11 "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\Saludos\List.cshtml"
           Write(saludo.EnIngles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 12 "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\Saludos\List.cshtml"
           Write(saludo.EnItaliano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 14 "C:\MisionTIC-2021-Ciclo3-WF-main\HolaWeb.App.Frontend\Pages\Saludos\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HolaWeb.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolaWeb.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolaWeb.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public HolaWeb.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
