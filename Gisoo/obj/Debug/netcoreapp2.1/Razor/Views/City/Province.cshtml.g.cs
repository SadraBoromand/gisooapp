#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04424e75a6724a3a199baddba5fd82fa5b197e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_Province), @"mvc.1.0.view", @"/Views/City/Province.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/City/Province.cshtml", typeof(AspNetCore.Views_City_Province))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04424e75a6724a3a199baddba5fd82fa5b197e4", @"/Views/City/Province.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_City_Province : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<Gisoo.Models.Province>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProvince", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Province", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ProvinceForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 155, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-xs-12\">\n        <div class=\"box\">\n            <div class=\"box-header\">\n                <h3 class=\"box-title\">شهرستان ");
            EndContext();
            BeginContext(212, 26, false);
#line 6 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                                         Write(ViewData["parentCityName"]);

#line default
#line hidden
            EndContext();
            BeginContext(238, 66, true);
            WriteLiteral("</h3>\n                <br />\n                <p style=\"color:red\">");
            EndContext();
            BeginContext(305, 15, false);
#line 8 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                                Write(ViewBag.success);

#line default
#line hidden
            EndContext();
            BeginContext(320, 228, true);
            WriteLiteral("</p>\n            </div>\n\n            <div class=\"row\">\n                <div class=\"col-md-12\">\n                    <a class=\"btn btn-default\" data-toggle=\"modal\" data-target=\"#modal-default\">شهرستان جدید</a>\n                    ");
            EndContext();
            BeginContext(548, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a34c55244b74234aaec0fa3df29c4a8", async() => {
                BeginContext(593, 6, true);
                WriteLiteral("بازگشت");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(603, 443, true);
            WriteLiteral(@"

                </div>

            </div>
            <!-- /.box-header -->
            <div class=""box-body table-responsive"">
                <table id=""example2"" class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>عنوان</th>

                            <th>امکانات</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 30 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1125, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(1195, 9, false);
#line 33 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 138, true);
            WriteLiteral("</td>\n\n                                <td>\n                                    <button name=\"Edit-Province\" data-toggle=\"modal\" data-id=\"");
            EndContext();
            BeginContext(1343, 7, false);
#line 36 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                                                                                         Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1350, 80, true);
            WriteLiteral("\" class=\"btn btn-default\">ویرایش</button>\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1430, "\"", 1459, 2);
            WriteAttributeValue("", 1437, "/City/Area?id=", 1437, 14, true);
#line 37 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
WriteAttributeValue("", 1451, item.id, 1451, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1460, 70, true);
            WriteLiteral(" class=\"btn btn-default\">حومه</a>\n                                    ");
            EndContext();
            BeginContext(1530, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9523ec97a72b41148e7e004ae17b879b", async() => {
                BeginContext(1609, 3, true);
                WriteLiteral("حذف");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                                                                     WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1616, 74, true);
            WriteLiteral("\n\n                                </td>\n                            </tr>\n");
            EndContext();
#line 42 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                        }

#line default
#line hidden
            BeginContext(1716, 440, true);
            WriteLiteral(@"                    </tbody>
                    <tfoot>
                    </tfoot>
                </table>
            </div>
            <!-- /.box-body -->
            <div class=""row"">
                <div class=""col-sm-5"">
                </div>
                <div class=""col-sm-7"">
                    <div class=""dataTables_paginate paging_simple_numbers"" id=""example1_paginate"">
                        <ul class=""pagination"">
");
            EndContext();
            BeginContext(2580, 65, true);
            WriteLiteral("                            <li>\n                                ");
            EndContext();
            BeginContext(2645, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f77500086de24a42bfd328f923c6f3a8", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
#line 62 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
                                                                                                   WriteLiteral(ViewData["parentCityId"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2753, 600, true);
            WriteLiteral(@"
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- /.col -->
</div>
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">شهرستان</h4>
            </div>
            ");
            EndContext();
            BeginContext(3353, 1187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc27f666043a426893e5e4c1980fbe71", async() => {
                BeginContext(3377, 129, true);
                WriteLiteral("\n                <input type=\"hidden\" id=\"id\" name=\"id\" value=\"\" />\n                <div class=\"modal-body\">\n                    ");
                EndContext();
                BeginContext(3506, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5c000bbd31345f194e9ce2bbfe7ad87", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 85 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3572, 88, true);
                WriteLiteral("\n                    <input class=\"form-control\" type=\"hidden\" id=\"cityId\" name=\"cityId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3660, "\"", 3693, 1);
#line 86 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\City\Province.cshtml"
WriteAttributeValue("", 3668, ViewData["parentCityId"], 3668, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3694, 839, true);
                WriteLiteral(@">

                    <div class=""form-group"">
                        <label class=""control-label"">عنوان شهرستان</label>
                        <input class=""form-control"" type=""text"" data-val=""true"" data-val-maxlength=""عنوان شهرستان نمی تواند بیشتر از 50 کاراکتر باشد ."" data-val-maxlength-max=""50"" data-val-required=""لطفا عنوان شهرستان را وارد کنید"" id=""name"" name=""name"" value="""">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""name"" data-valmsg-replace=""true""></span>
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">خروج</button>
                    <button type=""submit"" class=""btn btn-primary"">ذخیره</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4540, 95, true);
            WriteLiteral("\n        </div>\n        <!-- /.modal-content -->\n    </div>\n    <!-- /.modal-dialog -->\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4657, 3042, true);
                WriteLiteral(@"
    <script>
        $(""#ProvinceForm"").submit(function (event) {
            event.preventDefault();
            if ($('#ProvinceForm').valid()) {
                var pagenumber = $(""#PageNumber"").val();
                var form = $(this).serialize();
                $.ajax({
                    url: ""/City/CreateOrEditProvince"",
                    method: ""POST"",
                    data: form,
                    success: function (data) {
                        $('#modal-default').modal('hide');
                        var messageText = """";
                        if ($('#modal-default #id').val() != '' && $('#modal-default #id').val() != 0) {
                            messageText = 'ویرایش  شهرستان با موفقیت انجام شد';
                        }
                        else {
                            messageText = 'اضافه کردن شهرستان با موفقیت انجام شد';
                        }
                        swal({
                            title: '!  موفقیت آمیز',
                            text: m");
                WriteLiteral(@"essageText,
                            type: 'success',
                            buttonsStyling: false,
                            confirmButtonClass: 'btn btn-sm btn-light',
                            background: 'rgba(0, 0, 0, 0.96)',
                            timer: 1500
                        })
                        var id = $(""#categoryForm #id"").val();
                        if(id!="""")
                            location.reload();
                        else
                        window.location.href = ""/City/Province?page=1"";
                    },
                    error: function () {
                        alert(""Ajax call failed"");
                    }
                })
            }
        });
        $(""button[name='Edit-Province']"").click(function (e) {
            $(""#Province-header"").html(""ویرایش شهرستان"");
            var Id = $(this).attr(""data-id"");
            $.ajax({
                url: ""/City/GetProvince?id="" + Id + """",
                method: ""Get"",
           ");
                WriteLiteral(@"     dataType: ""json"",
                success: function (data) {
                    if (data.id != 0) {
                        $(""#ProvinceForm #id"").val(data.id);
                        $(""#ProvinceForm #name"").val(data.name);
                        $('#modal-default').modal('show');
                    }
                    else {
                        alert(""ID is incorrect"");
                    }
                },
                error: function () {
                    alert(""Ajax call failed"");
                }
            })
        })

        $('#modal-default').on('hidden.bs.modal', function () {
            $('#modal-default').find('input,textarea,select').each(function (key) {
                if ($(this).attr('id') == ""id"") {
                    $(this).val(0);
                }
                else
                    if ($(this).attr('name') != '__RequestVerificationToken')
                        $(this).val('');
            })
        })
    </script>


");
                EndContext();
            }
            );
            BeginContext(7701, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<Gisoo.Models.Province>> Html { get; private set; }
    }
}
#pragma warning restore 1591
