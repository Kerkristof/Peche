#pragma checksum "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f6f72046535b43354abdd4e82f2ff95ca35015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Spot_Create), @"mvc.1.0.view", @"/Views/Spot/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Spot/Create.cshtml", typeof(AspNetCore.Views_Spot_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f6f72046535b43354abdd4e82f2ff95ca35015", @"/Views/Spot/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e82fa09d3434b913ea9c60bd93210f28fccae77", @"/Views/_ViewImports.cshtml")]
    public class Views_Spot_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpotModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
  
    ViewData["Title"] = "Ajouter un nouveau spot";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(78, 17, false);
#line 5 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(95, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 7 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(135, 23, false);
#line 9 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(160, 81, true);
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>espèce</h4>\n        <hr />\n        ");
            EndContext();
            BeginContext(242, 64, false);
#line 14 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(306, 46, true);
            WriteLiteral("\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(353, 92, false);
#line 16 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
       Write(Html.LabelFor(model => model.nom, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(445, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(499, 92, false);
#line 18 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
           Write(Html.EditorFor(model => model.nom, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(591, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(609, 81, false);
#line 19 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.nom, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(690, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(772, 92, false);
#line 24 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
       Write(Html.LabelFor(model => model.gps, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(864, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(918, 92, false);
#line 26 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
           Write(Html.EditorFor(model => model.gps, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1028, 81, false);
#line 27 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.gps, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1191, 96, false);
#line 32 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
       Write(Html.LabelFor(model => model.id_site, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1341, 96, false);
#line 34 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
           Write(Html.EditorFor(model => model.id_site, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1455, 85, false);
#line 35 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.id_site, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 253, true);
            WriteLiteral("\n            </div>\n        </div>\n        \n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 45 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
}

#line default
#line hidden
            BeginContext(1795, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(1807, 47, false);
#line 48 "/home/christophe/Projects/Peche/SitePeche/Views/Spot/Create.cshtml"
Write(Html.ActionLink("Back to List", "Index","Site"));

#line default
#line hidden
            EndContext();
            BeginContext(1854, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpotModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
