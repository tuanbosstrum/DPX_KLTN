#pragma checksum "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a4697db53bb0b6db016c3860e95a21df8229dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 2 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
using eShopSolution.ViewModels.Catalog.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a4697db53bb0b6db016c3860e95a21df8229dd5", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    //Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
  
    //ViewBag.Title = Model.Title;
    var comments = (IEnumerable<ReviewViewModel>)ViewBag.Comments;
    var ratingSum = ViewBag.RatingSum;
    var ratingCount = ViewBag.RatingCount;

    decimal rating = 0;
    if (ratingCount > 0)
    {
        rating = (ratingSum / ratingCount);
    }
    var totalRating = decimal.Parse(rating.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
");
            WriteLiteral("                    <li class=\"active\">");
#nullable restore
#line 35 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                  Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->
<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- Product main img -->
            <div class=""col-md-5 col-md-push-2"">
                <div id=""product-main-img"">
                    <div class=""product-preview"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 1678, "\"", 1744, 1);
#nullable restore
#line 54 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1684, Configuration["BaseAddress"] + Model.Product.ProductImage, 1684, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1745, "\"", 1751, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"product-preview\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1864, "\"", 1930, 1);
#nullable restore
#line 58 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1870, Configuration["BaseAddress"] + Model.Product.ProductImage, 1870, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1931, "\"", 1937, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"product-preview\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2050, "\"", 2116, 1);
#nullable restore
#line 62 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2056, Configuration["BaseAddress"] + Model.Product.ProductImage, 2056, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2117, "\"", 2123, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"product-preview\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2236, "\"", 2302, 1);
#nullable restore
#line 66 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2242, Configuration["BaseAddress"] + Model.Product.ProductImage, 2242, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2303, "\"", 2309, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
            <!-- /Product main img -->
            <!-- Product thumb imgs -->
            <div class=""col-md-2  col-md-pull-5"">
                <div id=""product-imgs"">
                    <div class=""product-preview"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 2637, "\"", 2703, 1);
#nullable restore
#line 75 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2643, Configuration["BaseAddress"] + Model.Product.ProductImage, 2643, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2704, "\"", 2710, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"product-preview\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2823, "\"", 2889, 1);
#nullable restore
#line 79 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2829, Configuration["BaseAddress"] + Model.Product.ProductImage, 2829, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2890, "\"", 2896, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"product-preview\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3009, "\"", 3075, 1);
#nullable restore
#line 83 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3015, Configuration["BaseAddress"] + Model.Product.ProductImage, 3015, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3076, "\"", 3082, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"product-preview\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3195, "\"", 3261, 1);
#nullable restore
#line 87 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3201, Configuration["BaseAddress"] + Model.Product.ProductImage, 3201, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3262, "\"", 3268, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
            <!-- /Product thumb imgs -->
            <!-- Product details -->
            <div class=""col-md-5"">
                <div class=""product-details"">
                    <h2 class=""product-name"">");
#nullable restore
#line 95 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                        Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                    <div>\r\n                        <h3 class=\"product-price\">");
#nullable restore
#line 98 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                             Write(Model.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&#8363;</span> </h3>\r\n");
#nullable restore
#line 99 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                         if (Model.Product.Stock <= 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-available\">Hết hàng</span>\r\n");
#nullable restore
#line 102 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-available\">Còn hàng</span>\r\n");
#nullable restore
#line 106 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n");
#nullable restore
#line 109 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                     if (Model.Product.Stock == 0)
                    {
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"add-to-cart\" style=\"margin-top:10px\">\r\n                            <button class=\"add-to-cart-btn\" data-id=\"");
#nullable restore
#line 115 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                                                Write(Model.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-shopping-cart\"></i> thêm vào giỏ hàng</button>\r\n                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"product-links\">\r\n                        <li>Danh mục:</li>\r\n                        <li>\r\n                            ");
#nullable restore
#line 121 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                       Write(Html.ActionLink(Model.Category.Name, "ViewByCategory", "Home", new { cateId = Model.Category.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </div>
            <!-- /Product details -->
            <!-- Product tab -->
            <div class=""col-md-12"">
                <div id=""product-tab"">
                    <!-- product tab nav -->
                    <ul class=""tab-nav"">
                        <li class=""active""><a data-toggle=""tab"" href=""#tab1"">Thông số kỹ thuật</a></li>
                        <li><a data-toggle=""tab"" href=""#tab2"">Chi tiết sản phẩm</a></li>
                        <li><a data-toggle=""tab"" href=""#tab3"">Đánh giá</a></li>
                    </ul>
                    <!-- /product tab nav -->
                    <!-- product tab content -->
                    <div class=""tab-content"">
                        <!-- tab1  -->
                        <div id=""tab1"" class=""tab-pane fade in active"">
                            <div class=""row"">
                                <div class=""col-md-12"">
");
#nullable restore
#line 143 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                      
                                        string html = @Model.Product.Description;
                                        string removeFirstFigure = html.Remove(0, 22);
                                        string removeLastFigure = removeFirstFigure.Remove(removeFirstFigure.Length - 9);
                                        string addedTableFormat = removeLastFigure.Insert(6, " ");
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 149 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                               Write(Html.Raw(addedTableFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <!-- /tab1  -->
                        <!-- tab2  -->
                        <div id=""tab2"" class=""tab-pane fade in"">
                            <div class=""row"">
                                <style>
                                    #more {
                                        display: none;
                                    }
                                </style>
                                <div class=""col-md-12"">
                                    ");
#nullable restore
#line 165 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <!-- /tab2  -->
                        <!-- tab3  -->
                        <div id=""tab3"" class=""tab-pane fade in"">
                            <div class=""row"">
");
#nullable restore
#line 173 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                 foreach (var c in comments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <hr />\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-md-3\">\r\n                                            <span style=\"font-weight:bold\">");
#nullable restore
#line 178 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                                                      Write(c.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n                                            <i>");
#nullable restore
#line 179 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                          Write(c.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                            <br />\r\n");
#nullable restore
#line 181 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                             for (var i = 1; i <= c.Rating; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"starGlowN\"></span>\r\n");
#nullable restore
#line 184 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                             for (var i = (c.Rating + 1); i <= 5; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"starFadeN\"></span>\r\n");
#nullable restore
#line 188 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <div class=\"col-md-9\">\r\n                                            ");
#nullable restore
#line 191 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                       Write(Html.Raw(c.Comments.Replace("\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 194 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr />\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a4697db53bb0b6db016c3860e95a21df8229dd523806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                        <!-- /tab3  -->
                    </div>
                    <!-- /product tab content  -->
                </div>
            </div>
            <!-- /product tab -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /SECTION -->
");
            WriteLiteral(@"<script>
    function myFunction() {
        var dots = document.getElementById(""dots"");
        var moreText = document.getElementById(""more"");
        var btnText = document.getElementById(""myBtn"");

        if (dots.style.display === ""none"") {
            dots.style.display = ""inline"";
            btnText.innerHTML = ""Read more"";
            moreText.style.display = ""none"";
        } else {
            dots.style.display = ""none"";
            btnText.innerHTML = ""Read less"";
            moreText.style.display = ""inline"";
        }
    }

    function SCRate() {
    for (var i = 1; i <= ");
#nullable restore
#line 230 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                    Write(totalRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("; i++) {\r\n        $(\"#sRate\" + i).attr(\'class\', \'starGlowN\');\r\n    }\r\n    }\r\n    $(function(){\r\n        SCRate();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
