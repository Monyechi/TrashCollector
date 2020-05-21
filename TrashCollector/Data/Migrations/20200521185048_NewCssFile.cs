using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class NewCssFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f16b6da0-8b78-4013-8ffe-529c75f157f0", "e76bbb7f-ed75-49d9-8155-61108cd56e67", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba60de80-08c1-4925-9622-09dc57784986", "c8a09be9-9d31-4ba3-9bb5-12297a919422", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba60de80-08c1-4925-9622-09dc57784986");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f16b6da0-8b78-4013-8ffe-529c75f157f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87a09a5a-cd73-407b-9656-af4c3087dc59", "ccfe1605-6a28-4969-a043-444c9cc67ba5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34053843-b87a-49d1-bff4-252c0ddbedca", "ef1cae92-ae18-410a-a6cf-b9abc1113a2b", "Employee", "EMPLOYEE" });
        }
    }
}
