using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ChangedInputModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cd7764-1bcf-46eb-beac-0fa16cf2587e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d863fce-5ab4-4483-8abe-930ae6bea2cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87a09a5a-cd73-407b-9656-af4c3087dc59", "ccfe1605-6a28-4969-a043-444c9cc67ba5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34053843-b87a-49d1-bff4-252c0ddbedca", "ef1cae92-ae18-410a-a6cf-b9abc1113a2b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34053843-b87a-49d1-bff4-252c0ddbedca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87a09a5a-cd73-407b-9656-af4c3087dc59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d863fce-5ab4-4483-8abe-930ae6bea2cf", "d41fff27-f40b-4591-94c3-390e557f0d20", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32cd7764-1bcf-46eb-beac-0fa16cf2587e", "7f9a2d66-8f71-488d-8e06-f871d5c44f46", "Employee", "EMPLOYEE" });
        }
    }
}
