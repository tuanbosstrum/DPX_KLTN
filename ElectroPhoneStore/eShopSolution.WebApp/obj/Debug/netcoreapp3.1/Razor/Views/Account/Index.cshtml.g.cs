#pragma checksum "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c1a2bded4ca5316c73157ecd066858d279bd75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Controllers.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
using eShopSolution.ViewModels.Utilities.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c1a2bded4ca5316c73157ecd066858d279bd75f", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderByUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelOrderStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<style>
    .page-title h1, .page-title h2 {
        font-size: 18px;
        font-weight: 600;
        margin-bottom: 0px;
        font-family: 'Poppins', sans-serif;
    }

    .page-content {
        margin-bottom: 30px;
        padding: 0px;
        overflow: hidden;
    }

        .page-content .page-title,
        .page-title {
            margin: 0 0 5px;
            padding: 0 0 8px;
            border-bottom: 1px solid #e5e5e5;
            position: relative;
        }

            .page-content .page-title:before,
            .page-title:before {
                position: absolute;
                left: 0;
                height: 3px;
                bottom: -2px;
                content: """";
                background: #e83f33;
                width: 130px;
            }
</style>

<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=");
            WriteLiteral(@"""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang ch???</a></li>
                    <li>T??i kho???n</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->
<!-- Main Container -->
<section class=""main-container col2-right-layout"">
    <div class=""main container"">
        <div class=""row"">

            <div class=""my-account"">
                <div class=""page-title"">
                    <h2>T??i kho???n c???a b???n</h2>
                </div>
                <div class=""col-main col-sm-12 col-xs-12"">
                    <div class=""welcome-msg"">
");
#nullable restore
#line 76 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                          
                            var claims = User.Claims.ToList();
                            var name = claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName).Value;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <strong>Xin ch??o, ");
#nullable restore
#line 80 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                     Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</strong>\r\n                        <p>T??? Trang t???ng quan t??i kho???n c???a b???n, b???n c?? th??? xem v??? c??c ????n h??ng g???n ????y v?? c???p nh???t th??ng tin t??i kho???n c???a m??nh.</p>\r\n                    </div>\r\n                    <div class=\"recent-orders\">\r\n\r\n");
#nullable restore
#line 85 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                         if (TempData["CancelOrderSuccess"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <script>
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'H???y ????n th??nh c??ng',
                                    showConfirmButton: false,
                                    timer: 1500
                                })
                            </script>
");
#nullable restore
#line 96 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                        }
                        else if (TempData["UpdateAccountSuccess"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <script>
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'C???p nh???t th??ng tin c?? nh??n th??nh c??ng',
                                    showConfirmButton: false,
                                    timer: 1500
                                })
                            </script>
");
#nullable restore
#line 108 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                        }
                        else if (TempData["ChangePasswordSuccess"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <script>
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'C???p nh???t m???t kh???u th??nh c??ng',
                                    showConfirmButton: false,
                                    timer: 1500
                                })
                            </script>
");
#nullable restore
#line 120 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""title-buttons""><strong>????n h??ng g???n ????y</strong> <a href=""#"">View All </a> </div>

                        <div class=""table-responsive"">
                            <table class=""table table-bordered cart_summary table-striped"" style=""margin-top:10px"">
                                <colgroup>
                                    <col>
                                    <col>
                                    <col>
                                    <col width=""1"">
                                    <col width=""1"">
                                    <col width=""1"">
                                </colgroup>
                                <thead>
                                    <tr class=""first last"">
                                        <th class=""text-center"">
                                            ID
                                        </th>
                                        <th>
                                          ");
            WriteLiteral(@"  Kh??ch h??ng
                                        </th>
                                        <th class=""text-center"">
                                            Ng??y ?????t
                                        </th>
                                        <th class=""text-center"">
                                            Tr???ng th??i
                                        </th>
                                        <th class=""text-center"">
                                            Gi?? tr??? ????n h??ng
                                        </th>
                                        <th class=""text-center"">
                                            X??? l?? ????n
                                        </th>
                                        <th class=""text-center"">
                                            Thao t??c
                                        </th>
                                    </tr>
                                </thead>
                                ");
            WriteLiteral("<tbody>\r\n");
#nullable restore
#line 160 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                     foreach (var item in Model.Orders)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"first odd\">\r\n                                            <td>");
#nullable restore
#line 163 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 164 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\">");
#nullable restore
#line 165 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                               Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\">\r\n");
#nullable restore
#line 167 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                  
                                                    var status = "";
                                                    var statusEnum = (int)item.Status;
                                                    switch (statusEnum)
                                                    {
                                                        case 1:
                                                            status = "??ang ch??? duy???t";
                                                            break;
                                                        case 2:
                                                            status = "???? duy???t";
                                                            break;
                                                        case 3:
                                                            status = "??ang giao";
                                                            break;
                                                        case 4:
                                                            status = "???? giao";
                                                            break;
                                                        case 5:
                                                            status = "???? hu???";
                                                            break;
                                                        default:
                                                            status = "...";
                                                            break;
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i>");
#nullable restore
#line 192 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                              Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                            </td>\r\n                                            <td class=\"text-center\">\r\n\r\n                                                <strong>\r\n                                                    ");
#nullable restore
#line 197 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                               Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    <span>&#8363;</span>
                                                </strong>
                                            </td>
                                            <td class=""text-center"">

");
#nullable restore
#line 203 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                 if (item.Status == (OrderStatus)1)
                                                {
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c1a2bded4ca5316c73157ecd066858d279bd75f18807", async() => {
                WriteLiteral("H???y ????n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 206 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 207 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                }
                                                else if (item.Status == (OrderStatus)2)
                                                {
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c1a2bded4ca5316c73157ecd066858d279bd75f21583", async() => {
                WriteLiteral("H???y ????n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 211 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 212 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td class=\"text-center\">\r\n                                                ");
#nullable restore
#line 215 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                           Write(Html.ActionLink("Xem chi ti???t", "OrderDetail", new { orderId = item.Id, name = item.Name }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 218 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <br/>
                    <div class=""box-account"">
                        <div class=""page-title"">
                            <h2>Th??ng tin t??i kho???n</h2>
                        </div>
                        <br/>
                        <div class=""col2-set"">
                            <div class=""col-1"">
                                <h6>Th??ng tin li??n l???c</h6>
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"">
                                        <thead>
                                            <tr>
                                                <th>H??? T??n</th>
                                                <th>Email</th>
                                                <th>S??? ??i???n tho???i kh??ch h??ng</th>
                                ");
            WriteLiteral(@"                <th>?????a ch???</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr class=""active"">
                                                <td>");
#nullable restore
#line 244 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 245 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 246 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                               Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 247 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                               Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class=""text-center"">
                                    <button type=""button"" class=""btn btn-primary align-center-btn""><i class=""fa fa-user-circle""></i>
                                            ");
#nullable restore
#line 254 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                       Write(Html.ActionLink("C???p nh???t", "Edit", new { userid = Model.UserID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </button>\r\n                                    <button type=\"button\" class=\"btn btn-danger align-center-btn\"><i class=\"fa fa-pencil\"></i>\r\n                                            ");
#nullable restore
#line 257 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Account\Index.cshtml"
                                       Write(Html.ActionLink("?????i m???t kh???u", "ChangePassword", new { userid = Model.UserID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </button>
                                </div>  
                                </div>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderByUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
