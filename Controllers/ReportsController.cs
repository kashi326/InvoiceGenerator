using InvoiceGenerator.Data;
using InvoiceGenerator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Controllers
{
    [Authorize]
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ReportsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> SaleInvoices(InvoicesReportInputModel input)
        {
            if (ModelState.IsValid)
            {
                if(!string.IsNullOrEmpty(input.DateRange) || !string.IsNullOrEmpty(input.Name) || !string.IsNullOrEmpty(input.CreatedBy))
                {
                    var saleInvoices = context.SaleInvoice.AsNoTracking();

                    if (!string.IsNullOrEmpty(input.DateRange))
                    {
                        var dates = input.DateRange?.Split('-');
                        if(dates.Length == 2)
                        {
                            if(DateTime.TryParse(dates[0],out var fromDate ) && DateTime.TryParse(dates[1],out var toDate))
                            {
                                saleInvoices = saleInvoices.Where(x => x.IssuedDate.Date >= fromDate.Date && x.IssuedDate.Date <= toDate.Date);
                            }

                        }                    
                    }
                    if (!string.IsNullOrWhiteSpace(input.Name))
                    {
                        saleInvoices = saleInvoices.Where(x => x.CustomerName.StartsWith(input.Name));
                    }


                    if (!string.IsNullOrWhiteSpace(input.CreatedBy))
                    {
                        saleInvoices = saleInvoices.Where(x => x.CreatedBy.StartsWith(input.CreatedBy));
                    }


                    var data = await saleInvoices.ToListAsync();
                    if(input.Print.HasValue && input.Print.Value)
                    {
                        return View("SaleInvoicesPrint", data);
                    }
                    return View(data);
                }
                
            }
            if(input.Print.HasValue && input.Print.Value)
            {
                return View("SaleInvoicesPrint", Enumerable.Empty<SaleInvoice>());
            }
            return View(Enumerable.Empty<SaleInvoice>());
        } 

        public async Task<IActionResult> PurchaseInvoices(InvoicesReportInputModel input)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(input.DateRange) || !string.IsNullOrEmpty(input.Name) || !string.IsNullOrEmpty(input.CreatedBy))
                {
                    var purchaseInvoices = context.PurchaseInvoice.AsNoTracking();

                    if (!string.IsNullOrEmpty(input.DateRange))
                    {
                        var dates = input.DateRange?.Split('-');
                        if (dates.Length == 2)
                        {
                            if (DateTime.TryParse(dates[0], out var fromDate) && DateTime.TryParse(dates[1], out var toDate))
                            {
                                purchaseInvoices = purchaseInvoices.Where(x => x.IssuedDate.Date >= fromDate.Date && x.IssuedDate.Date <= toDate.Date);
                            }

                        }
                    }
                    if (!string.IsNullOrWhiteSpace(input.Name))
                    {
                        purchaseInvoices = purchaseInvoices.Where(x => x.SupplierName.StartsWith(input.Name));
                    }


                    if (!string.IsNullOrWhiteSpace(input.CreatedBy))
                    {
                        purchaseInvoices = purchaseInvoices.Where(x => x.CreatedBy.StartsWith(input.CreatedBy));
                    }


                    var data = await purchaseInvoices.ToListAsync();
                    if (input.Print.HasValue && input.Print.Value)
                    {
                        return View("PurchaseInvoicesPrint", data);
                    }
                    return View(data);
                }

            }
            if (input.Print.HasValue && input.Print.Value)
            {
                return View("PurchaseInvoicesPrint", Enumerable.Empty<PurchaseInvoice>());
            }
            return View(Enumerable.Empty<PurchaseInvoice>());

        }
    }
}
