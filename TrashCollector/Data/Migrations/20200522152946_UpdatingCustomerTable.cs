using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatingCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e310c8-d429-4950-97a2-26c668d95e99",
                column: "ConcurrencyStamp",
                value: "29a56ccb-a7df-4ee2-bc7a-452f454b3341");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b33dd34c-e638-41ac-ad7d-7b68ab478923",
                column: "ConcurrencyStamp",
                value: "259bf67d-fabd-48de-943a-08f55da40e14");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e310c8-d429-4950-97a2-26c668d95e99",
                column: "ConcurrencyStamp",
                value: "5d232bce-4479-4f82-907e-fd47729b2b8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b33dd34c-e638-41ac-ad7d-7b68ab478923",
                column: "ConcurrencyStamp",
                value: "54433999-f039-40e3-a2da-c459558325a8");
        }
    }
}
