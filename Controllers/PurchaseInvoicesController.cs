using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvoiceGenerator.Data;
using InvoiceGenerator.Models;
using Microsoft.AspNetCore.Authorization;
using InvoiceGenerator.Extensions;

namespace InvoiceGenerator.Controllers
{
    [Authorize]
    public class PurchaseInvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseInvoicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchaseInvoices
        public async Task<IActionResult> Index()
        {
            return View(await _context.PurchaseInvoice.Include(x => x.PurchaseInvoiceDetails).ToListAsync());
        }

        // GET: PurchaseInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseInvoice = await _context.PurchaseInvoice
                .Include(x => x.PurchaseInvoiceDetails)
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (purchaseInvoice == null)
            {
                return NotFound();
            }

            return View(purchaseInvoice);
        }

        // GET: PurchaseInvoices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PurchaseInvoice purchaseInvoice)
        {
            if (ModelState.IsValid)
            {
                purchaseInvoice.CreatedBy = HttpContext.GetUserName();
                purchaseInvoice.IssuedDate = DateTime.Now;
                _context.Add(purchaseInvoice);
                await _context.SaveChangesAsync();
                return StatusCode(201, new { redirectUrl = Url.Action("Details", new { id = purchaseInvoice.InvoiceID }) });
            }
            return View(ModelState);
        }

        // GET: PurchaseInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseInvoice = await _context.PurchaseInvoice.FindAsync(id);
            if (purchaseInvoice == null)
            {
                return NotFound();
            }
            return View(purchaseInvoice);
        }

        // POST: PurchaseInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,PurchaseInvoice purchaseInvoice)
        {
            if (id != purchaseInvoice.InvoiceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseInvoiceExists(purchaseInvoice.InvoiceID))
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
            return View(purchaseInvoice);
        }

        // GET: PurchaseInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseInvoice = await _context.PurchaseInvoice
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (purchaseInvoice == null)
            {
                return NotFound();
            }

            return View(purchaseInvoice);
        }

        // POST: PurchaseInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseInvoice = await _context.PurchaseInvoice.FindAsync(id);
            _context.PurchaseInvoice.Remove(purchaseInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseInvoiceExists(int id)
        {
            return _context.PurchaseInvoice.Any(e => e.InvoiceID == id);
        }
        
        public async Task<IActionResult> PrintInvoice(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseInvoice = await _context.PurchaseInvoice
                .Include(x => x.PurchaseInvoiceDetails)
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (purchaseInvoice == null)
            {
                return NotFound();
            }

            return View(purchaseInvoice);
        }

    }
}
