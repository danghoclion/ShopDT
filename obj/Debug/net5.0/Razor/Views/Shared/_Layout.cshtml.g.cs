#pragma checksum "C:\Users\DangHoc\Desktop\ShopDT\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0868bad388025452f98f75b9f00ce74c70939c1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\DangHoc\Desktop\ShopDT\Views\_ViewImports.cshtml"
using ShopDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DangHoc\Desktop\ShopDT\Views\_ViewImports.cshtml"
using ShopDT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0868bad388025452f98f75b9f00ce74c70939c1f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1793cbabf68094daa424e580cacf526d7ff8a4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-layout "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0868bad388025452f98f75b9f00ce74c70939c1f3548", async() => {
                WriteLiteral(@"
    <!-- basic -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- mobile metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
    <!-- site metas -->
    <title>pomato</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 401, "\"", 411, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 443, "\"", 453, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 480, "\"", 490, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <!-- bootstrap css -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <!-- style css -->
    <link rel=""stylesheet"" href=""css/style.css"">
    <!-- Responsive-->
    <link rel=""stylesheet"" href=""css/responsive.css"">
    <!-- fevicon -->
    <link rel=""icon"" href=""images/fevicon.png"" type=""image/gif"" />
    <!-- Scrollbar Custom CSS -->
    <link rel=""stylesheet"" href=""css/jquery.mCustomScrollbar.min.css"">
    <!-- Tweaks for older IEs-->
    <link rel=""stylesheet"" href=""https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css"">
    <!-- owl stylesheets -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css"" media=""screen"">
    <!--[if lt IE 9]>
      <script s");
                WriteLiteral("rc=\"https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js\"></script>\r\n      <script src=\"https://oss.maxcdn.com/respond/1.4.2/respond.min.js\"></script><![endif]-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- body -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0868bad388025452f98f75b9f00ce74c70939c1f6718", async() => {
                WriteLiteral(@"
    <!-- loader  -->
    <div class=""loader_bg"">
        <div class=""loader""><img src=""images/loading.gif"" alt=""#"" /></div>
    </div>
    <!-- end loader -->
    <!-- header -->
    <header>
        <!-- header inner -->
        <div class=""header"">

            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-3 col logo_section"">
                        <div class=""full"">
                            <div class=""center-desk"">
                                <div class=""logo"">
                                    <a href=""index.html""><img src=""images/logo.png"" alt=""#""></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-9 col-lg-9 col-md-9 col-sm-9"">
                        <div class=""menu-area"">
                            <div class=""limit-box"">
                                <nav class");
                WriteLiteral("=\"main-menu\">\r\n                                    <ul class=\"menu-area-main\">\r\n                                        <li class=\"active\"> <a href=\"index.html\">Home</a> </li>\r\n                                        <li> ");
#nullable restore
#line 67 "C:\Users\DangHoc\Desktop\ShopDT\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink("About", "About", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\r\n                                        <li> ");
#nullable restore
#line 68 "C:\Users\DangHoc\Desktop\ShopDT\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink("Brand", "Brand", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\r\n                                        <li> ");
#nullable restore
#line 69 "C:\Users\DangHoc\Desktop\ShopDT\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink("Specials", "Specials", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </li>
                                        <li><a href=""contact.html"">Contact Us</a></li>
                                        <li class=""last"">
                                            <a href=""#""><img src=""images/search_icon.png"" alt=""icon"" /></a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 offset-md-6"">
                        <div class=""location_icon_bottum"">
                            <ul>
                                <li><img src=""icon/call.png"" />(+71)9876543109</li>
                                <li><img src=""icon/email.png"" />demo@gmail.com</li>
                                <li><img src=""icon/loc.png"" />Location</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>");
                WriteLiteral("\r\n        </div>\r\n        <!-- end header inner -->\r\n    </header>\r\n    <!-- end header -->\r\n    <div>\r\n        ");
#nullable restore
#line 95 "C:\Users\DangHoc\Desktop\ShopDT\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <footer>
        <div id=""contact"" class=""footer"">
            <div class=""container"">
                <div class=""row pdn-top-30"">
                    <div class=""col-md-12 "">
                        <div class=""footer-box"">
                            <div class=""headinga"">
                                <h3>Address</h3>
                                <span>Healing Center, 176 W Streetname,New York, NY 10014, US</span>
                                <p>
                                    (+71) 8522369417
                                    <br>demo@gmail.com
                                </p>
                            </div>
                            <ul class=""location_icon"">
                                <li> <a href=""#""><i class=""fa fa-facebook-f""></i></a></li>
                                <li> <a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li> <a href=""#""><i class=""fa fa-instagram""></i></a></li>

                   ");
                WriteLiteral(@"         </ul>
                            <div class=""menu-bottom"">
                                <ul class=""link"">
                                    <li> <a href=""#"">Home</a></li>
                                    <li> <a href=""#"">About</a></li>

                                    <li> <a href=""#"">Brand </a></li>
                                    <li> <a href=""#"">Specials  </a></li>
                                    <li> <a href=""#""> Contact us</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""copyright"">
                <div class=""container"">
                    <p>© 2019 All Rights Reserved. Design By<a href=""https://html.design/""> Free Html Templates</a></p>
                </div>
            </div>
        </div>
    </footer>
    <!-- end footer -->
    <!-- Javascript files-->
    <script src=""js/jquery.min.js""><");
                WriteLiteral(@"/script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.bundle.min.js""></script>
    <script src=""js/jquery-3.0.0.min.js""></script>
    <script src=""js/plugin.js""></script>
    <!-- sidebar -->
    <script src=""js/jquery.mCustomScrollbar.concat.min.js""></script>
    <script src=""js/custom.js""></script>
    <!-- javascript -->
    <script src=""js/owl.carousel.js""></script>
    <script src=""https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js""></script>
    <script>
        $(document).ready(function () {
            $("".fancybox"").fancybox({
                openEffect: ""none"",
                closeEffect: ""none""
            });

            $("".zoom"").hover(function () {

                $(this).addClass('transition');
            }, function () {

                $(this).removeClass('transition');
            });
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
