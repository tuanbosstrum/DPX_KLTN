#pragma checksum "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a787811b76f24987f38898910d0041c4cd61ae8e"
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
#line 1 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a787811b76f24987f38898910d0041c4cd61ae8e", @"/Views/Coupon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Coupon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<CouponViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/flashSALE.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("HTML template"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coupon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
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
                background: #31ad85;
                width: 130px;
            }

    .shop-inner {
        padding: 0px 0px 20px 0px;
        margin-bottom: 0px;
    }

    .products-grid {
        margin: 0;
        list-style: none
    }

    ul.products-grid {
 ");
            WriteLiteral(@"       padding: 0;
        margin: 0
    }

    .products-grid .item {
        margin-top: 20px;
    }

    .col-main .product-grid-area .products-grid {
        margin-left: -15px;
        margin-right: -15px
    }

    .product-item .pr-img-area {
        overflow: hidden;
        position: relative;
        border: 1px #e5e5e5 solid;
    }

        .product-item .pr-img-area a {
            display: block
        }

        .product-item .pr-img-area > a::before {
            background: #444 none repeat scroll 0 0;
            content: """";
            height: 100%;
            opacity: 0;
            position: absolute;
            transition: all 0.9s ease 0s;
            width: 100%;
            z-index: 9
        }

    .product-item:hover .pr-img-area a::before {
        opacity: .1
    }

    .product-item .item-inner img.hover-img {
        left: 0;
        opacity: 0;
        position: absolute;
        top: 0;
        transition: all 0.9s ease 0s;
    }");
            WriteLiteral(@"

    .product-item .item-inner:hover img.hover-img {
        opacity: 1;
    }

    .pr-img-area {
        overflow: hidden;
        position: relative
    }

    .add-to-cart-mt {
        background: #31ad85;
        border: 0 none;
        bottom: 0;
        font-size: 12px;
        left: -100%;
        line-height: 10px;
        position: absolute;
        text-align: center;
        text-transform: uppercase;
        transition: all .5s ease-out 0s;
        width: 100%;
        padding: 12px 0;
        color: #fff;
    }

        .add-to-cart-mt:hover {
            background: #31ad85;
            color: #fff;
        }

        .add-to-cart-mt span {
            margin-left: 5px
        }

    .product-item .item-inner:hover .product-thumbnail .add-to-cart-mt {
        left: 0
    }

    .product-item .item-inner:hover .product-thumbnail .pr-button {
        background: #F2F2F2
    }

    .pr-button .mt-button {
        width: 33.3%;
        float: left;
   ");
            WriteLiteral(@"     text-align: center;
        border-right: 1px solid
    }

    .pr-button {
        border-top: 1px solid #e5e5e5;
        overflow: hidden;
        transition: all .5s ease-out 0s
    }

        .pr-info-area .product-name a:hover, .pr-button .mt-button a:hover {
            color: #F47E1E
        }

        .pr-button .mt-button {
            border-right: 1px solid #e5e5e5;
            float: left;
            text-align: center;
            width: 33.3%
        }

            .pr-button .mt-button a {
                color: #fff;
                display: block;
                font-size: 16px;
                padding: 10px 3px 8px;
                font-weight: normal;
                background-color: #444;
                border-radius: 2px;
            }

    .pr-info-area .pr-button .s-button a:hover {
        background: #31ad85;
        color: #fff;
    }

    .pr-button .s-button a {
        color: #fff
    }

    .pr-img-area img {
        width: 100%
");
            WriteLiteral(@"    }

    .product-item .pr-button {
        border: 0 none;
        position: absolute;
        top: 3%;
        opacity: 0;
        z-index: 12;
        padding-left: 4%;
    }

    .product-item .item-inner:hover .product-thumbnail .pr-button {
        background: none;
        opacity: 1;
    }

    .pr-button .mt-button a:hover {
        background: #31ad85;
        color: #fff;
        border: 0px #31ad85 solid;
    }

    .pr-button .mt-button {
        border-right: 0 none;
        float: none;
        margin-bottom: 8px;
        text-align: center;
        transform: scale(0);
        transition: all 0.4s ease 0s;
        width: 40px;
        line-height: 20px
    }

    .product-item .item-inner:hover .product-thumbnail .mt-button, .on-sale-product .item-inner:hover .product-thumbnail .mt-button {
        transform: scale(1)
    }

    .product-item .item-inner .item-info {
        text-align: center;
        padding-top: 12px;
    }

        .product-item ");
            WriteLiteral(@".item-inner .item-info .item-title {
            font-size: 14px;
            margin-bottom: 6px;
            font-weight: 400;
        }

            .product-item .item-inner .item-info .item-title a {
                display: inherit;
                overflow: hidden;
                text-overflow: ellipsis;
                white-space: nowrap;
                padding: 0 10px;
                font-size: 15px;
                font-weight: 500;
            }

    .product-item .item-inner {
        position: relative;
        overflow: hidden;
        padding-bottom: 15px;
    }

        .product-item .item-inner:hover {
            box-shadow: 0 0 2px #dedede;
        }

    .product-item {
        margin: 0 12px
    }

    .products-grid .item .product-item {
        margin: 0px
    }

    .owl-carousel .owl-wrapper-outer {
        padding: 5px 0px;
    }

    .product-item .item-inner .item-info .item-title a:hover {
        color: #31ad85;
    }

    .product-ite");
            WriteLiteral(@"m .item-inner .item-info .pro-action {
        position: absolute;
        bottom: -50px;
        width: 100%;
        -moz-transition: all 300ms ease-out;
        -o-transition: all 300ms ease-out;
        -webkit-transition: all 300ms ease-out;
        transition: all 300ms ease-out;
        -ms-transition: all 300ms ease-out;
    }

    .product-item:hover .item-inner .item-info .pro-action {
        position: absolute;
        bottom: 0px;
        width: 100%;
    }

    .product-item .item-inner .item-info .add-to-cart {
        padding: 9px 12px;
        font-size: 12px;
        width: 100%;
    }

        .product-item .item-inner .item-info .add-to-cart i {
            font-size: 16px;
            vertical-align: -1px;
        }

    .product-item .item-inner:hover .item-info .add-to-cart {
        color: #fff;
        background-color: #31ad85;
        border: 1px #31ad85 solid;
        width: 100%;
        transition: 0.5s all ease;
    }

    .product-item .item-");
            WriteLiteral(@"inner .item-info .add-to-cart:hover {
        background-color: #444;
        border: 1px #444 solid;
        transition: 0.5s all ease;
    }

    .product-item .item-inner .item-info .add-to-cart span {
        margin-left: 5px;
    }

    #best-sale-slider.product-flexslider {
        margin: 20px -12px
    }

    .best-sale-pro .slider-items-products .owl-buttons .owl-prev {
        top: 15%
    }

    .best-sale-pro .slider-items-products .owl-buttons .owl-next {
        top: 15%
    }

    .icon-new-label {
        font-size: 10px;
        color: #333;
        text-align: center;
        display: block;
        position: absolute;
        z-index: 1;
        font-weight: normal;
        letter-spacing: 0.5px;
        line-height: normal;
        margin-top: 0px;
        margin-left: 0px;
        background: #fff764;
        line-height: 10px;
        border-radius: 2px;
    }

    .new-right {
        right: 6px;
        top: 6px;
        padding: 4px 8px;
    ");
            WriteLiteral(@"}

    .new-left {
        left: 6px;
        top: 6px;
        padding: 4px 8px;
    }

    .icon-sale-label {
        font-size: 10px;
        color: #fff;
        text-align: center;
        display: block;
        position: absolute;
        z-index: 1;
        font-weight: normal;
        line-height: normal;
        margin-top: 0px;
        margin-left: 0px;
        background: #e53939;
        line-height: 10px;
        border-radius: 2px;
    }

    .sale-right {
        right: 6px;
        top: 6px;
        padding: 4px 8px;
    }

    .sale-left {
        left: 6px;
        top: 6px;
        padding: 4px 8px;
    }

    .icon-hot-label {
        font-size: 10px;
        color: #fff;
        text-align: center;
        display: block;
        position: absolute;
        z-index: 1;
        font-weight: normal;
        letter-spacing: 0.5px;
        line-height: normal;
        margin-top: 0px;
        margin-left: 0px;
        background: #f81c31;
    ");
            WriteLiteral(@"    border: 1px solid #ec1226;
        line-height: 10px;
        border-radius: 3px;
        padding: 3px 8px 5px 8px;
    }

    .hot-right {
        top: 4px;
        right: 6px;
    }

    .hot-left {
        left: 4px;
        top: 6px;
    }

    .toolbar {
        margin: 10px 0px 0px;
        overflow: hidden;
        border-top: 1px #e8e8e8 solid
    }

        .toolbar .sorter {
            margin-top: 10px
        }

    .sorter .short-by {
        float: right;
        margin: 0;
        padding-left: 12px
    }

    .toolbar.column .sorter .short-by.page {
        float: left;
        margin: 0;
        padding-left: 0;
        margin-bottom: 10px;
    }

    .toolbar label {
        color: #777;
        font-size: 14px;
        font-weight: 300;
        line-height: 30px;
        text-transform: capitalize;
        margin-bottom: 0px;
    }

    .sorter .short-by select {
        border: 0 none;
        display: inline-block;
        font-size: ");
            WriteLiteral(@"14px;
        height: 30px;
        margin: 0;
        padding: 0 14px;
        vertical-align: middle;
        width: 110px;
        border: 1px #e8e8e8 solid;
        -webkit-appearance: none;
        -moz-appearance: none;
        appearance: none;
        background-position: right center;
        background-image: url(../images/arrow-d.png);
        background-repeat: no-repeat;
        position: right 10px center;
        padding-right: 28px;
        text-indent: 0.01px;
        text-overflow: '';
        cursor: pointer;
        border-radius: 3px;
    }

    .sorter .short-by.page select {
        width: 65px
    }

    .view-mode {
        float: left;
    }

        .view-mode ul {
            padding: 0px;
            margin: 0
        }

            .view-mode ul li {
                float: left;
                padding: 4px 10px 4px 0;
                list-style: none
            }

                .view-mode ul li a {
                    color: #959595;
");
            WriteLiteral(@"                    font-size: 18px;
                    line-height: 35px;
                    font-weight: normal;
                    padding-right: 5px
                }

                .view-mode ul li:last-child {
                    border: none;
                    margin-left: 5px;
                    padding-right: 0px
                }

        .view-mode li.active a {
            color: #31ad85;
        }

    .shop .product-des .color ul li {
        border: 0 none;
        display: inline-block;
        float: none;
        margin-right: 5px;
        margin-top: 10px
    }

    .shop .product-des h2 {
        line-height: 18px;
        margin: 0 0 5px
    }

    .pagination-area {
        background: rgba(0,0,0,0) none repeat scroll 0 0;
        border-top: 1px solid #e5e5e5;
        margin: 22px 0 0;
        padding-top: 20px;
        text-align: center;
        display: inline-block;
        width: 100%
    }

        .pagination-area ul {
            m");
            WriteLiteral(@"argin-bottom: 0px
        }

            .pagination-area ul li {
                background: #f5f5f5;
                color: #393939;
                display: inline-block;
                font-size: 12px;
                font-weight: 700;
                height: 30px;
                line-height: 30px;
                margin: 0 0 0 5px;
                width: 30px;
            }

                .pagination-area ul li a {
                    border: 1px solid #e5e5e5;
                    color: #363636;
                    display: block;
                    font-size: 12px;
                    font-weight: 700;
                    height: 30px;
                    width: 30px;
                    text-decoration: none;
                    transition: all .4s ease-out .2s;
                    border-radius: 3px;
                }

                    .pagination-area ul li a:hover {
                        background: #31ad85;
                        border: 1px solid #31ad85;");
            WriteLiteral(@"
                        color: #fff;
                    }

                    .pagination-area ul li a.active {
                        background: #31ad85;
                        border: 1px solid #31ad85;
                        color: #fff;
                        transition: all .4s ease-out .2s;
                    }

    .price {
        font-size: 14px;
        color: #000;
        white-space: nowrap !important;
    }

    .price-box {
        margin: 6px 0 2px;
        min-height: 22px;
    }

    .regular-price {
        display: inline
    }

        .regular-price .price {
            font-weight: 600;
            font-size: 14px;
            color: #31ad85;
        }

    .block .regular-price, .block .regular-price .price {
        color: #333333
    }

    .price-box .price-from .price {
        font-weight: 600;
        font-size: 14px;
        color: #31ad85;
    }

    .price-box .price-to .price {
        font-weight: 600;
        font-size: 14");
            WriteLiteral(@"px;
        color: #31ad85;
    }

    .price-box .minimal-price .price {
        font-weight: 600;
        font-size: 14px;
        color: #31ad85;
    }

    .old-price .price-label {
        white-space: nowrap;
        color: #999;
        display: none
    }

    .old-price {
        display: inline;
        margin-right: 15px
    }

        .old-price .price-label {
            color: #ccc;
            display: none;
            white-space: nowrap
        }

        .old-price .price {
            color: #ccc !important;
            font-size: 12px;
            font-weight: normal;
            text-decoration: line-through;
            margin-left: 6px
        }

    .special-price {
        margin: 0;
        padding: 3px 0;
        display: inline
    }

        .special-price .price-label {
            color: #666;
            display: none;
            font-size: 12px;
            font-weight: 400;
            white-space: nowrap
        }

        .");
            WriteLiteral(@"special-price .price {
            font-size: 14px;
            color: #31ad85;
            font-weight: 600
        }

        .special-price .price-label {
            font-size: 12px;
            font-weight: 600;
            white-space: nowrap;
            color: #666;
            display: none
        }

    .minimal-price {
        margin: 0
    }

        .minimal-price .price-label {
            white-space: nowrap
        }

    .minimal-price-link {
        display: inline
    }
</style>

<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
                    <li>Khuyến mãi</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->
");
            WriteLiteral("\n<div class=\"main-container col1-layout\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-main col-sm-12 col-xs-12\">\r\n                <div class=\"shop-inner\">\r\n");
#nullable restore
#line 705 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
                     foreach (var coupon in Model.Items)
                    {
                        if (coupon.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""product-grid-area"">
                                <ul class=""products-grid"">
                                    <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                        <div class=""product-item"">
                                            <div class=""item-inner"">
                                                <div class=""product-thumbnail"">
                                                    <div class=""pr-img-area"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a787811b76f24987f38898910d0041c4cd61ae8e25386", async() => {
                WriteLiteral("\r\n                                                            <figure>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a787811b76f24987f38898910d0041c4cd61ae8e25710", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</figure>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 716 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
AddHtmlAttributeValue("", 17591, coupon.Describe, 17591, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-couponId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 716 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
                                                                                                                                        WriteLiteral(coupon.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["couponId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-couponId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["couponId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </div>
                                                </div>
                                                <div class=""item-info"">
                                                    <div class=""info-inner"">
                                                        <div class=""item-title"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a787811b76f24987f38898910d0041c4cd61ae8e30199", async() => {
                WriteLiteral("\r\n                                                                ");
#nullable restore
#line 725 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
                                                           Write(Html.Raw(coupon.Describe));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 724 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
AddHtmlAttributeValue("", 18316, coupon.Describe, 18316, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-couponId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 724 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
                                                                                                                                            WriteLiteral(coupon.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["couponId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-couponId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["couponId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                        <span style=""background-color:#FE316C;"" class=""badge badge-pill badge-success"">Khuyến mãi</span>
                                                        <div class=""item-content"">
                                                            <div class=""item-price"">
                                                                <div class=""price-box""> <span class=""regular-price""> Còn lại: <span style=""color:#EF7E16;font-weight:bold"">");
#nullable restore
#line 731 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
                                                                                                                                                                      Write(coupon.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" lần</span>   </span> </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </div>
");
#nullable restore
#line 741 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pagination-area \">\r\n                        ");
#nullable restore
#line 745 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Coupon\Index.cshtml"
                   Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Main Container End --> ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
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
