using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedCustomerProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3bb7b64-9281-48b8-bb89-2ed1a5543aae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3e10d0e-07f8-4df4-bcdf-dd7cd62f8d6f");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab3c6dd6-8839-4c6a-9b49-39869b0d844a", "23b40aa5-eaa8-4e8c-b527-d6fd043bf69c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5a8ebeb-6a6e-4b5a-984b-c62c8413216b", "8d471d0f-9d0a-4208-9d06-4df8779d465d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab3c6dd6-8839-4c6a-9b49-39869b0d844a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a8ebeb-6a6e-4b5a-984b-c62c8413216b");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3bb7b64-9281-48b8-bb89-2ed1a5543aae", "51c4e1b9-5535-4787-b040-7ffecc926ee6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3e10d0e-07f8-4df4-bcdf-dd7cd62f8d6f", "56d364de-9087-4351-bfe4-85112af470b5", "Employee", "EMPLOYEE" });
        }
    }
}
