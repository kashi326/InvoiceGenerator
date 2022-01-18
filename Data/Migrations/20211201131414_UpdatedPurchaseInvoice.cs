using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenerator.Data.Migrations
{
    public partial class UpdatedPurchaseInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "PurchaseInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChequeDate",
                table: "PurchaseInvoice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChequeNumber",
                table: "PurchaseInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PurchaseInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayeeName",
                table: "PurchaseInvoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "PurchaseInvoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "PurchaseInvoice",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "ChequeDate",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "ChequeNumber",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "PayeeName",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "PurchaseInvoice");
        }
    }
}
