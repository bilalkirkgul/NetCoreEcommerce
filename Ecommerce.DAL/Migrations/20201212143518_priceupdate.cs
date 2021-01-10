using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.DAL.Migrations
{
    public partial class priceupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "numeric(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(3,2)",
                oldPrecision: 3,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetail",
                type: "numeric(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(3,2)",
                oldPrecision: 3,
                oldScale: 2);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "numeric(3,2)",
                precision: 3,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetail",
                type: "numeric(3,2)",
                precision: 3,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 316, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 316, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 295, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 310, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 310, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 314, DateTimeKind.Local).AddTicks(8768));
        }
    }
}
