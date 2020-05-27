using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class newerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b50b65e-f53b-40ac-a272-9dc744ccfa76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d933e575-8ec5-4b66-85b4-2bfa9e585c3e");

            migrationBuilder.AddColumn<bool>(
                name: "PickupComplete",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61b4e5ad-a414-4fb8-ab4a-8cc58b6f250d", "5e756607-545d-4135-b1e8-16f0e2e0d6f7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb4a1656-6154-4bcd-ac76-b176ca22533d", "17b4f14f-225a-4ebd-aaa9-b9db3c54352d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61b4e5ad-a414-4fb8-ab4a-8cc58b6f250d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb4a1656-6154-4bcd-ac76-b176ca22533d");

            migrationBuilder.DropColumn(
                name: "PickupComplete",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b50b65e-f53b-40ac-a272-9dc744ccfa76", "860e6138-cecb-4772-bf4b-c4490f00f554", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d933e575-8ec5-4b66-85b4-2bfa9e585c3e", "d82018cc-c407-43a9-b6a5-2cad93691762", "Employee", "EMPLOYEE" });
        }
    }
}
