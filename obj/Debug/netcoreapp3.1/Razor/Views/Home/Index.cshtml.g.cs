#pragma checksum "D:\Work\Portfolio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ac0b5a6616f7307136eec8a5e66faf61738753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Work\Portfolio\Views\_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Portfolio\Views\_ViewImports.cshtml"
using Portfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ac0b5a6616f7307136eec8a5e66faf61738753", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb73a38814952a5c8b0aac59634c59cf69ecf13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Work\Portfolio\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Ghalamdoost";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Profile -->\r\n");
#nullable restore
#line 5 "D:\Work\Portfolio\Views\Home\Index.cshtml"
Write(Html.Partial("~/Views/Partial/_Profile.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /Profile -->\r\n<!-- Menu -->\r\n");
#nullable restore
#line 8 "D:\Work\Portfolio\Views\Home\Index.cshtml"
Write(Html.Partial("~/Views/Partial/_Menu.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!-- /Menu -->\r\n<!-- Resume -->\r\n");
#nullable restore
#line 12 "D:\Work\Portfolio\Views\Home\Index.cshtml"
Write(Html.Partial("~/Views/Partial/_Resume.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!-- /Resume -->\r\n<!-- Contact -->\r\n");
#nullable restore
#line 16 "D:\Work\Portfolio\Views\Home\Index.cshtml"
Write(Html.Partial("~/Views/Partial/_Contact.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!-- /Contact -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
