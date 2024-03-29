#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca57f31b5cbbf116f9922e226ca30f9936d3533c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_ArticleList), @"mvc.1.0.view", @"/Views/CustomerHome/ArticleList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/ArticleList.cshtml", typeof(AspNetCore.Views_CustomerHome_ArticleList))]
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
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca57f31b5cbbf116f9922e226ca30f9936d3533c", @"/Views/CustomerHome/ArticleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_ArticleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.ArticleListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
  
    ViewData["Title"] = "ArticleDetail";
    Layout = "~/Views/Shared/_CustomerProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(173, 618, true);
            WriteLiteral(@"

<section class=""page-title"">
    <div class=""page-title__background""></div>
    <div class=""container"">
        <div class=""page-title__wrapper"">
            <h1>تمام مقالات</h1>
            <ul>
                <li><a href=""/CustomerHome/Index"">صفحه اصلی</a></li>
                <li>تمام مقالات</li>
            </ul>
        </div>
    </div>
</section>
<section class=""cat-blog"">
    <div class=""container"">


        <div class=""row"">
            <div class=""col-lg-9"">
                <div class=""cat-blog__title"">
                    <h3>مقالات</h3>
                </div>
                <div id=""yourDiv"">

");
            EndContext();
#line 33 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                     foreach (var item in Model.Articles)
                    {

#line default
#line hidden
            BeginContext(871, 186, true);
            WriteLiteral("                        <div class=\"cat-blog__list\">\n                            <div class=\"cat-blog__list__img\">\n                                \n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1130, 4);
            WriteAttributeValue("", 1064, "/CustomerHome/ArticleDetail/", 1064, 28, true);
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 1092, item.id, 1092, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1100, "/", 1100, 1, true);
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 1101, item.title.Replace(' ', '-'), 1101, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1131, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1136, "\"", 1180, 2);
            WriteAttributeValue("", 1142, "/wwwroot/images/Article/", 1142, 24, true);
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 1166, item.imageUrl, 1166, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1181, 254, true);
            WriteLiteral("></a>\n                               \n                            </div>\n                            <div class=\"cat-blog__list__desc\">\n                                <div class=\"cat-blog__list__desc__title\">\n                                    <h2>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1508, 4);
            WriteAttributeValue("", 1442, "/CustomerHome/ArticleDetail/", 1442, 28, true);
#line 43 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 1470, item.id, 1470, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1478, "/", 1478, 1, true);
#line 43 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 1479, item.title.Replace(' ', '-'), 1479, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1509, 3, true);
            WriteLiteral(">  ");
            EndContext();
            BeginContext(1513, 10, false);
#line 43 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                                                                                                                    Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 51, true);
            WriteLiteral("</a> </h2>\n\n                                </div>\n");
            EndContext();
#line 46 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                                 if (!String.IsNullOrEmpty(item.description))
                                {

#line default
#line hidden
            BeginContext(1686, 77, true);
            WriteLiteral("                                    <div class=\"cat-blog__list__desc__text\">\n");
            EndContext();
#line 49 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                                         if (item.description.Length > 20)
                                        {

#line default
#line hidden
            BeginContext(1880, 47, true);
            WriteLiteral("                                            <p>");
            EndContext();
            BeginContext(1928, 43, false);
#line 51 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                                          Write(Html.Raw(item.description.Substring(0, 20)));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 52 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2105, 80, true);
            WriteLiteral("                                    <p>\n                                        ");
            EndContext();
            BeginContext(2186, 26, false);
#line 56 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                                   Write(Html.Raw(item.description));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 7, true);
            WriteLiteral(" </p >\n");
            EndContext();
#line 57 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"

                                }

#line default
#line hidden
            BeginContext(2254, 36, true);
            WriteLiteral("                            </div >\n");
            EndContext();
#line 60 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
                        }

#line default
#line hidden
            BeginContext(2316, 56, true);
            WriteLiteral("\n\n\n                    </div >\n\n                </div >\n");
            EndContext();
#line 67 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
            }

#line default
#line hidden
            BeginContext(2386, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2631, 126, true);
            WriteLiteral("</div>\n                <div id=\"mydiv2\"></div>\n            </div>\n\n                \n            </div>\n\n    </div>\n</section>\n");
            EndContext();
#line 86 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
 if (Model.Banner != null)
{

#line default
#line hidden
            BeginContext(2786, 121, true);
            WriteLiteral("    <section class=\"banner\">\n        <div class=\"container\">\n            <div class=\"banner__wrapper\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2907, "\"", 2932, 1);
#line 91 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 2914, Model.Banner.link, 2914, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2933, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2938, "\"", 2963, 1);
#line 91 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
WriteAttributeValue("", 2944, Model.Banner.image, 2944, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2964, 55, true);
            WriteLiteral("></a>\n            </div>\n        </div>\n    </section>\n");
            EndContext();
#line 95 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleList.cshtml"
}

#line default
#line hidden
            BeginContext(3021, 137, true);
            WriteLiteral("<script>\n        window.onscroll = function () {\n            LoadListNotice(\"/CustomerHome/ArticleListPartial\");\n        }\n</script>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.ArticleListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
