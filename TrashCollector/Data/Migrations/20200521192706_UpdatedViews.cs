using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d3bb7b64-9281-48b8-bb89-2ed1a5543aae", "51c4e1b9-5535-4787-b040-7ffecc926ee6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3e10d0e-07f8-4df4-bcdf-dd7cd62f8d6f", "56d364de-9087-4351-bfe4-85112af470b5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3bb7b64-9281-48b8-bb89-2ed1a5543aae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3e10d0e-07f8-4df4-bcdf-dd7cd62f8d6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f16b6da0-8b78-4013-8ffe-529c75f157f0", "e76bbb7f-ed75-49d9-8155-61108cd56e67", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba60de80-08c1-4925-9622-09dc57784986", "c8a09be9-9d31-4ba3-9bb5-12297a919422", "Employee", "EMPLOYEE" });
        }
    }
}
