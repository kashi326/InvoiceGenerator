using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvoiceGenerator.Data;
using InvoiceGenerator.Models;
using InvoiceGenerator.Services;
using Microsoft.AspNetCore.Authorization;
using InvoiceGenerator.Extensions;

namespace InvoiceGenerator.Controllers
{
    [Authorize]
    public class SaleInvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IQrCodeGenerator qrCodeGenerator;

        public SaleInvoicesController(ApplicationDbContext context, IQrCodeGenerator qrCodeGenerator)
        {
            _context = context;
            this.qrCodeGenerator = qrCodeGenerator;
        }

        // GET: SaleInvoices
        public async Task<IActionResult> Index()
        {
            return View(await _context.SaleInvoice.Include(x => x.SaleInvoiceDetails).ToListAsync());
        }

        // GET: SaleInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoice
                .Include(x => x.SaleInvoiceDetails)
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (saleInvoice == null)
            {
                return NotFound();
            }

            return View(saleInvoice);
        }

        // GET: SaleInvoices/Create
        public IActionResult Create()
        {
            return View();
        }
        

        // POST: SaleInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SaleInvoice saleInvoice)
        {
            if (ModelState.IsValid)
            {
                await GenerateQRcode(saleInvoice);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }                

                saleInvoice.CreatedBy = HttpContext.GetUserName();
                _context.Add(saleInvoice);
                await _context.SaveChangesAsync();
                return StatusCode(201,new { redirectUrl = Url.Action("Details",new { id = saleInvoice.InvoiceID })});
            }
            return BadRequest(ModelState);
        }

        // GET: SaleInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoice.FindAsync(id);
            if (saleInvoice == null)
            {
                return NotFound();
            }
            return View(saleInvoice);
        }

        // POST: SaleInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,SaleInvoice saleInvoice)
        {
            if (id != saleInvoice.InvoiceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saleInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleInvoiceExists(saleInvoice.InvoiceID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(saleInvoice);
        }

        // GET: SaleInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoice
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (saleInvoice == null)
            {
                return NotFound();
            }

            return View(saleInvoice);
        }

        // POST: SaleInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saleInvoice = await _context.SaleInvoice.FindAsync(id);
            _context.SaleInvoice.Remove(saleInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleInvoiceExists(int id)
        {
            return _context.SaleInvoice.Any(e => e.InvoiceID == id);
        }
        
        public async Task<IActionResult> PrintThermalInvoice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoice
                .Include(x => x.SaleInvoiceDetails)
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (saleInvoice == null)
            {
                return NotFound();
            }

            return View(saleInvoice);
        }
        public async Task<IActionResult> PrintInvoice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoice
                .Include(x => x.SaleInvoiceDetails)
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (saleInvoice == null)
            {
                return NotFound();
            }

            return View(saleInvoice);
        }
        private async Task GenerateQRcode(SaleInvoice saleInvoice)
        {
            AboutUs companyInfo = await _context.AboutUs.FirstOrDefaultAsync();
            if(companyInfo == null)
            {
                ModelState.AddModelError(string.Empty, "Please Add Company Info First");                
            }
            string QrCodeText = $"Company Name: {companyInfo?.Name}\nVAT No: {companyInfo?.VATNumber}\nDate: { DateTime.Now}\nGross Total: {saleInvoice.GrossTotal}\nTotal VAT: {saleInvoice.TotalVAT}";
            saleInvoice.QrCode = await qrCodeGenerator.GenerateQRCode(qrCodeText: QrCodeText);
        }
    }
}
