#pragma checksum "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f42ba47c35814c3edd1aa65e4f703bdfe359c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PrintTemplateLayout), @"mvc.1.0.view", @"/Views/Shared/_PrintTemplateLayout.cshtml")]
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
#line 1 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\_ViewImports.cshtml"
using InvoiceGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\_ViewImports.cshtml"
using InvoiceGenerator.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f42ba47c35814c3edd1aa65e4f703bdfe359c9", @"/Views/Shared/_PrintTemplateLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adff293ceda9f57871ba140a814a8fb4acebbce8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PrintTemplateLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/assets/logo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("85px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
  
    var aboutUs = await context.AboutUs.FirstOrDefaultAsync();


    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f42ba47c35814c3edd1aa65e4f703bdfe359c95413", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta content=""IE=edge"" http-equiv=""X-UA-Compatible"">
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600;700&display=swap"" rel=""stylesheet"">
    <title>");
#nullable restore
#line 47 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    ");
#nullable restore
#line 49 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
Write(RenderSection("Style", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f42ba47c35814c3edd1aa65e4f703bdfe359c97354", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"print-wrapper\">\r\n        <div class=\"header\">\r\n            <div class=\"header-details\">\r\n                <h1>");
#nullable restore
#line 57 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
               Write(aboutUs?.BusinessName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span style=\"font-size: 12px\">Trading Est.</span></h1>\r\n                <p style=\"margin-bottom: 10px\">");
#nullable restore
#line 58 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                          Write(aboutUs?.BussinessTagLine);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p> CR: &nbsp; <span>");
#nullable restore
#line 59 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                Write(aboutUs?.Cr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n                <p>\r\n                    ");
#nullable restore
#line 61 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
               Write(aboutUs?.StreetName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 61 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                      Write(aboutUs?.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 61 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                       Write(aboutUs?.District);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    Tel: &nbsp; <span>");
#nullable restore
#line 64 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                 Write(aboutUs?.Tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </p>\r\n                <p> Mob: &nbsp;<span>");
#nullable restore
#line 66 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                Write(aboutUs?.Mob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n            </div>\r\n            <!-- ");
                WriteLiteral(" -->\r\n            <div>\r\n");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8f42ba47c35814c3edd1aa65e4f703bdfe359c910422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 71 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\" header-details header-details-ar\" dir=\"rtl\">\r\n                <h1>\r\n                    ");
#nullable restore
#line 75 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
               Write(aboutUs?.BusinessNameArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span style=\"font-size: 12px\">.?????????? ??????????????</span>\r\n                </h1>\r\n                <p>\r\n                    ");
#nullable restore
#line 79 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
               Write(aboutUs.BussinessTagLineArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ?????? ?????????? :&nbsp; <span>\r\n                        ");
#nullable restore
#line 83 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                   Write(ConvertNumeralsToArabic(aboutUs?.Cr));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </span>\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 87 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
               Write(aboutUs?.DistrictArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 87 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                          Write(aboutUs?.CityArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 87 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                 Write(aboutUs?.StreetNameArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    :????????\r\n                    &nbsp; <span>");
#nullable restore
#line 91 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                            Write(ConvertNumeralsToArabic(aboutUs?.Tel));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </p>\r\n                <p>\r\n                    ??????????????:\r\n                    &nbsp;<span>");
#nullable restore
#line 95 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                           Write(ConvertNumeralsToArabic(aboutUs?.Mob));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("\r\n        ");
#nullable restore
#line 101 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        <!-- ");
                WriteLiteral(" -->\r\n\r\n        <div class=\"footer\">\r\n            <div style=\"font-weight: 600;\">\r\n                ");
#nullable restore
#line 108 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
           Write(aboutUs?.District);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |  ");
#nullable restore
#line 108 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                 Write(aboutUs?.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |  ");
#nullable restore
#line 108 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                   Write(aboutUs?.StreetName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Mob#  ");
#nullable restore
#line 108 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                                Write(aboutUs?.Mob);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Tel #  ");
#nullable restore
#line 108 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                                                       Write(aboutUs?.Tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                | Email:  ");
#nullable restore
#line 109 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                     Write(aboutUs?.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div dir=\"rtl\" style=\"margin-top: 10px\">\r\n\r\n                ???????????? ????????????????????  ");
#nullable restore
#line 114 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                              Write(aboutUs?.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ?????? ????????  ");
#nullable restore
#line 114 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                          Write(ConvertNumeralsToArabic(aboutUs?.Tel));

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ?????? ???????????? ??????????????  ");
#nullable restore
#line 114 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                                                                       Write(ConvertNumeralsToArabic(aboutUs?.Mob));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |  ");
#nullable restore
#line 114 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                                                                                                                 Write(aboutUs?.StreetNameArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 114 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                                                                                                                                              Write(aboutUs?.CityArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |  ");
#nullable restore
#line 114 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
                                                                                                                                                                                                                      Write(aboutUs?.DistrictArabic);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
#nullable restore
#line 7 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\Shared\_PrintTemplateLayout.cshtml"
               
        string ConvertNumeralsToArabic(string input)

        {

            return input?.Replace('0', '??')

                        ?.Replace('1', '??')

                        ?.Replace('2', '??')

                        ?.Replace('3', '??')

                        ?.Replace('4', '??')

                        ?.Replace('5', '??')

                        ?.Replace('6', '??')

                        ?.Replace('7', '??')

                        ?.Replace('8', '??')

                        ?.Replace('9', '??');

        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public InvoiceGenerator.Data.ApplicationDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public InvoiceGenerator.Resources.ViewLocalizer Localizer { get; private set; }
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
