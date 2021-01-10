using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.DAL.Migrations
{
    public partial class newCategoryDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 142, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 142, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 116, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "Description", "IsActive" },
                values: new object[] { 2, "Bilgisayar", new DateTime(2020, 12, 13, 21, 10, 3, 117, DateTimeKind.Local).AddTicks(4297), "Teknoloji", true });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 134, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 134, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 140, DateTimeKind.Local).AddTicks(9486));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 17, 35, 17, 360, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 17, 35, 17, 360, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 17, 35, 17, 333, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 17, 35, 17, 352, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 17, 35, 17, 352, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 17, 35, 17, 358, DateTimeKind.Local).AddTicks(8260));
        }
    }
}
