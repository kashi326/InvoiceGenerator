using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class InvoicesReportInputModel
    {
        [Display(Name = "Date")]
        public string DateRange { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        public bool? Print { get; set; }
    }
}
