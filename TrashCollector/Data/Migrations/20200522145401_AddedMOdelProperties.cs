using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedMOdelProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b1bf9d-76bb-499d-8973-9710f3877940");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94f6d013-5ed0-467c-b2f9-5c8231da98fa");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b33dd34c-e638-41ac-ad7d-7b68ab478923", "54433999-f039-40e3-a2da-c459558325a8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19e310c8-d429-4950-97a2-26c668d95e99", "5d232bce-4479-4f82-907e-fd47729b2b8d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e310c8-d429-4950-97a2-26c668d95e99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b33dd34c-e638-41ac-ad7d-7b68ab478923");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94f6d013-5ed0-467c-b2f9-5c8231da98fa", "64946a96-063b-471b-80b3-0226b2f2bf48", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32b1bf9d-76bb-499d-8973-9710f3877940", "40c8d77a-2f07-455a-82a0-ed2b66dd4b94", "Employee", "EMPLOYEE" });
        }
    }
}
