#pragma checksum "C:\Users\kirkv\source\repos\SportsSln\SportsStore\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77055c36abedd0fc7aab8eded50ed4979589a89e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
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
#line 1 "C:\Users\kirkv\source\repos\SportsSln\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kirkv\source\repos\SportsSln\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77055c36abedd0fc7aab8eded50ed4979589a89e", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6be88c1bac6dc747b5be12ee9840e678d704bb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class =\"card card-outline-primary m-1 p-1\">  \r\n    <div class =\"bg-faded p-1\"> \r\n        <h4>\r\n            ");
#nullable restore
#line 6 "C:\Users\kirkv\source\repos\SportsSln\SportsStore\Views\Shared\ProductSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class =\" badge badge-pill badge-primary\" style =\" float:right\"> \r\n                <small>");
#nullable restore
#line 8 "C:\Users\kirkv\source\repos\SportsSln\SportsStore\Views\Shared\ProductSummary.cshtml"
                  Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>  \r\n                </span>  \r\n            </h4>   \r\n        </div> \r\n    <div class =\"card-text p-1\">");
#nullable restore
#line 12 "C:\Users\kirkv\source\repos\SportsSln\SportsStore\Views\Shared\ProductSummary.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> \r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
