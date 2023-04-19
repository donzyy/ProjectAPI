using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetails",
                columns: table => new
                {
                    PurchaseOrderDetail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrder_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderDetail_Quantity = table.Column<float>(type: "real", nullable: false),
                    PurchaseOrderDetail_Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrderDetail_Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrderDetail_Qty_Received = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetails", x => x.PurchaseOrderDetail_ID);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    PurchaseOrder_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrder_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrder_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrder_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseOrder_Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.PurchaseOrder_ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Supplier_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier_Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Supplier_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
