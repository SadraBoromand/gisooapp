#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec721ab331983c8d40ab09baa9d0d5d7d7fa527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_NoticeListPartial), @"mvc.1.0.view", @"/Views/CustomerHome/NoticeListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/NoticeListPartial.cshtml", typeof(AspNetCore.Views_CustomerHome_NoticeListPartial))]
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
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec721ab331983c8d40ab09baa9d0d5d7d7fa527", @"/Views/CustomerHome/NoticeListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_NoticeListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.NoticeListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/HomeContent/assets/img/ads.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
 foreach (var item in Model.Notices)
{

#line default
#line hidden
            BeginContext(104, 76, true);
            WriteLiteral("    <div class=\"cat-blog__list \">\n        <div class=\"cat-blog__list__img\">\n");
            EndContext();
#line 8 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
             if (!String.IsNullOrEmpty(item.image1))
            {

#line default
#line hidden
            BeginContext(247, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 265, "\"", 337, 4);
            WriteAttributeValue("", 272, "/CustomerHome/NoticeDetail/", 272, 27, true);
#line 10 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 299, item.id, 299, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 307, "/", 307, 1, true);
#line 10 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 308, item.title.Replace(' ', '-'), 308, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(338, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 343, "\"", 361, 1);
#line 10 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 349, item.image1, 349, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(362, 6, true);
            WriteLiteral("></a>\n");
            EndContext();
#line 11 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(413, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 431, "\"", 503, 4);
            WriteAttributeValue("", 438, "/CustomerHome/NoticeDetail/", 438, 27, true);
#line 14 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 465, item.id, 465, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 473, "/", 473, 1, true);
#line 14 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 474, item.title.Replace(' ', '-'), 474, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(504, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(505, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a97bc08f400d4d0796c898860e1300bc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(549, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 15 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(568, 136, true);
            WriteLiteral("        </div>\n        <div class=\"cat-blog__list__desc\">\n            <div class=\"cat-blog__list__desc__title\">\n                <h2>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 704, "\"", 776, 4);
            WriteAttributeValue("", 711, "/CustomerHome/NoticeDetail/", 711, 27, true);
#line 19 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 738, item.id, 738, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 746, "/", 746, 1, true);
#line 19 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
WriteAttributeValue("", 747, item.title.Replace(' ', '-'), 747, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(777, 3, true);
            WriteLiteral(">  ");
            EndContext();
            BeginContext(781, 10, false);
#line 19 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
                                                                                               Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(791, 31, true);
            WriteLiteral("</a> </h2>\n\n            </div>\n");
            EndContext();
#line 22 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
             if (!String.IsNullOrEmpty(item.description))
            {

#line default
#line hidden
            BeginContext(894, 57, true);
            WriteLiteral("                <div class=\"cat-blog__list__desc__text\">\n");
            EndContext();
#line 25 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
                     if (item.description.Length > 20)
                    {

#line default
#line hidden
            BeginContext(1028, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(1057, 33, false);
#line 27 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
                       Write(item.description.Substring(0, 20));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 28 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1164, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(1193, 16, false);
#line 31 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
                       Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 32 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"

                    }

#line default
#line hidden
            BeginContext(1237, 23, true);
            WriteLiteral("                </div>\n");
            EndContext();
#line 35 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(1274, 100, true);
            WriteLiteral("\n            <div class=\"cat-blog__list__desc__info\">\n                <span><i class=\"dn-clock\"></i>");
            EndContext();
            BeginContext(1375, 41, false);
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
                                         Write(DateChanger.calculatDate(item.createDate));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 55, true);
            WriteLiteral("</span>\n\n            </div>\n        </div>\n\n    </div>\n");
            EndContext();
#line 44 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\NoticeListPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.NoticeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
