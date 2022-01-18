using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class PurchaseInvoiceDetails
    {
        public int PurchaseInvoiceID { get; set; }
        [Display(Name = "Item Id")]
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        [Display(Name = "Issue Date")]
        public DateTime IssuedDate { get; set; }
        [Display(Name = "Sr No")]
        public int SrNo { get; set; }
        [Display(Name = "Unit")]
        public string Unit { get; set; }
        [Display(Name = "Cost Price")]
        public decimal CostPrice { get; set; }
        [Display(Name = "Quantity")]
        public decimal Quantity { get; set; }
        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; set; }
        [Display(Name = "Discount Percentage")]
        public decimal DiscountPercentage { get; set; }
        [Display(Name = "VAT Percentage")]
        public decimal VATPercentage { get; set; }
        [Display(Name = "VAT Amount")]
        public decimal VATAmount { get; set; }
        [Display(Name = "Sub Total (VAT Excl)")]
        public decimal SubTotalVATExclusive { get; set; }
        [Display(Name = "Sub Total (VAT Incl)")]
        public decimal SubTotalVATInclusive { get; set; }
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
    }
}
