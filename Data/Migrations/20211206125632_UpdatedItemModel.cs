using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenerator.Data.Migrations
{
    public partial class UpdatedItemModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb134e2d-9ee3-4563-8c92-54fd41733fa1");

            migrationBuilder.AddColumn<bool>(
                name: "IsVatInclusive",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9d4ee41c-61c0-4113-82fe-a81d90024003", 0, "e9f159dd-0bae-4dbb-9dec-daa9cc1db4a4", "jmm.bilal@gmail.com", true, false, null, "JMM.BILAL@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKDcO572p6azwPQOJ3DlnIjLdYF3YztBrxc/WDWEye+xOOuE2yEf01Y98IY8nQYl7w==", null, false, "80618e89-d4be-49a0-9c71-87c447d2c8c0", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d4ee41c-61c0-4113-82fe-a81d90024003");

            migrationBuilder.DropColumn(
                name: "IsVatInclusive",
                table: "Items");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb134e2d-9ee3-4563-8c92-54fd41733fa1", 0, "0d04e5b0-bbe1-4c56-a7b9-92c22709c070", "jmm.bilal@gmail.com", true, false, null, "JMM.BILAL@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHH1VbMvX+iwivyu4A9qAbNPBDWKk/coLJscWM3zn9wt5UaTWTiynFTwJfopgymzAw==", null, false, "dd749b72-bada-40c7-aca7-ce8a1b947be0", false, "admin" });
        }
    }
}
