#pragma checksum "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4dec86102e9f3b282bec357f4dd836b6fe36f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_HairStylist), @"mvc.1.0.view", @"/Views/CustomerHome/HairStylist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/HairStylist.cshtml", typeof(AspNetCore.Views_CustomerHome_HairStylist))]
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
#line 2 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
using Gisoo.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4dec86102e9f3b282bec357f4dd836b6fe36f7", @"/Views/CustomerHome/HairStylist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_HairStylist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.LineViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
  
    ViewData["Title"] = "SalonOwner";
    Layout = "~/Views/Shared/_CustomerProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(163, 330, true);
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
#line 17 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                     if (String.IsNullOrEmpty(ViewBag.url))
                    {

#line default
#line hidden
            BeginContext(575, 71, true);
            WriteLiteral("                        <img src=\"/HomeContent/assets/img/avatar.jpg\">\n");
            EndContext();
#line 20 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(715, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 743, "\"", 770, 2);
            WriteAttributeValue("", 749, "/wwwroot/", 749, 9, true);
#line 23 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
WriteAttributeValue("", 758, ViewBag.url, 758, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(771, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 24 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                    }

#line default
#line hidden
            BeginContext(797, 121, true);
            WriteLiteral("                </div>\n                <div class=\"profile__header__user__name\">\n                    <span id=\"testname\">");
            EndContext();
            BeginContext(919, 16, false);
#line 27 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                   Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(935, 212, true);
            WriteLiteral("</span>\n                </div>\n                &nbsp; &nbsp; &nbsp;\n                <div class=\"profile__header__user__name\">\n                    <span id=\"testname\" style=\"color:red\">کد شما برای معرفی به دوستان:");
            EndContext();
            BeginContext(1148, 20, false);
#line 31 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                                                                 Write(ViewBag.identifyCode);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 68, true);
            WriteLiteral("</span>\n                </div>\n                &nbsp; &nbsp; &nbsp;\n");
            EndContext();
#line 34 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                 if (@ViewBag.expireDate != null)
                {

#line default
#line hidden
            BeginContext(1304, 130, true);
            WriteLiteral("                    <div class=\"profile__header__user__name\">\n                        <span style=\"color:red\">تاریخ انقضا پروفایل:");
            EndContext();
            BeginContext(1435, 61, false);
#line 37 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                                               Write(PersianCalendarDate.PersianCalendarResult(ViewBag.expireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 35, true);
            WriteLiteral("</span>\n                    </div>\n");
            EndContext();
#line 39 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                }

#line default
#line hidden
            BeginContext(1549, 37, true);
            WriteLiteral("                &nbsp; &nbsp; &nbsp;\n");
            EndContext();
#line 41 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                 if (@ViewBag.isProfileAccept == false)

                {
                    if (@ViewBag.isProfileComplete == true)
                    {


#line default
#line hidden
            BeginContext(1744, 221, true);
            WriteLiteral("                        <div class=\"profile__header__user__name\">\n                            <span style=\"color:red\">شما پروفایل خود را تکمیل نموده اید لطفا منتظر تایید ادمین بمانید</span>\n                        </div>\n");
            EndContext();
#line 50 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2034, 237, true);
            WriteLiteral("                        <div class=\"profile__header__user__name\">\n                            <span style=\"color:red\">برای تایید کاربری شما باید پروفایل خود را تکمیل نمایید و منتظر تایید ادمین باشید</span>\n                        </div>\n");
            EndContext();
#line 56 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2311, 1375, true);
            WriteLiteral(@"
            </div>
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
                                    <a onclick=""profileManagment()"" style=""cursor:pointer"" @*href=""#!""*@ class=""link""><span>تکمیل اطلاعات پروفایل</span></a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a style=""cursor:pointer"" href=""/CustomerHome/FactorChargeAccount""><span>خرید پکیج(شارژ اکانت)</span></a>
                     ");
            WriteLiteral(@"   </li>
                        <li>
                            <a href=""#""><span>مدیریت لاین ها</span></a>
                            <ul>
                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllLine()"" class=""link""><span>همه لاین های من</span></a>
                                </li>

");
            EndContext();
            BeginContext(3876, 2316, true);
            WriteLiteral(@"                                <li>
                                    <a style=""cursor:pointer"" id=""newLineReserve"" class=""link""><span>ایجاد خدمات</span></a>
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
                                    <a  style=""cursor:pointer"" id=""newAdvertisment"" class=""link""><span>ایجاد تبلیغ</span></a>

                                </li>

                            </ul>
                        </li>
                        <li>
                            <a href=""#""><span>مدیریت آگهی ها</span></a>
                            <ul>
");
            WriteLiteral(@"
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
                                    <a style=""cursor:pointer"" onclick=""showAllReserve()"" class=""link""><span>همه رزرو ها</span></a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </nav>
            </div>
            <div class=""profile__content"">
                <div class=""profile__cont");
            WriteLiteral(@"ent__dashboard"">
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>امتیاز</span>
                                <span>");
            EndContext();
            BeginContext(6193, 17, false);
#line 152 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                 Write(ViewBag.UserScore);

#line default
#line hidden
            EndContext();
            BeginContext(6210, 288, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>آگهی ها</span>
                                <span>");
            EndContext();
            BeginContext(6499, 19, false);
#line 158 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                 Write(ViewBag.TotalNotice);

#line default
#line hidden
            EndContext();
            BeginContext(6518, 296, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>تبلیغات وورکشاپ</span>
                                <span>");
            EndContext();
            BeginContext(6815, 26, false);
#line 164 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                 Write(ViewBag.TotalAdvertisments);

#line default
#line hidden
            EndContext();
            BeginContext(6841, 287, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-lg-3"">
                            <div class=""profile__content__dashboard__item"">
                                <span>رزروها</span>
                                <span>");
            EndContext();
            BeginContext(7129, 20, false);
#line 170 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                 Write(ViewBag.TotalReserve);

#line default
#line hidden
            EndContext();
            BeginContext(7149, 2186, true);
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
<div class=""modal fade"" id=""line-user"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" style=""margin-top: 7px; margin-left: 7px;"">
                </button>
                <h4 class=""modal-title"">سامانه گیسو</h4>
            </div>
            <div class=""modal-body"">
                <p id=""txtLine""></p>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<div id=""ItemId"">
    <input name=""lineid"" id=""lineid"" hidden>
    <input name=""advertismentid"" id=""advertismentid"" hidden>
    <input name=""noticeid"" id=""noticeid"" hidden>
</div>
<script>
    function openTab() {
        $('.profile__wrapper').toggleClass('profile__wrapper--collapse');

    }
    $('.profile__sidebar nav a').on('click', function () {
        if ($(this).hasClass('link')) {
            $('.profile__wrapper').toggleC");
            WriteLiteral("lass(\'profile__wrapper--collapse\');\n        }\n    })\n    window.onload = Load;\n\tfunction Load() {\n        CreateAllModals();\n        if (\'");
            EndContext();
            BeginContext(9336, 16, false);
#line 247 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
        Write(ViewBag.subScore);

#line default
#line hidden
            EndContext();
            BeginContext(9352, 78, true);
            WriteLiteral("\' == \'True\') {\n        $(\'#score-user\').modal(\'show\');\n        }\n        if (\'");
            EndContext();
            BeginContext(9431, 21, false);
#line 250 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
        Write(ViewBag.isReserveWeek);

#line default
#line hidden
            EndContext();
            BeginContext(9452, 70, true);
            WriteLiteral("\' == \'True\') {\n            GetData(\"/CustomerHome/ResearveWeek?lineId=");
            EndContext();
            BeginContext(9523, 14, false);
#line 251 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                                                  Write(ViewBag.lineId);

#line default
#line hidden
            EndContext();
            BeginContext(9537, 40, true);
            WriteLiteral("\", \"divRegister\");\n\n        }\n     if (\'");
            EndContext();
            BeginContext(9578, 24, false);
#line 254 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
     Write(ViewBag.isNoticeShortcut);

#line default
#line hidden
            EndContext();
            BeginContext(9602, 57, true);
            WriteLiteral("\' == 1) {\n\n\t\t\t$(\"#newNotice\").click();\n\t\t}\n        \tif (\'");
            EndContext();
            BeginContext(9660, 32, false);
#line 258 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
            Write(ViewBag.hasadverstitmentshortcut);

#line default
#line hidden
            EndContext();
            BeginContext(9692, 516, true);
            WriteLiteral(@"' == 1) {
			$(""#newAdvertisment"").click();
		}
	}
    function LineRegister() {
        var Parameters = [{ id: ""LineTitle"", htmlname: ""LineTitle"", special: """" },
        { id: ""LineDescription"", htmlname: ""LineDescription"", special: """" },
        { id: ""LinePrice"", htmlname: ""LinePrice"", special: """" },
        { id: ""file"", htmlname: ""file"", special: ""file"" }];
        PostAjax('../CustomerHome/AddLine', Parameters, ""../CustomerHome/HairStylist"");
    }
	 $(""#newLine"").on(""click"", function () {

        if ('");
            EndContext();
            BeginContext(10209, 30, false);
#line 271 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
        Write(ViewBag.TotalCountRegisterLine);

#line default
#line hidden
            EndContext();
            BeginContext(10239, 39, true);
            WriteLiteral("\' < 20) {\n            var compareDate =");
            EndContext();
            BeginContext(10279, 52, false);
#line 272 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                        Write(DateTime.Compare(@ViewBag.expireDate, @DateTime.Now));

#line default
#line hidden
            EndContext();
            BeginContext(10331, 197, true);
            WriteLiteral(";\n            if (compareDate < 0) {\n                $(\'#line-user\').modal(\'show\');\n                $(\'#line-user #txtLine\').html(\"پروفایل شما منقضی شده است\");\n            }\n            else  if (\'");
            EndContext();
            BeginContext(10529, 23, false);
#line 277 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                  Write(ViewBag.isProfileAccept);

#line default
#line hidden
            EndContext();
            BeginContext(10552, 49, true);
            WriteLiteral("\' == \'False\')\n            {\n                if (\'");
            EndContext();
            BeginContext(10602, 25, false);
#line 279 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                Write(ViewBag.isProfileComplete);

#line default
#line hidden
            EndContext();
            BeginContext(10627, 759, true);
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
                    GetData(""/CustomerHome/RegisterLine"", ""divRegister"");
                }
        }
        else {
            $('#line-user').modal('show');
            $('#line-user #txtLine').html(""ثبت لاین از تعداد مجاز گذشته است"");
        }

    });

    $(""#newLineReserve"").on(""click"", function () {
        if ('");
            EndContext();
            BeginContext(11387, 30, false);
#line 300 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
        Write(ViewBag.TotalCountRegisterLine);

#line default
#line hidden
            EndContext();
            BeginContext(11417, 39, true);
            WriteLiteral("\' < 20) {\n            var compareDate =");
            EndContext();
            BeginContext(11457, 52, false);
#line 301 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                        Write(DateTime.Compare(@ViewBag.expireDate, @DateTime.Now));

#line default
#line hidden
            EndContext();
            BeginContext(11509, 196, true);
            WriteLiteral(";\n            if (compareDate < 0) {\n                $(\'#line-user\').modal(\'show\');\n                $(\'#line-user #txtLine\').html(\"پروفایل شما منقضی شده است\");\n            }\n            else if (\'");
            EndContext();
            BeginContext(11706, 23, false);
#line 306 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                 Write(ViewBag.isProfileAccept);

#line default
#line hidden
            EndContext();
            BeginContext(11729, 48, true);
            WriteLiteral("\' ==\'False\')\n            {\n                if (\'");
            EndContext();
            BeginContext(11778, 25, false);
#line 308 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
                Write(ViewBag.isProfileComplete);

#line default
#line hidden
            EndContext();
            BeginContext(11803, 713, true);
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
                GetData(""/CustomerHome/RegisterLineForReserve"", ""divRegister"");
            }
        }
        else {
            $('#line-user').modal('show');
            $('#line-user #txtLine').html(""ثبت لاین از تعداد مجاز گذشته است"");
        }
            });

    if ('");
            EndContext();
            BeginContext(12517, 22, false);
#line 327 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
    Write(ViewBag.isRegisterLine);

#line default
#line hidden
            EndContext();
            BeginContext(12539, 53, true);
            WriteLiteral("\' == \'True\') {\n        showAllLine();\n    }\n    if (\'");
            EndContext();
            BeginContext(12593, 30, false);
#line 330 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
    Write(ViewBag.isRegisterAdvertisment);

#line default
#line hidden
            EndContext();
            BeginContext(12623, 61, true);
            WriteLiteral("\' == \'True\') {\n        showAllAdvertisment();\n    }\n    if (\'");
            EndContext();
            BeginContext(12685, 24, false);
#line 333 "D:\Projects\Gisoo Porject\Gisoo\Gisoo\Views\CustomerHome\HairStylist.cshtml"
    Write(ViewBag.isRegisterNotice);

#line default
#line hidden
            EndContext();
            BeginContext(12709, 2046, true);
            WriteLiteral(@"' == 'True') {
        showAllNotice();
    }

	function showAllLine() {
		GetData(""/CustomerHome/AllLine"", ""divRegister"");
    }
	function Remove() {
		var Parameters = [{ id: ""id"", htmlname: ""lineid"", special: """" }];
        PostAjax('../CustomerHome/Remove', Parameters, window.location.href = ""/CustomerHome/HairStylist?isRegisterLine=true"");
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
    }

    funct");
            WriteLiteral(@"ion AssignButtonClicked(elem, page) {
        if (page == 1) {
            $('#lineid').val($(elem).data('assigned-id'));
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

    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.LineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
