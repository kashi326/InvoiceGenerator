using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenerator.Data.Migrations
{
    public partial class AboutUsSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "BusinessName", "BusinessNameArabic", "BussinessTagLine", "BussinessTagLineArabic", "City", "CityArabic", "Country", "CountryArabic", "Cr", "District", "DistrictArabic", "Email", "GroupVatNumber", "ImageFile", "Mob", "Name", "NameArabic", "PostalCode", "StreetName", "StreetNameArabic", "Tel", "VATNumber" },
                values: new object[] { -1, "JMM Technologies", null, "TagLine", null, "Abbottabad", null, "Pakistan", null, "123456789", "Abbottabad", null, "jmm.bilal@gmail.com", "123456789", null, "123456789", "JMM Technologies", "جے  ایم  ایم  تیکنالوجی", "21300", "Mubashir Plaza Abbottabad", null, "123456789", "123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
