using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class SaleInvoice
    {
        [Key]
        [Display(Name = "Invoice ID")]
        public int InvoiceID { get; set; }
        [Display(Name = "Issue Date")]
        public DateTime IssuedDate { get; set; } = DateTime.Now;
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
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Tax Treatment Narration")]
        public string TaxTreatmentNarration { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }
        [Display(Name = "Customer VAT Number")]
        public string CustomerVATNumber { get; set; }
        [Display(Name = "Customer Group VAT Number")]
        public string CustomerGroupVATNumber { get; set; }
        [Display(Name = "Seller Name")]
        public string SellerName { get; set; }
        [Display(Name = "Seller Address")]
        public string SellerAddress { get; set; }
        [Display(Name = "Seller VAT Number")]
        public string SellerVATNumber { get; set; }
        [Display(Name = "Seller Group VAT Number")]
        public string SellerGroupVATNumber { get; set; }
        [Display(Name = "QR Code")]
        public string QrCode { get; set; }
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
        public virtual ICollection<SaleInvoiceDetails> SaleInvoiceDetails { get; set; }
    }

    public enum PaymentMethod
    {
        /// <summary>
        /// Customer or  Supplier make payment by OnCash
        /// </summary>
        [Display(Name = "On Cash")]
        CASH,
        /// <summary>
        /// Customer or  Supplier make payment by Cheque
        /// </summary>
        [Display(Name = "Cheque")]
        BANK_CHEQUE,
        /// <summary>
        /// Customer or  Supplier make payment by On Network
        /// </summary>
        [Display(Name = "On Network")]
        PAYMENT_TERMINAL,
        /// <summary>
        /// Customer or  Supplier make payment  by E-Transfer
        /// </summary>
        [Display(Name = "E-Trasnsfer")]
        E_TRANSFER
    }
}
