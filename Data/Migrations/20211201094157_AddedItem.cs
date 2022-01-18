using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenerator.Data.Migrations
{
    public partial class AddedItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleInvoiceDetails",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoiceDetails",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "SaleInvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "PurchaseInvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleInvoiceDetails",
                table: "SaleInvoiceDetails",
                columns: new[] { "SaleInvoiceID", "ItemID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoiceDetails",
                table: "PurchaseInvoiceDetails",
                columns: new[] { "PurchaseInvoiceID", "ItemID" });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PiecesPerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailSellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RetailCostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThresholdQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageSction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierBarCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoiceDetails_ItemID",
                table: "SaleInvoiceDetails",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceDetails_ItemID",
                table: "PurchaseInvoiceDetails",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceDetails_Items_ItemID",
                table: "PurchaseInvoiceDetails",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoiceDetails_Items_ItemID",
                table: "SaleInvoiceDetails",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceDetails_Items_ItemID",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoiceDetails_Items_ItemID",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleInvoiceDetails",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropIndex(
                name: "IX_SaleInvoiceDetails_ItemID",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoiceDetails",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseInvoiceDetails_ItemID",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "SaleInvoiceDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "PurchaseInvoiceDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleInvoiceDetails",
                table: "SaleInvoiceDetails",
                columns: new[] { "SaleInvoiceID", "ItemDescription" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoiceDetails",
                table: "PurchaseInvoiceDetails",
                columns: new[] { "PurchaseInvoiceID", "ItemDescription" });
        }
    }
}
