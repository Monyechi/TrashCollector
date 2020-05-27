using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class changedCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dc6be04-39bf-422d-93f5-9e18ef91b9e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d12dfe4-cf26-4726-bf34-8f5ed1867ad0");

            migrationBuilder.DropColumn(
                name: "PickupComplete",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "PickupStatus",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc4a2317-720b-4114-a2ff-1209e0a3dc9c", "def2797d-fd48-417a-9579-7a9d1fb41b12", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "accfffd5-5cb9-4346-8f21-bb859b9c4f92", "9109ecd8-d9e5-47f4-a4f7-208be536a7dd", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "accfffd5-5cb9-4346-8f21-bb859b9c4f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc4a2317-720b-4114-a2ff-1209e0a3dc9c");

            migrationBuilder.DropColumn(
                name: "PickupStatus",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "PickupComplete",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dc6be04-39bf-422d-93f5-9e18ef91b9e6", "af5bf42e-af3e-492c-8add-cdfb07993c4c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d12dfe4-cf26-4726-bf34-8f5ed1867ad0", "ed635188-f54b-4551-9639-1fadf620b6fc", "Employee", "EMPLOYEE" });
        }
    }
}
