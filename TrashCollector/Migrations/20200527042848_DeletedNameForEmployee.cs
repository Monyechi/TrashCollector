using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class DeletedNameForEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dc6be04-39bf-422d-93f5-9e18ef91b9e6", "af5bf42e-af3e-492c-8add-cdfb07993c4c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d12dfe4-cf26-4726-bf34-8f5ed1867ad0", "ed635188-f54b-4551-9639-1fadf620b6fc", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dc6be04-39bf-422d-93f5-9e18ef91b9e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d12dfe4-cf26-4726-bf34-8f5ed1867ad0");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61b4e5ad-a414-4fb8-ab4a-8cc58b6f250d", "5e756607-545d-4135-b1e8-16f0e2e0d6f7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb4a1656-6154-4bcd-ac76-b176ca22533d", "17b4f14f-225a-4ebd-aaa9-b9db3c54352d", "Employee", "EMPLOYEE" });
        }
    }
}
