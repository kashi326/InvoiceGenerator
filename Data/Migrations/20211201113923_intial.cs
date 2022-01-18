using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenerator.Data.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "SaleInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChequeDate",
                table: "SaleInvoice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChequeNumber",
                table: "SaleInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SaleInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayeeName",
                table: "SaleInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "SaleInvoice",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "SaleInvoice");

            migrationBuilder.DropColumn(
                name: "ChequeDate",
                table: "SaleInvoice");

            migrationBuilder.DropColumn(
                name: "ChequeNumber",
                table: "SaleInvoice");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SaleInvoice");

            migrationBuilder.DropColumn(
                name: "PayeeName",
                table: "SaleInvoice");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "SaleInvoice");
        }
    }
}
