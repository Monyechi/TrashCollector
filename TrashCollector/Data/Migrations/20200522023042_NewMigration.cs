using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b49f5c7-0398-4024-83b6-9aea3e60c29a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88dc4948-d157-44ee-ab2a-591f7937e2bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94f6d013-5ed0-467c-b2f9-5c8231da98fa", "64946a96-063b-471b-80b3-0226b2f2bf48", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32b1bf9d-76bb-499d-8973-9710f3877940", "40c8d77a-2f07-455a-82a0-ed2b66dd4b94", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b1bf9d-76bb-499d-8973-9710f3877940");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94f6d013-5ed0-467c-b2f9-5c8231da98fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88dc4948-d157-44ee-ab2a-591f7937e2bb", "5f828252-015c-4dbc-b506-01161961638c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b49f5c7-0398-4024-83b6-9aea3e60c29a", "352bce11-7255-473e-97aa-2b042cb16de3", "Employee", "EMPLOYEE" });
        }
    }
}
