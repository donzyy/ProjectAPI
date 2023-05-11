using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class AddFKDriverCustomerPaymentTypeTrucksProductProductBatchProductTypePurchaseOrderAndTheRest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Product_Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    PaymentType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentType_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_Product_ID",
                table: "SalesDetails",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_Sales_ID",
                table: "SalesDetails",
                column: "Sales_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Customer_ID",
                table: "Sale",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Driver_ID",
                table: "Sale",
                column: "Driver_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Payment_Type_ID",
                table: "Sale",
                column: "Payment_Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_SalesMan_ID",
                table: "Sale",
                column: "SalesMan_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Truck_ID",
                table: "Sale",
                column: "Truck_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_Supplier_ID",
                table: "PurchaseOrders",
                column: "Supplier_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_Product_ID",
                table: "PurchaseOrderDetails",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrder_ID",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrder_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_Batch_ID",
                table: "Products",
                column: "Product_Batch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_Type_ID",
                table: "Products",
                column: "Product_Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBatches_Product_ID",
                table: "ProductBatches",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_Truck_ID",
                table: "Drivers",
                column: "Truck_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Trucks_Truck_ID",
                table: "Drivers",
                column: "Truck_ID",
                principalTable: "Trucks",
                principalColumn: "Truck_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBatches_Products_Product_ID",
                table: "ProductBatches",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "Product_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBatches_Product_Batch_ID",
                table: "Products",
                column: "Product_Batch_ID",
                principalTable: "ProductBatches",
                principalColumn: "ProductBatch_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_Product_Type_ID",
                table: "Products",
                column: "Product_Type_ID",
                principalTable: "ProductTypes",
                principalColumn: "ProductType_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_Products_Product_ID",
                table: "PurchaseOrderDetails",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "Product_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrder_ID",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrder_ID",
                principalTable: "PurchaseOrders",
                principalColumn: "PurchaseOrder_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Suppliers_Supplier_ID",
                table: "PurchaseOrders",
                column: "Supplier_ID",
                principalTable: "Suppliers",
                principalColumn: "Supplier_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customers_Customer_ID",
                table: "Sale",
                column: "Customer_ID",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Drivers_Driver_ID",
                table: "Sale",
                column: "Driver_ID",
                principalTable: "Drivers",
                principalColumn: "Driver_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_PaymentType_Payment_Type_ID",
                table: "Sale",
                column: "Payment_Type_ID",
                principalTable: "PaymentType",
                principalColumn: "PaymentType_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_SalesMen_SalesMan_ID",
                table: "Sale",
                column: "SalesMan_ID",
                principalTable: "SalesMen",
                principalColumn: "SalesMan_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Trucks_Truck_ID",
                table: "Sale",
                column: "Truck_ID",
                principalTable: "Trucks",
                principalColumn: "Truck_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_Products_Product_ID",
                table: "SalesDetails",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "Product_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_Sale_Sales_ID",
                table: "SalesDetails",
                column: "Sales_ID",
                principalTable: "Sale",
                principalColumn: "Sales_ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Trucks_Truck_ID",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductBatches_Products_Product_ID",
                table: "ProductBatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBatches_Product_Batch_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_Product_Type_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_Products_Product_ID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrder_ID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Suppliers_Supplier_ID",
                table: "PurchaseOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customers_Customer_ID",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Drivers_Driver_ID",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_PaymentType_Payment_Type_ID",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_SalesMen_SalesMan_ID",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Trucks_Truck_ID",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_Products_Product_ID",
                table: "SalesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_Sale_Sales_ID",
                table: "SalesDetails");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_Product_ID",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_Sales_ID",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_Sale_Customer_ID",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_Driver_ID",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_Payment_Type_ID",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_SalesMan_ID",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_Truck_ID",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrders_Supplier_ID",
                table: "PurchaseOrders");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderDetails_Product_ID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrder_ID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Products_Product_Batch_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Product_Type_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductBatches_Product_ID",
                table: "ProductBatches");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_Truck_ID",
                table: "Drivers");

            migrationBuilder.AlterColumn<int>(
                name: "Product_Name",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
