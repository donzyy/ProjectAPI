using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class AddUserUserRoleRoleRolePrivilegesPrivilegesStringLengthRemoveRoleFromPriviledge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.DropForeignKey(
                name: "FK_Roles_Privileges_Privileges_ID",
                table: "Roles"); */

            migrationBuilder.DropIndex(
                name: "IX_Roles_Privileges_ID",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Privileges_ID",
                table: "Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Privileges_ID",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Privileges_ID",
                table: "Roles",
                column: "Privileges_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Privileges_Privileges_ID",
                table: "Roles",
                column: "Privileges_ID",
                principalTable: "Privileges",
                principalColumn: "Privileges_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
