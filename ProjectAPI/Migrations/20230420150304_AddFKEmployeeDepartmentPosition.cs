using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class AddFKEmployeeDepartmentPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_Department_ID",
                table: "Employees",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Position_ID",
                table: "Employees",
                column: "Position_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Department_ID",
                table: "Employees",
                column: "Department_ID",
                principalTable: "Departments",
                principalColumn: "Department_ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_Position_ID",
                table: "Employees",
                column: "Position_ID",
                principalTable: "Positions",
                principalColumn: "Position_ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Department_ID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_Position_ID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Department_ID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Position_ID",
                table: "Employees");
        }
    }
}
