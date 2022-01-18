#pragma checksum "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b3d93b830337617b900a1b73275c0506aba19f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SaleInvoices_Details), @"mvc.1.0.view", @"/Views/SaleInvoices/Details.cshtml")]
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
#line 2 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b3d93b830337617b900a1b73275c0506aba19f", @"/Views/SaleInvoices/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adff293ceda9f57871ba140a814a8fb4acebbce8", @"/Views/_ViewImports.cshtml")]
    public class Views_SaleInvoices_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceGenerator.Models.SaleInvoice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
  
    ViewData["Title"] = "Sale Invoice Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var AREA_NAME = Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine.GetNormalizedRouteValue(ViewContext, "area");
    var CONTROLLER_NAME = this.ViewContext.RouteData.Values["controller"].ToString();
    var aboutUs = await _context.AboutUs.FirstOrDefaultAsync();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HEAD", async() => {
                WriteLiteral(@"

    <style>

        td, th {
            font-size: 14px;
            text-align: center;
            vertical-align: middle !important;
        }

        td {
            font-size: 12px;
        }

        tbody tr td:first-child {
            margin: auto;
            min-height: 56px;
        }

        thead > tr {
            height: 35px;
        }

        .qty {
            min-width: 115px;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n<main id=\"main\">\r\n<!-- Breadcrumb -->\r\n\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb rounded-0 bg-transparent\">\r\n        <li class=\"breadcrumb-item\">\r\n            <a>");
#nullable restore
#line 48 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
          Write(Localizer[@CONTROLLER_NAME]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 50 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                          Write(Localizer[@CONTROLLER_NAME]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ol>\r\n</nav>\r\n\r\n\r\n<div class=\"content-box bg-white\">\r\n<div>\r\n\r\n</div>\r\n<div class=\"title-bar d-flex justify-content-between\">\r\n    <div class=\"col-4 d-flex justify-content-start align-items-center mx-0 px-0\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1546, "\"", 1589, 1);
#nullable restore
#line 61 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
WriteAttributeValue("", 1553, Url.Action("Index", "SaleInvoices"), 1553, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" class=""svg-arrows"" width=""47"" viewBox=""0 0 47 47"">
                <defs>
                    <filter id=""Ellipse_23"" x=""0"" y=""0"" width=""47"" height=""47"" filterUnits=""userSpaceOnUse"">
                        <feOffset dy=""3"" input=""SourceAlpha""/>
                        <feGaussianBlur stdDeviation=""3"" result=""blur""/>
                        <feFlood flood-opacity=""0.161""/>
                        <feComposite operator=""in"" in2=""blur""/>
                        <feComposite in=""SourceGraphic""/>
                    </filter>
                </defs>
                <g id=""Group_455"" data-name=""Group 455"" transform=""translate(9 35.418) rotate(-90)"">
                    <g transform=""matrix(0, 1, -1, 0, 35.42, -9)"" filter=""url(#Ellipse_23)"">
                        <g id=""Ellipse_23-2"" data-name=""Ellipse 23"" transform=""translate(9 35) rotate(-90)"" stroke-width=""2"">
                            <circle cx=""1");
            WriteLiteral(@"4.5"" cy=""14.5"" r=""14.5"" stroke=""none""/>
                            <circle cx=""14.5"" cy=""14.5"" r=""13.5"" fill=""none""/>
                        </g>
                    </g>
                    <g id=""Group_124"" data-name=""Group 124"" transform=""translate(20.829 17.97) rotate(180)"">
                        <path id=""Path_22"" data-name=""Path 22"" d=""M0,6.349,6.419,0,12.5,6.349"" transform=""translate(12.5 6.349) rotate(180)"" stroke-width=""2""/>
                    </g>
                </g>
            </svg>

        </a>
        <h3 class=""text-main mx-3"">
            ");
#nullable restore
#line 87 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["Invoice Detail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n\r\n\r\n    <div class=\"d-flex justify-content-end\">\r\n        <a class=\"btn bg-main d-block text-light btn-outline-dark mx-1 btn-width\"");
            BeginWriteAttribute("href", " href=\"", 3383, "\"", 3411, 1);
#nullable restore
#line 93 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
WriteAttributeValue("", 3390, Url.Action("Create"), 3390, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 93 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                                                           Write(Localizer["Go to Sales Invoice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a class=\"btn bg-main d-block text-light btn-outline-dark mx-1 btn-width\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 3550, "\"", 3622, 1);
#nullable restore
#line 94 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
WriteAttributeValue("", 3557, Url.Action("PrintThermalInvoice", new { ID = Model?.InvoiceID }), 3557, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 94 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                                                                                                                       Write(Localizer["Print Thermal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a class=\"btn bg-main d-block text-light btn-outline-dark mx-1 btn-width\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 3755, "\"", 3820, 1);
#nullable restore
#line 95 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
WriteAttributeValue("", 3762, Url.Action("PrintInvoice", new { ID = Model?.InvoiceID }), 3762, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 95 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                                                                                                                Write(Localizer["Print"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row d-flex justify-content-between px-5\">\r\n    <div class=\"col-7 d-flex justify-content-end\">\r\n        <p class=\"text-center font-weight-bold text-main font-5 mb-0\" style=\" margin-right: 57px;\">");
#nullable restore
#line 102 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                                              Write(Localizer["Invoice ID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 102 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                                                                        Write(Model.InvoiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"card pt-0\">\r\n<div class=\"card-body\" id=\"Main\">\r\n<div class=\"text-left\">\r\n    ");
#nullable restore
#line 110 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 110 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                   Write(Model.IssuedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; &nbsp;&nbsp; &nbsp;\r\n    ");
#nullable restore
#line 111 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
Write(Localizer["Created By"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 111 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                        Write(Model.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""row"">
    <div class=""col-10"">
        <div class=""border table d-flex justify-content-end "" style=""width:100%"">
            <table class=""w-60 table"">
                <thead>
                <tr class=""bg-submain text-light"">
                    <th colspan=""4"" class=""text-left"" style=""width:80%"">
                        <div class=""row d-flex justify-content-between"">
                            <div class=""col-6"">
                                <p class=""my-font"" style="" margin: 0 0 0 45px;"">");
#nullable restore
#line 125 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                           Write(Localizer["Seller Identification"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                            </div>
                        </div>
                    </th>
                </tr>
                </thead>
                <tbody>
                <tr>
                    <td>
                        <div class=""d-flex justify-content-between px-5"">
                            <div class=""col-4 text-left"">
                                <b>");
#nullable restore
#line 136 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                              Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"col-8 text-right\">\r\n                            \r\n                                ");
#nullable restore
#line 140 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                           Write(aboutUs?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                        </div>
                    </td>

                </tr>
                <tr>
                    <td>
                        <div class=""row d-flex justify-content-between px-5"">


                            <div class=""col-4 text-left"">
                                <b>");
#nullable restore
#line 153 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                              Write(Localizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"col-8 text-right\">\r\n                          \r\n                                ");
#nullable restore
#line 157 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                            Write(aboutUs?.City + aboutUs?.District + aboutUs?.City );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </td>

                </tr>
                <tr>
                    <td>
                        <div class=""row d-flex justify-content-between px-5"">


                            <div class=""col-6 text-left"">
                                <b>");
#nullable restore
#line 169 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                              Write(Localizer["VAT Number"].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"col-6 text-right\">\r\n                               \r\n                                ");
#nullable restore
#line 173 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                           Write(aboutUs?.VATNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                        </div>
                    </td>

                </tr>
                <tr>
                    <td>
                        <div class=""row d-flex justify-content-between px-5"">


                            <div class=""col-7 text-left"">
                                <b>");
#nullable restore
#line 186 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                              Write(Localizer["Group Vat Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"col-5 text-right\">\r\n                           \r\n                                ");
#nullable restore
#line 190 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                           Write(aboutUs?.GroupVatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                        </div>
                    </td>

                </tr>
                </tbody>
            </table>
            <table class=""w-60 table"">
                <thead>
                <tr class=""bg-submain text-light"">
                    <th colspan=""4"" class=""text-left"" style=""width:80%"">
                        <div class=""d-flex justify-content-between px-5"">
                            <div class=""col-6"">
                                <p class=""my-font"" style="" margin: 0 0 0 5px;"">");
#nullable restore
#line 205 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                          Write(Localizer["Buyer Identification"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                    </th>

                </tr>
                </thead>
                <tbody>
                <tr>
                    <td>
                        <div class=""row d-flex justify-content-between px-5"">
                            <div class=""col-4 text-left"">
                                <b>");
#nullable restore
#line 217 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                              Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"col-8 text-right\">\r\n                                ");
#nullable restore
#line 220 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                           Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""row d-flex justify-content-between px-5"">
                            <div class=""col-5 text-left"">
                                <b>");
#nullable restore
#line 230 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                              Write(Localizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"col-7 text-right\">\r\n                                ");
#nullable restore
#line 233 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                           Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
    <div class=""col-2 table d-flex justify-content-end"" style=""border-top: 1px solid #dee2e6 !important; border-right: 1px solid #dee2e6 !important; border-bottom: 1px solid #dee2e6 !important; border-left: 1px solid #dee2e6 !important; "">
");
#nullable restore
#line 268 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
         if (Model.QrCode != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img style=\" width: 80%; height: auto; margin: auto;\"");
            BeginWriteAttribute("src", " src=\"", 10541, "\"", 10560, 1);
#nullable restore
#line 270 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
WriteAttributeValue("", 10547, Model.QrCode, 10547, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10561, "\"", 10567, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 271 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<br/>\r\n<br/>\r\n<table class=\"w-100 table\">\r\n    <thead>\r\n\r\n    <tr class=\"bg-submain text-light\">\r\n        <th>");
#nullable restore
#line 281 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["S.No"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 282 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["ID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 283 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["Item"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 284 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["Unit Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 285 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 286 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["VAT %"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("        <th>");
#nullable restore
#line 288 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["VAT Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("        <th>");
#nullable restore
#line 290 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["Total Amount (VAT Incl.)"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 291 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
       Write(Localizer["Total Amount (VAT Excl.)"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 295 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 296 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
     foreach(var item in Model.SaleInvoiceDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 299 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
            Write(++i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 300 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.ItemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 301 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.Item?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 302 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 303 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 304 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.VATPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 306 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.VATAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 308 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.SubTotalVATInclusive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 309 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(item.SubTotalVATExclusive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 311 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"d-flex justify-content-between my-3\">\r\n    <div>\r\n        <h4 class=\"mb-3\">");
#nullable restore
#line 316 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                    Write(Localizer["Payment Information"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <div class=\"py-1 px-3\">\r\n             <div class=\"btn-group d-flex w-100 \"> \r\n                 <b>");
#nullable restore
#line 319 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
               Write(Localizer["Payment Method"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b>&nbsp; ");
#nullable restore
#line 319 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                        Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n             </div> \r\n        </div>\r\n    </div>\r\n\r\n    <div id=\"totalAmountSection\" style=\"min-width:300px\">\r\n        <div class=\"d-flex justify-content-between p-2\">\r\n            <p>");
#nullable restore
#line 326 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
          Write(Localizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>");
#nullable restore
#line 327 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
          Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"d-flex justify-content-between p-2\">\r\n            <p>\r\n                <span>");
#nullable restore
#line 331 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                 Write(Localizer["Discount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <b class=\"font-1\">(");
#nullable restore
#line 331 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                                  Write(Model.DiscountPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %)</b>\r\n            </p>\r\n            <p> ");
#nullable restore
#line 333 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(Model.DiscountAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n");
            WriteLiteral("        <div class=\"d-flex justify-content-between p-2\">\r\n            <p>\r\n                ");
#nullable restore
#line 342 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(Localizer["VAT"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b class=\"font-1\">(");
#nullable restore
#line 342 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                                                Write(Model.VATPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%)</b>\r\n            </p>\r\n            <p> ");
#nullable restore
#line 344 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
           Write(Model.TotalVAT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"d-flex justify-content-between bg-main text-light br-main p-2\">\r\n            <p>");
#nullable restore
#line 347 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
          Write(Localizer["Grand Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 348 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
          Write(Localizer["SAR"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 348 "C:\Users\kashi\source\repos\POS\InvoiceGenerator\Views\SaleInvoices\Details.cshtml"
                            Write(Model.GrossTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n</main>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public InvoiceGenerator.Data.ApplicationDbContext _context { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceGenerator.Models.SaleInvoice> Html { get; private set; }
    }
}
#pragma warning restore 1591