#pragma checksum "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f58c5cb07daa6924602e7a910b56d5b2e024911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Espece_Create), @"mvc.1.0.view", @"/Views/Espece/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Espece/Create.cshtml", typeof(AspNetCore.Views_Espece_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f58c5cb07daa6924602e7a910b56d5b2e024911", @"/Views/Espece/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e82fa09d3434b913ea9c60bd93210f28fccae77", @"/Views/_ViewImports.cshtml")]
    public class Views_Espece_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EspeceModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
  
    ViewData["Title"] = "Ajouter une nouvelle espèce";

#line default
#line hidden
            BeginContext(79, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(84, 17, false);
#line 5 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(101, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 7 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(141, 23, false);
#line 9 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(166, 81, true);
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>espèce</h4>\n        <hr />\n        ");
            EndContext();
            BeginContext(248, 64, false);
#line 14 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(312, 46, true);
            WriteLiteral("\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(359, 92, false);
#line 16 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
       Write(Html.LabelFor(model => model.nom, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(451, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(505, 92, false);
#line 18 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
           Write(Html.EditorFor(model => model.nom, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(597, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(615, 81, false);
#line 19 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.nom, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(696, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(778, 96, false);
#line 24 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
       Write(Html.LabelFor(model => model.nom_alt, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(874, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(928, 96, false);
#line 26 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
           Write(Html.EditorFor(model => model.nom_alt, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1042, 85, false);
#line 27 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.nom_alt, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1209, 99, false);
#line 32 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
       Write(Html.LabelFor(model => model.taille_min, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1362, 99, false);
#line 34 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
           Write(Html.EditorFor(model => model.taille_min, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1479, 88, false);
#line 35 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.taille_min, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 253, true);
            WriteLiteral("\n            </div>\n        </div>\n        \n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 45 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
}

#line default
#line hidden
            BeginContext(1822, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(1834, 40, false);
#line 48 "/home/christophe/Projects/Peche/SitePeche/Views/Espece/Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EspeceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
