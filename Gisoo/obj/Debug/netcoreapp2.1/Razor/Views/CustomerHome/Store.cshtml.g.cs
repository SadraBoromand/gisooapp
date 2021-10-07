#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a64126bd0389c322cee37b8fae6be8d3590433d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_Store), @"mvc.1.0.view", @"/Views/CustomerHome/Store.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/Store.cshtml", typeof(AspNetCore.Views_CustomerHome_Store))]
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
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a64126bd0389c322cee37b8fae6be8d3590433d", @"/Views/CustomerHome/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
  
    ViewData["Title"] = "SalonOwner";
    Layout = "~/Views/Shared/_CustomerProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(166, 330, true);
            WriteLiteral(@"
<section class=""profile"">
    <div class=""container"">
        <div class=""profile__header"">
            <div class=""profile__header__toggle"" onclick=""openTab()"">
                <i class=""dn-menu""></i>
            </div>
            <div class=""profile__header__user"">
                <div class=""profile__header__user__avatar"">
");
            EndContext();
#line 17 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                     if (String.IsNullOrEmpty(ViewBag.url))
                    {

#line default
#line hidden
            BeginContext(578, 71, true);
            WriteLiteral("                        <img src=\"/HomeContent/assets/img/avatar.jpg\">\n");
            EndContext();
#line 20 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(718, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 746, "\"", 773, 2);
            WriteAttributeValue("", 752, "/wwwroot/", 752, 9, true);
#line 23 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
WriteAttributeValue("", 761, ViewBag.url, 761, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(774, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 24 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                    }

#line default
#line hidden
            BeginContext(800, 121, true);
            WriteLiteral("                </div>\n                <div class=\"profile__header__user__name\">\n                    <span id=\"testname\">");
            EndContext();
            BeginContext(922, 16, false);
#line 27 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                   Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(938, 212, true);
            WriteLiteral("</span>\n                </div>\n                &nbsp; &nbsp; &nbsp;\n                <div class=\"profile__header__user__name\">\n                    <span id=\"testname\" style=\"color:red\">کد شما برای معرفی به دوستان:");
            EndContext();
            BeginContext(1151, 20, false);
#line 31 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                                                                 Write(ViewBag.identifyCode);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 190, true);
            WriteLiteral("</span>\n                </div>\n                &nbsp; &nbsp; &nbsp;\n                <div class=\"profile__header__user__name\">\n                    <span style=\"color:red\">تاریخ انقضا پروفایل:");
            EndContext();
            BeginContext(1362, 61, false);
#line 35 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                                           Write(PersianCalendarDate.PersianCalendarResult(ViewBag.expireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 68, true);
            WriteLiteral("</span>\n                </div>\n                &nbsp; &nbsp; &nbsp;\n");
            EndContext();
#line 38 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                 if (@ViewBag.isProfileAccept == false)

                {
                    if (@ViewBag.isProfileComplete == true)
                    {


#line default
#line hidden
            BeginContext(1649, 221, true);
            WriteLiteral("                        <div class=\"profile__header__user__name\">\n                            <span style=\"color:red\">شما پروفایل خود را تکمیل نموده اید لطفا منتظر تایید ادمین بمانید</span>\n                        </div>\n");
            EndContext();
#line 47 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1939, 237, true);
            WriteLiteral("                        <div class=\"profile__header__user__name\">\n                            <span style=\"color:red\">برای تایید کاربری شما باید پروفایل خود را تکمیل نمایید و منتظر تایید ادمین باشید</span>\n                        </div>\n");
            EndContext();
#line 53 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2216, 3682, true);
            WriteLiteral(@"            </div>
            <div class=""profile__header__menu"">
                <ul>
                    <li>
                        <a href=""/LogoutCustomer"">خروج</a>

                    </li>
                </ul>
            </div>
        </div>
        <div class=""profile__wrapper"" style=""min-height:350px;"">
            <div class=""profile__sidebar"">
                <nav>
                    <ul>
                        <li>
                            <a href=""#""><span>تکمیل پروفایل</span></a>
                            <ul>
                                <li>
                                    <a style=""cursor:pointer"" onclick=""profileManagment()"" @*href=""#!""*@ class=""link""><span>تکمیل اطلاعات پروفایل</span></a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a style=""cursor:pointer"" href=""/CustomerHome/FactorChargeAccount""><span>خرید پکیج(شارژ اکانت)</span></a>
                      ");
            WriteLiteral(@"  </li>
                        <li>
                            <a href=""#""><span>مدیریت محصولات</span></a>
                            <ul>
                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllProduct()"" class=""link""><span>همه محصولات من</span></a>
                                </li>

                                <li>
                                    <a style=""cursor:pointer"" id=""newProduct"" class=""link""><span>ایجاد محصول</span></a>
                                </li>


                            </ul>
                        </li>
                        <li>
                            <a href=""#""><span>مدیریت تبلیغات و ورکشاپ</span></a>
                            <ul>

                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllAdvertisment()"" class=""link""><span>همه تبلیغات من</span></a>
                                </li>
                                <li>
                ");
            WriteLiteral(@"                    <a style=""cursor:pointer"" id=""newAdvertisment"" class=""link""><span>ایجاد تبلیغ</span></a>

                                </li>

                            </ul>
                        </li>
                        <li>
                            <a href=""#""><span>مدیریت آگهی ها</span></a>
                            <ul>

                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllNotice()"" class=""link""><span>همه آگهی های من</span></a>
                                </li>
                                <li>
                                    <a style=""cursor:pointer"" id=""newNotice"" class=""link""><span>ایجاد آگهی</span></a>

                                </li>

                            </ul>
                        </li>

                        <li>
                            <a href=""#""><span>رزرو ها</span></a>
                            <ul>
                                <li>
                                    <a styl");
            WriteLiteral(@"e=""cursor:pointer"" onclick=""showAllReserve()"" class=""link""><span>همه رزرو ها</span></a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </nav>
            </div>
            <div class=""profile__content"">
                <div class=""profile__content__dashboard"">
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>امتیاز</span>
                                <span>");
            EndContext();
            BeginContext(5899, 17, false);
#line 140 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                 Write(ViewBag.UserScore);

#line default
#line hidden
            EndContext();
            BeginContext(5916, 288, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>آگهی ها</span>
                                <span>");
            EndContext();
            BeginContext(6205, 19, false);
#line 146 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                 Write(ViewBag.TotalNotice);

#line default
#line hidden
            EndContext();
            BeginContext(6224, 296, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>تبلیغات وورکشاپ</span>
                                <span>");
            EndContext();
            BeginContext(6521, 26, false);
#line 152 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                 Write(ViewBag.TotalAdvertisments);

#line default
#line hidden
            EndContext();
            BeginContext(6547, 287, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>رزروها</span>
                                <span>");
            EndContext();
            BeginContext(6835, 20, false);
#line 158 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                                 Write(ViewBag.TotalReserve);

#line default
#line hidden
            EndContext();
            BeginContext(6855, 2193, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div id=""profile__content"" style=""display:none"">

                </div>
                <div id=""divRegister"" style=""display:none"">

                </div>
            </div>
        </div>
    </div>
</section>
<div id=""Error"">

</div>
<div id=""Question"">

</div>
<div id=""Advertisment"">

</div>
<div id=""Notice"">

</div>
<div class=""modal fade"" id=""score-user"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" style=""margin-top: 7px; margin-left: 7px;"">
                </button>
                <h4 class=""modal-title"">سامانه گیسو</h4>
            </div>
            <div class=""modal-body"">
                <p>درخواست شما با موفقیت انجام شد و از امتیاز شما کسر گردید</p>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>");
            WriteLiteral(@"
    <!-- /.modal-dialog -->
</div>
<div class=""modal fade"" id=""product-user"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" style=""margin-top: 7px; margin-left: 7px;"">
                </button>
                <h4 class=""modal-title"">سامانه گیسو</h4>
            </div>
            <div class=""modal-body"">
                <p id=""txtproduct""></p>

            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<div id=""ItemId"">
    <input name=""Productid"" id=""Productid"" hidden>
    <input name=""advertismentid"" id=""advertismentid"" hidden>
    <input name=""noticeid"" id=""noticeid"" hidden>
</div>
<script>
    function openTab() {
        $('.profile__wrapper').toggleClass('profile__wrapper--collapse');

    }
    $('.profile__sidebar nav a').on('click', function () {
        if ($(this).hasClass('link')) {
            $('.profile__wrap");
            WriteLiteral("per\').toggleClass(\'profile__wrapper--collapse\');\n        }\n    })\n    window.onload = Load;\n\tfunction Load() {\n\t\tCreateAllModals();\n        if (\'");
            EndContext();
            BeginContext(9049, 16, false);
#line 236 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
        Write(ViewBag.subScore);

#line default
#line hidden
            EndContext();
            BeginContext(9065, 69, true);
            WriteLiteral("\' == \'True\') {\n        $(\'#score-user\').modal(\'show\');\n\t\t}\n    \tif (\'");
            EndContext();
            BeginContext(9135, 24, false);
#line 239 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
        Write(ViewBag.isNoticeShortcut);

#line default
#line hidden
            EndContext();
            BeginContext(9159, 55, true);
            WriteLiteral("\' == 1) {\n\t\t\t$(\"#newNotice\").click();\n\t\t}\n        if (\'");
            EndContext();
            BeginContext(9215, 32, false);
#line 242 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
        Write(ViewBag.hasadverstitmentshortcut);

#line default
#line hidden
            EndContext();
            BeginContext(9247, 538, true);
            WriteLiteral(@"' == 1) {
			$(""#newAdvertisment"").click();
		}
	}
    function ProductRegister() {
        var Parameters = [{ id: ""ProductTitle"", htmlname: ""ProductTitle"", special: """" },
        { id: ""ProductDescription"", htmlname: ""ProductDescription"", special: """" },
        { id: ""ProductPrice"", htmlname: ""ProductPrice"", special: """" },
        { id: ""file"", htmlname: ""file"", special: ""file"" }];
        PostAjax('../CustomerHome/AddProduct', Parameters, ""../CustomerHome/Store"");
    }
    $(""#newProduct"").on(""click"", function () {
        if ('");
            EndContext();
            BeginContext(9786, 33, false);
#line 254 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
        Write(ViewBag.TotalCountRegisterProduct);

#line default
#line hidden
            EndContext();
            BeginContext(9819, 39, true);
            WriteLiteral("\' < 50) {\n            var compareDate =");
            EndContext();
            BeginContext(9859, 52, false);
#line 255 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                        Write(DateTime.Compare(@ViewBag.expireDate, @DateTime.Now));

#line default
#line hidden
            EndContext();
            BeginContext(9911, 205, true);
            WriteLiteral(";\n            if (compareDate < 0) {\n                $(\'#product-user\').modal(\'show\');\n                $(\'#product-user #txtproduct\').html(\"پروفایل شما منقضی شده است\");\n            }\n            else if (\'");
            EndContext();
            BeginContext(10117, 23, false);
#line 260 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                 Write(ViewBag.isProfileAccept);

#line default
#line hidden
            EndContext();
            BeginContext(10140, 48, true);
            WriteLiteral("\' ==\'False\')\n            {\n                if (\'");
            EndContext();
            BeginContext(10189, 25, false);
#line 262 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
                Write(ViewBag.isProfileComplete);

#line default
#line hidden
            EndContext();
            BeginContext(10214, 703, true);
            WriteLiteral(@"' == 'True') {
                    $('#line-user').modal('show');
                    $('#line-user #txtLine').html(""شما پروفایل خود را تکمیل نموده اید لطفا منتظر تایید ادمین بمانید "");
                }
                else {
                    $('#line-user').modal('show');
                    $('#line-user #txtLine').html(""لطفا اول نسبت به تکمیل پروفایل خود اقدام نمایید "");
                }
            }

            else {
                GetData(""/CustomerHome/RegisterProduct"", ""divRegister"");
            }
        }
        else {
            $('#product-user').modal('show');
            $('#product-user #txtproduct').html(""ثبت کلاس از تعداد مجاز گذشته است"");
        }
    });
    if ('");
            EndContext();
            BeginContext(10918, 25, false);
#line 281 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
    Write(ViewBag.isRegisterProduct);

#line default
#line hidden
            EndContext();
            BeginContext(10943, 56, true);
            WriteLiteral("\' == \'True\') {\n        showAllProduct();\n    }\n    if (\'");
            EndContext();
            BeginContext(11000, 30, false);
#line 284 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
    Write(ViewBag.isRegisterAdvertisment);

#line default
#line hidden
            EndContext();
            BeginContext(11030, 61, true);
            WriteLiteral("\' == \'True\') {\n        showAllAdvertisment();\n    }\n    if (\'");
            EndContext();
            BeginContext(11092, 24, false);
#line 287 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\Store.cshtml"
    Write(ViewBag.isRegisterNotice);

#line default
#line hidden
            EndContext();
            BeginContext(11116, 2062, true);
            WriteLiteral(@"' == 'True') {
        showAllNotice();
    }

	function showAllProduct() {
		GetData(""/CustomerHome/AllProduct"", ""divRegister"");
    }
	function Remove() {
		var Parameters = [{ id: ""id"", htmlname: ""Productid"", special: """" }];
        PostAjax('../CustomerHome/RemoveProduct', Parameters, window.location.href = ""/CustomerHome/Store?isRegisterProduct=true"");
		$(""#QuestionModal"").modal('hide');
        $('.modal-backdrop').remove();

    }
    function RemoveAdvertisment() {
        var Parameters = [{ id: ""id"", htmlname: ""advertismentid"", special: """" }];
        PostAjax('../CustomerHome/RemoveAdvertisment', Parameters, showAllAdvertisment);
        $(""#QuestionModalAdvertisment"").modal('hide');
        $('.modal-backdrop').remove();
    }
    function RemoveNotice() {
        var Parameters = [{ id: ""id"", htmlname: ""noticeid"", special: """" }];
        PostAjax('../CustomerHome/RemoveNotice', Parameters, showAllNotice);
        $(""#QuestionModalNotice"").modal('hide');
        $('.modal-backdrop').remove();
   ");
            WriteLiteral(@" }

    function AssignButtonClicked(elem, page) {
        if (page == 1) {
            $('#Productid').val($(elem).data('assigned-id'));
        }
        if (page == 2) {
            $('#advertismentid').val($(elem).data('assigned-id'));
        }
        if (page == 3) {
            $('#noticeid').val($(elem).data('assigned-id'));
        }

    }
    $(""#newAdvertisment"").on(""click"", function () {
        GetData(""/CustomerHome/RegisterAdvertisment"", ""divRegister"");
    });
    function showAllAdvertisment() {

        GetData(""/CustomerHome/AllAdvertisment"", ""divRegister"");
    }
    $(""#newNotice"").on(""click"", function () {
        GetData(""/CustomerHome/RegisterNotice"", ""divRegister"");
    });
    function showAllNotice() {
        GetData(""/CustomerHome/AllNotice"", ""divRegister"");
	}
  	function profileManagment() {
        GetData(""/CustomerHome/ProfileManagment"", ""divRegister"", null, true);
    }
    function showAllReserve() {
        GetData(""/CustomerHome/AllReserveThisUser"", ""divRegister"");

   ");
            WriteLiteral(" }\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
