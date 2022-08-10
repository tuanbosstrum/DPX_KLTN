#pragma checksum "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71b341a8f3c0b8e859ee788957484827dae9292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71b341a8f3c0b8e859ee788957484827dae9292", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
  
    // Đọc query string trong url xem pageIndex là bao nhiêu
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;

    // Lặp qua tất cả các key của query string
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
        {
            // Nếu là pageIndex thì tiếp tục
            continue;
        }

        // nếu không phải page, nghĩa là có chứa các câu query khác thì sẽ cộng các chuỗi vào
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    // Tính vị trí bắt đầu và vị trí kết thúc, dù số trang có > 5 thì cũng chỉ hiển thị 5
    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 39 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li >\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1493, 1);
#nullable restore
#line 45 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1434, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1434, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-angle-left\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 47 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <a class=\"active\" href=\"#\">");
#nullable restore
#line 55 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 57 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("title", " title=\"", 1933, "\"", 1960, 2);
            WriteAttributeValue("", 1941, "Trang", 1941, 5, true);
#nullable restore
#line 60 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1946, i.ToString(), 1947, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1961, "\"", 2009, 1);
#nullable restore
#line 60 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1968, urlTemplate.Replace("{0}", i.ToString()), 1968, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 61 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("title", " title=\"", 2143, "\"", 2178, 1);
#nullable restore
#line 66 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2151, Model.PageCount.ToString(), 2151, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2179, "\"", 2245, 1);
#nullable restore
#line 66 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2186, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 2186, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-angle-right\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 70 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 73 "C:\Users\HUY TUAN\source\repos\electroshop1\ElectroPhoneStore\eShopSolution.WebApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
