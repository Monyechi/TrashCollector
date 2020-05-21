using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedModelProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e98cb7-c8b5-4af8-8c16-25f05d62d22a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee692d12-e334-42f7-a917-92fc55ffc7d9");

            migrationBuilder.AddColumn<bool>(
                name: "CompletedPickup",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "CustomerInvoice",
                table: "Employee",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customer",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraOneTimePickup",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeeklyPickupDay",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d863fce-5ab4-4483-8abe-930ae6bea2cf", "d41fff27-f40b-4591-94c3-390e557f0d20", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32cd7764-1bcf-46eb-beac-0fa16cf2587e", "7f9a2d66-8f71-488d-8e06-f871d5c44f46", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cd7764-1bcf-46eb-beac-0fa16cf2587e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d863fce-5ab4-4483-8abe-930ae6bea2cf");

            migrationBuilder.DropColumn(
                name: "CompletedPickup",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CustomerInvoice",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ExtraOneTimePickup",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "WeeklyPickupDay",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5e98cb7-c8b5-4af8-8c16-25f05d62d22a", "1ac8ebd3-f5bd-4b76-a033-afd899a02bec", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee692d12-e334-42f7-a917-92fc55ffc7d9", "b80d3efd-a082-4f51-85c5-ed9213da5484", "Employee", "EMPLOYEE" });
        }
    }
}
