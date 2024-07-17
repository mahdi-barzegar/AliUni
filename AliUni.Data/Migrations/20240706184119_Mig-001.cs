using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AliUni.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permisions",
                columns: new[] { "PermisionId", "PermisionName" },
                values: new object[,]
                {
                    { 1, "Admin Panel" },
                    { 2, "Student Panel" },
                    { 3, "Manage Students" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Student" },
                    { 3, "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "RolePermisionconnections",
                columns: new[] { "RPCId", "PermisionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 3, 3 },
                    { 5, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermisionconnections",
                keyColumn: "RPCId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RolePermisionconnections",
                keyColumn: "RPCId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RolePermisionconnections",
                keyColumn: "RPCId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RolePermisionconnections",
                keyColumn: "RPCId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RolePermisionconnections",
                keyColumn: "RPCId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permisions",
                keyColumn: "PermisionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permisions",
                keyColumn: "PermisionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permisions",
                keyColumn: "PermisionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);
        }
    }
}
