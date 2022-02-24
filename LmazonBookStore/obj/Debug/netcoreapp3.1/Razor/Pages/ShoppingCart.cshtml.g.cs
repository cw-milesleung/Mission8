#pragma checksum "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da946e500bfcf5e028c66af943feb18e5378740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LmazonBookStore.Pages.Pages_ShoppingCart), @"mvc.1.0.razor-page", @"/Pages/ShoppingCart.cshtml")]
namespace LmazonBookStore.Pages
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
#line 3 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/_ViewImports.cshtml"
using LmazonBookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da946e500bfcf5e028c66af943feb18e5378740", @"/Pages/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d70eebea83dfa3a72d8d0465c581d975a9bc7a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShoppingCart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Shopping Cart</h2>\n\n<table class=\"table table-bordered table-striped\">\n\n    <thead>\n        <tr>\n            <th>Item</th>\n            <th>Quantity</th>\n            <th>Price</th>\n");
            WriteLiteral("            <th>Subtotal</th>\n        </tr>\n    </thead>\n\n    <tbody>\n");
#nullable restore
#line 21 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
         foreach (var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"text-left\">");
#nullable restore
#line 24 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
                                 Write(i.Books.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-center\">");
#nullable restore
#line 25 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
                                   Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 26 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
                                  Write(i.Books.Price.ToString("$#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 27 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
                                   Write((i.Quantity * i.Books.Price).ToString("$#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 29 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\">Total: </td>\n            <td class=\"text-right\">\n                ");
#nullable restore
#line 37 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
           Write(Model.basket.CalcualteTotal().ToString("$#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n    </tfoot>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\">Total Book(s): </td>\n            <td class=\"text-right\">\n                ");
#nullable restore
#line 46 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
           Write(Model.basket.TotalBook());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n\n    </tfoot>\n\n</table>\n\n<div class=\"text-center\">\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1281, "\"", 1304, 1);
#nullable restore
#line 55 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/ShoppingCart.cshtml"
WriteAttributeValue("", 1288, Model.ReturnUrl, 1288, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LmazonBookStore.Pages.ShoppingCartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LmazonBookStore.Pages.ShoppingCartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LmazonBookStore.Pages.ShoppingCartModel>)PageContext?.ViewData;
        public LmazonBookStore.Pages.ShoppingCartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
