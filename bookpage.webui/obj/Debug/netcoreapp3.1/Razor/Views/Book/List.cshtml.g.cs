#pragma checksum "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "359bd52784fc8a13ed969eb5565d39e96517c406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_List), @"mvc.1.0.view", @"/Views/Book/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"359bd52784fc8a13ed969eb5565d39e96517c406", @"/Views/Book/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249fb5af486469a1e15bea12771473aa3aec6af3", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
  //buranın layoultla alakası yok
    var popularClass=Model.Products.Count>2?"popular":""; 
    var products=Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    \n");
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-3\"> ");
            WriteLiteral("\n           ");
#nullable restore
#line 14 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
      Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md-9\">\n       <div class=\"row\">\n              \n                    <div class=\"row\">                  \n");
#nullable restore
#line 20 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                         foreach (var product in products)
                        {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\n                            ");
#nullable restore
#line 23 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                       Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\n");
            WriteLiteral("                        </div>       \n");
#nullable restore
#line 26 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                        }   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <nav aria-label=""Page navigation example"">
                                <ul class=""pagination"">
                                    <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1386, 2);
            WriteAttributeValue("", 1367, "/products?page=", 1367, 15, true);
#nullable restore
#line 32 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
WriteAttributeValue("", 1382, 1, 1382, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ana Sayfa</a>\n");
#nullable restore
#line 33 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                     for (int i = 0; i < Model.pageInfo.TotalPages(); i++)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                         if(string.IsNullOrEmpty(Model.pageInfo.CurrentCategory))//kategori dolumu boşmu
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li");
            BeginWriteAttribute("class", " class=\"", 1741, "\"", 1805, 2);
            WriteAttributeValue("", 1749, "page-item", 1749, 9, true);
#nullable restore
#line 37 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
WriteAttributeValue(" ", 1758, Model.pageInfo.CurrentPage==i+1?"active":"", 1759, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1963, "\"", 1991, 2);
            WriteAttributeValue("", 1970, "/products?page=", 1970, 15, true);
#nullable restore
#line 38 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
WriteAttributeValue("", 1985, i+1, 1985, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("\n                                                ");
#nullable restore
#line 39 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\n                                                </a>\n                                           </li>\n");
#nullable restore
#line 42 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <li");
            BeginWriteAttribute("class", " class=\"", 2451, "\"", 2515, 2);
            WriteAttributeValue("", 2459, "page-item", 2459, 9, true);
#nullable restore
#line 45 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
WriteAttributeValue(" ", 2468, Model.pageInfo.CurrentPage==i+1?"active":"", 2469, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2586, "\"", 2646, 4);
            WriteAttributeValue("", 2593, "/products/", 2593, 10, true);
#nullable restore
#line 46 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
WriteAttributeValue("", 2603, Model.pageInfo.CurrentCategory, 2603, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2634, "?page=", 2634, 6, true);
#nullable restore
#line 46 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
WriteAttributeValue("", 2640, i+1, 2640, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                ");
#nullable restore
#line 47 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </a>\n                                           </li>\n");
#nullable restore
#line 50 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Ahmet\Downloads\bookpages\bookpage.webui\Views\Book\List.cshtml"
                                         
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \n                                </ul>\n                            </nav>\n                        </div>\n                    </div>\n        </div>      \n    </div>\n</div>\n\n        \n             \n\n");
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
