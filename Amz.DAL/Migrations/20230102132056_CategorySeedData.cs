using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amz.DAL.Migrations
{
    public partial class CategorySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Name" },
                values: new object[,] {
                { "Toys & Games" }, { "Fashion"}, { "Electronics"}, { "Home & Garden"}
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                 table: "Category",
                 keyColumn: "Name",
                 keyValue: "Toys & Games");

            migrationBuilder.DeleteData(
                 table: "Category",
                 keyColumn: "Name",
                 keyValue: "Fashion");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Name",
                keyValue: "Electronics");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Name",
                keyValue: "Home & Garden");
        }
    }
}
