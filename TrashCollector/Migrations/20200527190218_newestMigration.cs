using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class newestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "accfffd5-5cb9-4346-8f21-bb859b9c4f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc4a2317-720b-4114-a2ff-1209e0a3dc9c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47f89360-37cd-43b4-b90e-c3026c5d11d5", "42850907-6ce7-444f-9341-6c3d6e00fd36", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e11beb7e-7f99-408d-8970-84488c486df2", "afc3404b-d568-49b8-bbab-f082b7aa3c49", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47f89360-37cd-43b4-b90e-c3026c5d11d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e11beb7e-7f99-408d-8970-84488c486df2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc4a2317-720b-4114-a2ff-1209e0a3dc9c", "def2797d-fd48-417a-9579-7a9d1fb41b12", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "accfffd5-5cb9-4346-8f21-bb859b9c4f92", "9109ecd8-d9e5-47f4-a4f7-208be536a7dd", "Employee", "EMPLOYEE" });
        }
    }
}
