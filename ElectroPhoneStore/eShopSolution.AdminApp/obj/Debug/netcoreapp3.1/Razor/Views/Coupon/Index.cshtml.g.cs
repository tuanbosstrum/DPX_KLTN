#pragma checksum "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e73eaa28853c6ee0fd2e078d2c084b9a062996b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coupon_Index), @"mvc.1.0.view", @"/Views/Coupon/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73eaa28853c6ee0fd2e078d2c084b9a062996b1", @"/Views/Coupon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e4c500cfeba51cc3f15b2138c785a921f881f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Coupon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<CouponViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coupon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
  
    ViewData["Title"] = "Danh sách khuyến mãi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách khuyến mãi</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a style=""color: #0779e4;"" href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách khuyến mãi</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-7 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e73eaa28853c6ee0fd2e078d2c084b9a062996b16528", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-5 col-xs-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e73eaa28853c6ee0fd2e078d2c084b9a062996b18073", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-9\">\r\n");
                WriteLiteral("                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1122, "\"", 1146, 1);
#nullable restore
#line 27 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
WriteAttributeValue("", 1130, ViewBag.Keyword, 1130, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""keyword"" class=""form-control"" />
                            </div>
                            <div class=""col-md-3"">
                                <button type=""submit"" class=""btn btn-info""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                                <button type=""button"" onclick=""window.location.href='/Coupon/Index'"" class=""btn btn-secondary"">Đặt lại</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 40 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
             if (TempData["CreateCouponSuccessful"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <script>
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Thêm coupon thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                </script>
");
#nullable restore
#line 51 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
            }
            else if (TempData["UpdateCouponSuccessful"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <script>
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Cập nhật coupon thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                </script>
");
#nullable restore
#line 63 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
            }
            else if (TempData["DeleteCouponSuccessful"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <script>
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Xóa coupon thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                </script>
");
#nullable restore
#line 75 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""text-center"">
                                ID
                            </th>
                            <th>
                                Mã
                            </th>
                            <th class=""text-center"">
                                Số lượng
                            </th>
                            <th class=""text-center"">
                                Phần trăm giảm
                            </th>
                            <th>
                                Thao tác
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 98 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 102 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 105 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 108 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 111 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Promotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <button class=\"btn btn-primary\">");
#nullable restore
#line 114 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                                                               Write(Html.ActionLink("Xem chi tiết", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                    <button class=\"btn btn-success\">");
#nullable restore
#line 115 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                                                               Write(Html.ActionLink("Cập nhật", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                    <button class=\"btn btn-danger\">");
#nullable restore
#line 116 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                                                              Write(Html.ActionLink("Xóa", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 119 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<CouponViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591