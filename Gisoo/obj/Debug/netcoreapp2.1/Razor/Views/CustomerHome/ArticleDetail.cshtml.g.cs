#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40de152c3cb600eb6ff37cf1529619b7c5fb4762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_ArticleDetail), @"mvc.1.0.view", @"/Views/CustomerHome/ArticleDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/ArticleDetail.cshtml", typeof(AspNetCore.Views_CustomerHome_ArticleDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40de152c3cb600eb6ff37cf1529619b7c5fb4762", @"/Views/CustomerHome/ArticleDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_ArticleDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.ArticleDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
  
    ViewData["Title"] = "ArticleDetail";
    Layout = "~/Views/Shared/_CustomerProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(154, 163, true);
            WriteLiteral("\n<section class=\"page-title\">\n    <div class=\"page-title__background\"></div>\n    <div class=\"container\">\n        <div class=\"page-title__wrapper\">\n            <h1>");
            EndContext();
            BeginContext(318, 19, false);
#line 12 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
           Write(Model.Article.title);

#line default
#line hidden
            EndContext();
            BeginContext(337, 112, true);
            WriteLiteral("</h1>\n            <ul>\n                <li><a href=\"/CustomerHome/Index\">صفحه اصلی</a></li>\n                <li>");
            EndContext();
            BeginContext(450, 19, false);
#line 15 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
               Write(Model.Article.title);

#line default
#line hidden
            EndContext();
            BeginContext(469, 513, true);
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>
</section>
<section class=""ads-content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <div class=""ads-content__slider"">
                    <div class=""swiper-container"">
                        <div class=""swiper-wrapper"">
                                <div class=""swiper-slide"">
                                    <div class=""ads-content__slider__item"">
                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 982, "\"", 1008, 1);
#line 29 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 988, Model.Article.image, 988, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1009, 341, true);
            WriteLiteral(@">
                                    </div>
                                </div>
                           

                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-7"">
                <div class=""ads-content__desc"">
                    <p>

                    ");
            EndContext();
            BeginContext(1351, 35, false);
#line 42 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
               Write(Html.Raw(Model.Article.description));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 109, true);
            WriteLiteral("</p>\n                </div>\n               \n            </div>\n        </div>\n        \n    </div>\n</section>\n");
            EndContext();
#line 50 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
 if (Model.Banner != null)
{

#line default
#line hidden
            BeginContext(1524, 121, true);
            WriteLiteral("    <section class=\"banner\">\n        <div class=\"container\">\n            <div class=\"banner__wrapper\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1645, "\"", 1670, 1);
#line 55 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 1652, Model.Banner.link, 1652, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1671, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1676, "\"", 1704, 2);
            WriteAttributeValue("", 1682, "../", 1682, 3, true);
#line 55 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 1685, Model.Banner.image, 1685, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1705, 55, true);
            WriteLiteral("></a>\n            </div>\n        </div>\n    </section>\n");
            EndContext();
#line 59 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
}

#line default
#line hidden
#line 60 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
 if (Model.OtherArticle.Count()>0)
{

#line default
#line hidden
            BeginContext(1799, 401, true);
            WriteLiteral(@"    <section class=""Article-slider"">
        <div class=""container"">
            <div class=""sec-title"">
                <h3><i class=""dn-Article-left""></i>مقالات مرتبط</h3>
                <a href=""/CustomerHome/ArticleList"">بیشتر</a>
            </div>
            <div class=""Article-slider__wrapper"">
                <div class=""swiper-container"">
                    <div class=""swiper-wrapper"">
");
            EndContext();
#line 71 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
                         foreach (var item in Model.OtherArticle)
                        {



#line default
#line hidden
            BeginContext(2294, 249, true);
            WriteLiteral("                            <div class=\"swiper-slide\">\n                                <div class=\"Article-slider__item\">\n                                    <figure class=\"Article-slider__item__image\">\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2543, "\"", 2616, 4);
            WriteAttributeValue("", 2550, "/CustomerHome/ArticleDetail/", 2550, 28, true);
#line 78 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 2578, item.id, 2578, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2586, "/", 2586, 1, true);
#line 78 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 2587, item.title.Replace(' ', '-'), 2587, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2617, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2622, "\"", 2666, 2);
            WriteAttributeValue("", 2628, "/wwwroot/images/Article/", 2628, 24, true);
#line 78 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 2652, item.imageUrl, 2652, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2667, 176, true);
            WriteLiteral("></a>\n                                    </figure>\n                                    <div class=\"Article-slider__item__title\">\n                                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2843, "\"", 2916, 4);
            WriteAttributeValue("", 2850, "/CustomerHome/ArticleDetail/", 2850, 28, true);
#line 81 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 2878, item.id, 2878, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2886, "/", 2886, 1, true);
#line 81 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
WriteAttributeValue("", 2887, item.title.Replace(' ', '-'), 2887, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2917, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2919, 10, false);
#line 81 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
                                                                                                                    Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(2929, 165, true);
            WriteLiteral("</a></h2>\n                                    </div>\n                                    \n\n                                </div>\n                            </div>\n");
            EndContext();
#line 87 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
                        }

#line default
#line hidden
            BeginContext(3120, 1035, true);
            WriteLiteral(@"
                        <div class=""swiper-slide"">
                            <div class=""Article-slider__item Article-slider__item--more"">
                                <figure class=""Article-slider__item__image"">
                                    <img src=""/wwwroot/HomeContent/assets/img/prod.jpg"">
                                </figure>
                                <div class=""Article-slider__item__more"">
                                    <span><i class=""dn-arrow-left""></i>بیشتر</span>
                                </div>
                                <a href=""/CustomerHome/ArticleList""></a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-pagination""></div>
                    <div class=""swiper-btn swiper-btn-prev""><i class=""dn-arrow-right""></i></div>
                    <div class=""swiper-btn swiper-btn-next""><i class=""dn-arrow-left""></i></div>
                </div>
            </div>
        </div>
    ");
            WriteLiteral("</section>\n");
            EndContext();
#line 108 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ArticleDetail.cshtml"
}

#line default
#line hidden
            BeginContext(4157, 5, true);
            WriteLiteral("\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.ArticleDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
