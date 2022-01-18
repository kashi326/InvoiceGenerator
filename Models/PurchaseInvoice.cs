using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class PurchaseInvoice
    {
        [Key]
        [Display(Name = "Invoice ID")]
        public int InvoiceID { get; set; }
        [Display(Name = "Issue Date")]
        public DateTime IssuedDate { get; set; }
        [DisplayName("Total")]
        public decimal Total { get; set; }
        [DisplayName("Gross Total")]
        public decimal GrossTotal { get; set; }
        [Display(Name = "Net Total")]
        public decimal NetTotal { get; set; }
        [Display(Name = "Amount Paid")]
        public decimal AmountPaid { get; set; }
        [DisplayName("Discount Amount")]
        public decimal DiscountAmount { get; set; }
        [Display(Name = "Discount Percentage")]
        public decimal DiscountPercentage { get; set; }
        [DisplayName("Total VAT")]
        public decimal TotalVAT { get; set; }
        [Display(Name = "VAT Percentage")]
        public decimal VATPercentage { get; set; }
        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Tax Treatment Narration")]
        public string TaxTreatmentNarration { get; set; }
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }
        [Display(Name = "Supplier Address")]
        public string SupplierAddress { get; set; }
        [Display(Name = "Supplier VAT Number")]
        public string SupplierVATNumber { get; set; }
        [Display(Name = "Supplier Group VAT Number")]
        public string SupplierGroupVATNumber { get; set; }
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Bank Name")]
        public string BankName { get; set; }
        [Display(Name = "Payee Name")]
        public string PayeeName { get; set; }
        [Display(Name = "Cheque Number")]
        public string ChequeNumber { get; set; }
        [Display(Name = "Cheque Date")]
        public DateTime? ChequeDate { get; set; }
        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Transaction Id")]
        public string TransactionId { get; set; }
        public ICollection<PurchaseInvoiceDetails> PurchaseInvoiceDetails { get; set; }
    }
}
