using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class SecondMigratiom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Department_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee_Phone_Number = table.Column<int>(type: "int", nullable: false),
                    Employee_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department_ID = table.Column<int>(type: "int", nullable: false),
                    Employee_Salary = table.Column<double>(type: "float", nullable: false),
                    Employee_Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_Termination_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_Status = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Position_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Position_ID);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercentageChange = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
