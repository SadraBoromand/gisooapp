#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c98b1ddce5bb9eb01bedbcf3410c19de0f0e2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_ChangeRolePartial), @"mvc.1.0.view", @"/Views/CustomerHome/ChangeRolePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/ChangeRolePartial.cshtml", typeof(AspNetCore.Views_CustomerHome_ChangeRolePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c98b1ddce5bb9eb01bedbcf3410c19de0f0e2c", @"/Views/CustomerHome/ChangeRolePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_ChangeRolePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Gisoo.Models.Role>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ChangeRole"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 349, true);
            WriteLiteral(@"
<section class=""blog"">
    <div class=""container"">
        <div class=""sec-title"">
            <h3><i class=""dn-line-left""></i>تغییر نوع کاربری</h3>
        </div>
        <div class=""blog__wrapper"">
            <div class=""row"">
                <div class=""col-md-6 form-group"">
                    <select class=""form-control"" id=""roleSelected"">
");
            EndContext();
#line 12 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#line 14 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml"
                             if (!(item.RoleNameEn == "Member" || item.RoleNameEn == "Admin"))
                            {

#line default
#line hidden
            BeginContext(584, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(612, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1d4321eb494a3aaeb0ad358a9c5139", async() => {
                BeginContext(646, 15, false);
#line 16 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml"
                                                        Write(item.RoleNameFa);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 16 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml"
                               WriteLiteral(item.RoleNameEn);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(670, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 17 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml"
                                }

#line default
#line hidden
#line 17 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\ChangeRolePartial.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(735, 426, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""col-md-6"">
                    <button type=""button"" onclick=""RegisterRoleMember(document.getElementById('roleSelected').value);"" class=""btn"" style=""margin-top:3px"">ثبت</button>
                </div>
            </div>
        </div>
    </div>
</section>
<div class=""modal fade"" id=""register-user-role"">
    <div class=""modal-dialog"">
        ");
            EndContext();
            BeginContext(1161, 1092, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cf800bcff924e01b98dd84c2b945eaf", async() => {
                BeginContext(1201, 1045, true);
                WriteLiteral(@"
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" style=""margin-top: 7px; margin-left: 7px;"">
                    </button>
                    <h4 class=""modal-title"">سامانه گیسو</h4>
                </div>
                <div class=""modal-body"">
                    <p style=""color:red"">  پس از یکبار تغییر نوع کاربری دیگر قادر به تغییر مجدد آن نمی باشید و با هر شماره فقط یک نوع کاربری در سیستم نقش ایفا می نمایید و اگر بخواهید تحت عنوان سایر نوع کاربری ها در سایت فعالیت نمایید لطفا با یک شماره جدید وارد شوید</p>
                    <p>آیا از تغییر نوع کاربری زیر اطمینان دارید؟ </p>
                    <input class=""form-control"" disabled id=""roleNameFa"" name=""roleNameFa"" value=""""/>
                    <input class=""form-control"" hidden id=""roleNameEng"" name=""roleNameEng"" value=""""/>
                    <button type=""submit"" class=""btn"" style=""margin-top:3px"">بلی</button>
                </div>
      ");
                WriteLiteral("      </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2253, 403, true);
            WriteLiteral(@"
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<script>
    function RegisterRoleMember(roleNameEng) {
        $('#register-user-role #roleNameEng').val(roleNameEng);
        var roleNameFa = $(""#roleSelected option:selected"").text();
        $('#register-user-role #roleNameFa').val(roleNameFa);
        $('#register-user-role').modal('show');
       


    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Gisoo.Models.Role>> Html { get; private set; }
    }
}
#pragma warning restore 1591
