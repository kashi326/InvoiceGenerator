using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string VATNumber { get; set; }
        public string GroupVatNumber { get; set; }
        public string Email { get; set; }
        public string Cr { get; set; }
        public string Tel { get; set; }
        public string Mob { get; set; }
        public string BussinessTagLine { get; set; }
        public string ImageFile { get; set; }
        public string BusinessName { get; set; }

        public string NameArabic { get; set; }

        public string StreetNameArabic { get; set; }
        public string DistrictArabic { get; set; }
        public string CityArabic { get; set; }
        public string CountryArabic { get; set; }

        public string BussinessTagLineArabic { get; set; }

        public string BusinessNameArabic { get; set; }
    }
}
