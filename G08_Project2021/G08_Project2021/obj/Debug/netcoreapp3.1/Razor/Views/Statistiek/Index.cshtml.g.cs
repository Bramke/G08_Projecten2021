#pragma checksum "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b25359aca283aaa1478bcbaba084994d93f4fe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistiek_Index), @"mvc.1.0.view", @"/Views/Statistiek/Index.cshtml")]
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
#line 1 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\_ViewImports.cshtml"
using G08_Project2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\_ViewImports.cshtml"
using G08_Project2021.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
using G08_Project2021.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b25359aca283aaa1478bcbaba084994d93f4fe0", @"/Views/Statistiek/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343307d52a9f75064abd554d1333490b279bace6", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistiek_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
  
    ViewData["Title"] = "statistiek";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <blockquote class=""blockquote""><br>
                <p class=""mb-0"" style=""font-size: 23px;"">Hier vindt u een algemeen overzicht in verband met klanten en de tickets binnen dit platform.</p>
                
            </blockquote>
        </div>
    </div>
</div>
<div class=""container text-monospace border rounded-0 border-success"" style=""padding: 25px;color: var(--success);"">
    <div class=""row d-xl-flex align-items-xl-center"">
        <div class=""col-md-8 text-center""><img style=""width: 600px;height: 450px;"" src=""img/financial.jpg"" /></div>
        <div class=""col-md-4"">
            <ul>
                <li>Klantenbestand: <b>");
#nullable restore
#line 24 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
                                  Write(ViewData["kl"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\n                <li>Gekende tickets: <b>");
#nullable restore
#line 25 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
                                   Write(ViewData["tk"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\n                <li>Aantal contracten: <b>");
#nullable restore
#line 26 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
                                     Write(ViewData["cl"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></li>
            </ul>
        </div>
    </div>
</div>
<footer class=""blockquote-footer"">Samenvatting</footer>
<div class=""container"" style=""padding: 24px;"">
    <div class=""row text-center"">
        <div class=""col-md-4""><i class=""fa fa-ticket"" style=""color: var(--green);font-size: 36px;""></i>
            <h1>Open</h1>
            <br>
            <h3>");
#nullable restore
#line 37 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
           Write(ViewData["open"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n        <div class=\"col-md-4\"><i class=\"fa fa-window-close-o\" style=\"color: var(--green);font-size: 36px;\"></i>\n            <h1>Gesloten</h1>\n            <br>\n            <h3>");
#nullable restore
#line 42 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
           Write(ViewData["closed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n        <div class=\"col-md-4\"><i class=\"fa fa-server\" style=\"color: var(--green);font-size: 36px;\"></i>\n            <h1>In afwachting</h1>\n            <br>\n            <h3>");
#nullable restore
#line 47 "C:\Users\Bram Krick\Source\Repos\HoGentProjectenII\2021-dotnet-g-08\G08_Project2021\G08_Project2021\Views\Statistiek\Index.cshtml"
           Write(ViewData["total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n    </div>\n</div>\n");
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
