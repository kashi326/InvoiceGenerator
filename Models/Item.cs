using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class Item
    {
        [Key]
        [Display(Name = "Item Id")]
        public int ItemID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Quantity")]
        public decimal Quantity { get; set; }
        [Display(Name = "Pieces Per Unit")]
        public decimal PiecesPerUnit { get; set; }
        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; }
        [Display(Name = "Retail Sell Price")]
        public decimal RetailSellPrice { get; set; }
        [Display(Name = "Retail Cost Price")]
        public decimal RetailCostPrice { get; set; }
        [Display(Name = "Threshold Quantity")]
        public decimal ThresholdQuantity { get; set; }
        [Display(Name = "Bin")]
        public string Bin { get; set; }
        [Display(Name = "Storage Section")]
        public string StorageSction { get; set; }
        [Display(Name = "Storage Type")]
        public string StorageType { get; set; }
        [Display(Name = "Shelf Number")]
        public string ShelfNumber { get; set; }
        [Display(Name = "Supplier Bar Code")]
        public string SupplierBarCode { get; set; }
        [Display(Name = "Is VAT Inclusive")]
        public bool IsVatInclusive { get; set; }


    }
}
