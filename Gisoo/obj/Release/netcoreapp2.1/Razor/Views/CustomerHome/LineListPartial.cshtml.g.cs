#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0168a51c117faf33c1eade1647dcd51c0a6fa6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_LineListPartial), @"mvc.1.0.view", @"/Views/CustomerHome/LineListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/LineListPartial.cshtml", typeof(AspNetCore.Views_CustomerHome_LineListPartial))]
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
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0168a51c117faf33c1eade1647dcd51c0a6fa6dd", @"/Views/CustomerHome/LineListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_LineListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.LineListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/HomeContent/assets/img/facial.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
 foreach (var item in Model.Lines)
{

#line default
#line hidden
            BeginContext(99, 75, true);
            WriteLiteral("    <div class=\"cat-blog__list\">\n        <div class=\"cat-blog__list__img\">\n");
            EndContext();
#line 7 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
             if (item.LineImages.Count() > 0)
            {

#line default
#line hidden
            BeginContext(234, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 252, "\"", 322, 4);
            WriteAttributeValue("", 259, "/CustomerHome/LineDetail/", 259, 25, true);
#line 9 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 284, item.id, 284, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 292, "/", 292, 1, true);
#line 9 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 293, item.title.Replace(' ', '-'), 293, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(323, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 328, "\"", 390, 2);
            WriteAttributeValue("", 334, "/wwwroot/Line/File/", 334, 19, true);
#line 9 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 353, item.LineImages.FirstOrDefault().url, 353, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(391, 6, true);
            WriteLiteral("></a>\n");
            EndContext();
#line 10 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(442, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 460, "\"", 530, 4);
            WriteAttributeValue("", 467, "/CustomerHome/LineDetail/", 467, 25, true);
#line 13 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 492, item.id, 492, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 500, "/", 500, 1, true);
#line 13 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 501, item.title.Replace(' ', '-'), 501, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(531, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(532, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcf222a0308c4208b664fd753ce4cf1e", async() => {
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
            BeginContext(579, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 14 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(598, 136, true);
            WriteLiteral("        </div>\n        <div class=\"cat-blog__list__desc\">\n            <div class=\"cat-blog__list__desc__title\">\n                <h2>  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 734, "\"", 804, 4);
            WriteAttributeValue("", 741, "/CustomerHome/LineDetail/", 741, 25, true);
#line 18 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 766, item.id, 766, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 774, "/", 774, 1, true);
#line 18 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
WriteAttributeValue("", 775, item.title.Replace(' ', '-'), 775, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(805, 3, true);
            WriteLiteral(">  ");
            EndContext();
            BeginContext(809, 10, false);
#line 18 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                                                                                             Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(819, 31, true);
            WriteLiteral("</a> </h2>\n\n            </div>\n");
            EndContext();
#line 21 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
             if (!String.IsNullOrEmpty(item.description))
            {

#line default
#line hidden
            BeginContext(922, 57, true);
            WriteLiteral("                <div class=\"cat-blog__list__desc__text\">\n");
            EndContext();
#line 24 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                     if (item.description.Length > 20)
                    {

#line default
#line hidden
            BeginContext(1056, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(1085, 33, false);
#line 26 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                       Write(item.description.Substring(0, 20));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 27 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1192, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(1221, 16, false);
#line 30 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                       Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 31 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"

                    }

#line default
#line hidden
            BeginContext(1265, 23, true);
            WriteLiteral("                </div>\n");
            EndContext();
#line 34 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(1302, 100, true);
            WriteLiteral("\n            <div class=\"cat-blog__list__desc__info\">\n                <span><i class=\"dn-clock\"></i>");
            EndContext();
            BeginContext(1403, 43, false);
#line 37 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                                         Write(DateChanger.calculatDate(item.registerDate));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 31, true);
            WriteLiteral("</span>\n\n                <span>");
            EndContext();
            BeginContext(1478, 18, false);
#line 39 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
                 Write(item.lineType.name);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 54, true);
            WriteLiteral("</span>\n            </div>\n        </div>\n\n    </div>\n");
            EndContext();
#line 44 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\LineListPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.LineListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591