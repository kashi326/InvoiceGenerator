using InvoiceGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace InvoiceGenerator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<SaleInvoice>()
                .HasMany(x => x.SaleInvoiceDetails)
                .WithOne(x => x.SaleInvoice)
                .HasForeignKey(x => x.SaleInvoiceID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SaleInvoiceDetails>()
                .HasKey(x => new { x.SaleInvoiceID, x.ItemID });

            builder.Entity<SaleInvoiceDetails>()
                .HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemID)
                .OnDelete(DeleteBehavior.Cascade);
               

            builder.Entity<PurchaseInvoice>()
                .HasMany(x => x.PurchaseInvoiceDetails)
                .WithOne(x => x.PurchaseInvoice)
                .HasForeignKey(x => x.PurchaseInvoiceID)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<PurchaseInvoiceDetails>()
                .HasKey(x => new { x.PurchaseInvoiceID, x.ItemID });

            builder.Entity<PurchaseInvoiceDetails>()
                .HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemID)
                .OnDelete(DeleteBehavior.Cascade);

            SeedAboutUs(builder);

            SeedAdminUser(builder);

        }

        private ModelBuilder SeedAboutUs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutUs>().HasData(new Models.AboutUs
            {
                Id = -1,
                Name = "JMM Technologies",
                StreetName = "Mubashir Plaza Abbottabad",
                District = "Abbottabad",
                City = "Abbottabad",
                Country = "Pakistan",
                PostalCode = "21300",
                VATNumber = "123456789",
                GroupVatNumber = "123456789",
                Email = "jmm.bilal@gmail.com",
                Cr = "123456789",
                Tel = "123456789",
                Mob = "123456789",
                BussinessTagLine = "TagLine",
                BusinessName = "JMM Technologies",
                NameArabic = "جے  ایم  ایم  تیکنالوجی",
            });
            return modelBuilder;
        }

        private ModelBuilder SeedAdminUser(ModelBuilder modelBuilder)
        {            
            var passwordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin123");
            modelBuilder.Entity<IdentityUser>()
                .HasData(new IdentityUser
                {
                    Email = "jmm.bilal@gmail.com",
                    NormalizedEmail = "JMM.BILAL@GMAIL.COM",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = passwordHash,
                    EmailConfirmed = true,
                    Id = Guid.NewGuid().ToString(),
                });

            return modelBuilder;

        }
        public DbSet<InvoiceGenerator.Models.SaleInvoice> SaleInvoice { get; set; }

        public DbSet<InvoiceGenerator.Models.PurchaseInvoice> PurchaseInvoice { get; set; }
    }
}
