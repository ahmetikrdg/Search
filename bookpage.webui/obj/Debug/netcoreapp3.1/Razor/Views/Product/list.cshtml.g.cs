#pragma checksum "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67cfb53701efee770ec44e850722dcbe2e510d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_list), @"mvc.1.0.view", @"/Views/Product/list.cshtml")]
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
#line 1 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\_ViewImports.cshtml"
using bookpage.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\_ViewImports.cshtml"
using bookpage.webui.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\_ViewImports.cshtml"
using bookpage.webui.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\_ViewImports.cshtml"
using bookpage.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cfb53701efee770ec44e850722dcbe2e510d38", @"/Views/Product/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249fb5af486469a1e15bea12771473aa3aec6af3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
  //buranın layoultla alakası yok
    var popularClass=Model.Products.Count>2?"popular":""; 
    var products=Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    \n");
            DefineSection("Hedaer", async() => {
                WriteLiteral("\n   ");
#nullable restore
#line 13 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("        \n");
#nullable restore
#line 16 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
                 if(products.Count ==0 )
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
           Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
                                                      
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">                  \n");
#nullable restore
#line 23 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
                         foreach (var product in products)
                        {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\n                            ");
#nullable restore
#line 26 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
                       Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\n");
            WriteLiteral("                        </div>       \n");
#nullable restore
#line 29 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
                        
                        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n");
#nullable restore
#line 32 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Product\list.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
