#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a92b599684b4a3d4cb714f960ef882209699450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_UserListPartial), @"mvc.1.0.view", @"/Views/CustomerHome/UserListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/UserListPartial.cshtml", typeof(AspNetCore.Views_CustomerHome_UserListPartial))]
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
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a92b599684b4a3d4cb714f960ef882209699450", @"/Views/CustomerHome/UserListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_UserListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.UserListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/HomeContent/assets/img/store.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
 foreach (var item in Model.Users)
{

#line default
#line hidden
            BeginContext(99, 75, true);
            WriteLiteral("    <div class=\"cat-blog__list\">\n        <div class=\"cat-blog__list__img\">\n");
            EndContext();
#line 7 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
             if (String.IsNullOrEmpty(item.url))
            {
                

#line default
#line hidden
#line 9 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                 if (String.IsNullOrEmpty(item.fullname))
                {

#line default
#line hidden
            BeginContext(313, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 335, "\"", 387, 3);
            WriteAttributeValue("", 342, "/CustomerHome/ProfileUserSingle/", 342, 32, true);
#line 11 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 374, item.id, 374, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 382, "/آگهی", 382, 5, true);
            EndWriteAttribute();
            BeginContext(388, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(389, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a17a27d432b4a66b04f5ec31b7627b5", async() => {
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
            BeginContext(435, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 12 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(497, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 519, "\"", 599, 4);
            WriteAttributeValue("", 526, "/CustomerHome/ProfileUserSingle/", 526, 32, true);
#line 15 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 558, item.id, 558, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 566, "/", 566, 1, true);
#line 15 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 567, item.fullname.Replace(' ', '-'), 567, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(600, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(601, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "692f3fccf5f8427382cb76ed6ca204f6", async() => {
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
            BeginContext(647, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 16 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"

                }

#line default
#line hidden
#line 17 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                 
            }
            else
            {
                

#line default
#line hidden
#line 21 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                 if (String.IsNullOrEmpty(item.fullname))
                {

#line default
#line hidden
            BeginContext(792, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 814, "\"", 866, 3);
            WriteAttributeValue("", 821, "/CustomerHome/ProfileUserSingle/", 821, 32, true);
#line 23 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 853, item.id, 853, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 861, "/آگهی", 861, 5, true);
            EndWriteAttribute();
            BeginContext(867, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 872, "\"", 896, 2);
            WriteAttributeValue("", 878, "/wwwroot", 878, 8, true);
#line 23 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue(" ", 886, item.url, 887, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 6, true);
            WriteLiteral("></a>\n");
            EndContext();
#line 24 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                }
                else

                {

#line default
#line hidden
            BeginContext(961, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 983, "\"", 1063, 4);
            WriteAttributeValue("", 990, "/CustomerHome/ProfileUserSingle/", 990, 32, true);
#line 28 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 1022, item.id, 1022, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1030, "/", 1030, 1, true);
#line 28 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 1031, item.fullname.Replace(' ', '-'), 1031, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1064, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1069, "\"", 1093, 2);
            WriteAttributeValue("", 1075, "/wwwroot", 1075, 8, true);
#line 28 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue(" ", 1083, item.url, 1084, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1094, 6, true);
            WriteLiteral("></a>\n");
            EndContext();
#line 29 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                }

#line default
#line hidden
#line 29 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1132, 133, true);
            WriteLiteral("        </div>\n        <div class=\"cat-blog__list__desc\">\n            <div class=\"cat-blog__list__desc__title\">\n                <h2>\n");
            EndContext();
#line 35 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                     if (String.IsNullOrEmpty(item.fullname))
                    {

#line default
#line hidden
            BeginContext(1349, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1375, "\"", 1427, 3);
            WriteAttributeValue("", 1382, "/CustomerHome/ProfileUserSingle/", 1382, 32, true);
#line 37 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 1414, item.id, 1414, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1422, "/آگهی", 1422, 5, true);
            EndWriteAttribute();
            BeginContext(1428, 10, true);
            WriteLiteral(">آگهی</a>\n");
            EndContext();
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1507, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1533, "\"", 1613, 4);
            WriteAttributeValue("", 1540, "/CustomerHome/ProfileUserSingle/", 1540, 32, true);
#line 41 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 1572, item.id, 1572, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1580, "/", 1580, 1, true);
#line 41 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
WriteAttributeValue("", 1581, item.fullname.Replace(' ', '-'), 1581, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1614, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1616, 13, false);
#line 41 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                                                                                                       Write(item.fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1629, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 42 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1656, 42, true);
            WriteLiteral("                </h2>\n\n            </div>\n");
            EndContext();
#line 46 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
             if (!String.IsNullOrEmpty(item.shortDescription))
            {

#line default
#line hidden
            BeginContext(1775, 57, true);
            WriteLiteral("                <div class=\"cat-blog__list__desc__text\">\n");
            EndContext();
#line 49 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                     if (item.shortDescription.Length > 20)
                    {

#line default
#line hidden
            BeginContext(1914, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(1943, 38, false);
#line 51 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                       Write(item.shortDescription.Substring(0, 20));

#line default
#line hidden
            EndContext();
            BeginContext(1981, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 52 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2055, 28, true);
            WriteLiteral("                        <p> ");
            EndContext();
            BeginContext(2084, 21, false);
#line 55 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
                       Write(item.shortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2105, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 56 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"

                    }

#line default
#line hidden
            BeginContext(2133, 23, true);
            WriteLiteral("                </div>\n");
            EndContext();
#line 59 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(2170, 29, true);
            WriteLiteral("\n\n        </div>\n\n    </div>\n");
            EndContext();
#line 65 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\UserListPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.UserListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
