using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class AddUserUserRoleRoleRolePrivilegesPrivileges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    Privileges_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Privileges_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Privileges_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.Privileges_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Digital_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Password_Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    User_Profile_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Privileges_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Role_ID);
                    table.ForeignKey(
                        name: "FK_Roles_Privileges_Privileges_ID",
                        column: x => x.Privileges_ID,
                        principalTable: "Privileges",
                        principalColumn: "Privileges_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePrivileges",
                columns: table => new
                {
                    Role_Privileges_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Privileges_ID = table.Column<int>(type: "int", nullable: true),
                    Role_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePrivileges", x => x.Role_Privileges_ID);
                    table.ForeignKey(
                        name: "FK_RolePrivileges_Privileges_Privileges_ID",
                        column: x => x.Privileges_ID,
                        principalTable: "Privileges",
                        principalColumn: "Privileges_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePrivileges_Roles_Role_ID",
                        column: x => x.Role_ID,
                        principalTable: "Roles",
                        principalColumn: "Role_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    User_Role_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: true),
                    Role_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.User_Role_ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_Role_ID",
                        column: x => x.Role_ID,
                        principalTable: "Roles",
                        principalColumn: "Role_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePrivileges_Privileges_ID",
                table: "RolePrivileges",
                column: "Privileges_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePrivileges_Role_ID",
                table: "RolePrivileges",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Privileges_ID",
                table: "Roles",
                column: "Privileges_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Role_ID",
                table: "UserRoles",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_User_ID",
                table: "UserRoles",
                column: "User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePrivileges");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                });
        }
    }
}
