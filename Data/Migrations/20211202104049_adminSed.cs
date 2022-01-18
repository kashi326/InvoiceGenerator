using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenerator.Data.Migrations
{
    public partial class adminSed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb134e2d-9ee3-4563-8c92-54fd41733fa1", 0, "0d04e5b0-bbe1-4c56-a7b9-92c22709c070", "jmm.bilal@gmail.com", true, false, null, "JMM.BILAL@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHH1VbMvX+iwivyu4A9qAbNPBDWKk/coLJscWM3zn9wt5UaTWTiynFTwJfopgymzAw==", null, false, "dd749b72-bada-40c7-aca7-ce8a1b947be0", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb134e2d-9ee3-4563-8c92-54fd41733fa1");
        }
    }
}
