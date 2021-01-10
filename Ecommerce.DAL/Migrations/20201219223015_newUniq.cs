using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.DAL.Migrations
{
    public partial class newUniq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 13, 21, 10, 3, 117, DateTimeKind.Local).AddTicks(4297));

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
                columns: new[] { "ActivationCode", "CreatedDate" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 12, 13, 21, 10, 3, 140, DateTimeKind.Local).AddTicks(9486) });
        }
    }
}
