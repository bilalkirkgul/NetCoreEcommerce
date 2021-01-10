using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.DAL.Migrations
{
    public partial class endUniqConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Supplier_CompanyName",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryName",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Brand_BrandName",
                table: "Brand");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 38, 14, 27, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 38, 14, 27, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 38, 14, 7, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 38, 14, 8, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 38, 14, 22, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 38, 14, 22, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate" },
                values: new object[] { new Guid("2ee568fd-ec32-440b-a848-553a8ba0781d"), new DateTime(2020, 12, 20, 1, 38, 14, 26, DateTimeKind.Local).AddTicks(4260) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 30, 15, 76, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 30, 15, 76, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 30, 15, 58, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 30, 15, 59, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 30, 15, 73, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 20, 1, 30, 15, 73, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate" },
                values: new object[] { new Guid("a3c609c4-8cdf-4a49-8b38-c18cadd5517d"), new DateTime(2020, 12, 20, 1, 30, 15, 75, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CompanyName",
                table: "Supplier",
                column: "CompanyName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryName",
                table: "Category",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_BrandName",
                table: "Brand",
                column: "BrandName",
                unique: true);
        }
    }
}
