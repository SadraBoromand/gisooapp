#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b917831871a2e5a30f5c9d283262e669a58760f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_ArticleListPartial), @"mvc.1.0.view", @"/Views/CustomerHome/ArticleListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/ArticleListPartial.cshtml", typeof(AspNetCore.Views_CustomerHome_ArticleListPartial))]
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
#line 1 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\_ViewImports.cshtml"
using Gisoo;

#line default
#line hidden
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\_ViewImports.cshtml"
using Gisoo.Models;

#line default
#line hidden
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b917831871a2e5a30f5c9d283262e669a58760f8", @"/Views/CustomerHome/ArticleListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_ArticleListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.ArticleListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
 foreach (var item in Model.Articles)
{

#line default
#line hidden
            BeginContext(105, 93, true);
            WriteLiteral("    <div class=\"cat-blog__list\">\n        <div class=\"cat-blog__list__img\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 198, "\"", 271, 4);
            WriteAttributeValue("", 205, "/CustomerHome/ArticleDetail/", 205, 28, true);
#line 7 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
WriteAttributeValue("", 233, item.id, 233, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 241, "/", 241, 1, true);
#line 7 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
WriteAttributeValue("", 242, item.title.Replace(' ', '-'), 242, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(272, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 277, "\"", 321, 2);
            WriteAttributeValue("", 283, "/wwwroot/images/Article/", 283, 24, true);
#line 7 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
WriteAttributeValue("", 307, item.imageUrl, 307, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 142, true);
            WriteLiteral("></a>\n        </div>\n        <div class=\"cat-blog__list__desc\">\n            <div class=\"cat-blog__list__desc__title\">\n                <h2>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 464, "\"", 537, 4);
            WriteAttributeValue("", 471, "/CustomerHome/ArticleDetail/", 471, 28, true);
#line 11 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
WriteAttributeValue("", 499, item.id, 499, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 507, "/", 507, 1, true);
#line 11 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
WriteAttributeValue("", 508, item.title.Replace(' ', '-'), 508, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 3, true);
            WriteLiteral(">  ");
            EndContext();
            BeginContext(542, 10, false);
#line 11 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
                                                                                                Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(552, 30, true);
            WriteLiteral("</a> </h2>\n            </div>\n");
            EndContext();
#line 13 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
             if (!String.IsNullOrEmpty(item.description))
            {

#line default
#line hidden
            BeginContext(654, 57, true);
            WriteLiteral("                <div class=\"cat-blog__list__desc__text\">\n");
            EndContext();
#line 16 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
                     if (item.description.Length > 20)
                    {

#line default
#line hidden
            BeginContext(788, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(817, 33, false);
#line 18 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
                       Write(item.description.Substring(0, 20));

#line default
#line hidden
            EndContext();
            BeginContext(850, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 19 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(924, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(953, 16, false);
#line 22 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
                       Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(969, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 23 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"

                    }

#line default
#line hidden
            BeginContext(997, 23, true);
            WriteLiteral("                </div>\n");
            EndContext();
#line 26 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(1034, 40, true);
            WriteLiteral("\n           \n        </div>\n\n    </div>\n");
            EndContext();
#line 32 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleListPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.ArticleListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591