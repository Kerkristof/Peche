#pragma checksum "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a368ea8dd8af388ce608a3a8163e7521545c0f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_Detail), @"mvc.1.0.view", @"/Views/Site/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Site/Detail.cshtml", typeof(AspNetCore.Views_Site_Detail))]
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
#line 1 "/home/christophe/Projects/Peche/SitePeche/Views/_ViewImports.cshtml"
using SitePeche;

#line default
#line hidden
#line 2 "/home/christophe/Projects/Peche/SitePeche/Views/_ViewImports.cshtml"
using SitePeche.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a368ea8dd8af388ce608a3a8163e7521545c0f9", @"/Views/Site/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e82fa09d3434b913ea9c60bd93210f28fccae77", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
  
    ViewData["Title"] = "Détail du site";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(52, 17, false);
#line 4 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(69, 20, true);
            WriteLiteral("</h2>\n\n\n<h3>Site de ");
            EndContext();
            BeginContext(90, 9, false);
#line 7 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
       Write(Model.nom);

#line default
#line hidden
            EndContext();
            BeginContext(99, 15, true);
            WriteLiteral(" </h3>\n<a>\n    ");
            EndContext();
            BeginContext(115, 77, false);
#line 9 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
Write(Html.ActionLink("Ajouter un nouveau spot","Create","Spot",new{id = Model.id}));

#line default
#line hidden
            EndContext();
            BeginContext(192, 125, true);
            WriteLiteral("\n</a>\n\n<table class =\"table table-striped\">\n    <tr>\n        <td>Nom du spot</td>\n        <td>Coordonnées GPS</td>\n    </tr>\n");
            EndContext();
#line 17 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
     foreach (var item in ViewBag.spot)
    {

#line default
#line hidden
            BeginContext(363, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(385, 8, false);
#line 20 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
       Write(item.nom);

#line default
#line hidden
            EndContext();
            BeginContext(393, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(412, 8, false);
#line 21 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
       Write(item.gps);

#line default
#line hidden
            EndContext();
            BeginContext(420, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 23 "/home/christophe/Projects/Peche/SitePeche/Views/Site/Detail.cshtml"
    }

#line default
#line hidden
            BeginContext(442, 9, true);
            WriteLiteral("</table>\n");
            EndContext();
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
