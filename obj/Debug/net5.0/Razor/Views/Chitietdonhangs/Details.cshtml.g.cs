#pragma checksum "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69f28339c898c748c1f5e2416588d3a69b9038c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chitietdonhangs_Details), @"mvc.1.0.view", @"/Views/Chitietdonhangs/Details.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\_ViewImports.cshtml"
using ShopDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\_ViewImports.cshtml"
using ShopDT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69f28339c898c748c1f5e2416588d3a69b9038c", @"/Views/Chitietdonhangs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1793cbabf68094daa424e580cacf526d7ff8a4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Chitietdonhangs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopPhone.Models.Chitietdonhang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Chitietdonhang</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaDonNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaDonNavigation.MaDon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSanPhamNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaSanPhamNavigation.MaSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\New folder\ShopDT\Views\Chitietdonhangs\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c69f28339c898c748c1f5e2416588d3a69b9038c6703", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopPhone.Models.Chitietdonhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
