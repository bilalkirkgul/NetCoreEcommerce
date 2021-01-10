using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.DAL.Migrations
{
    public partial class newdataconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "ID", "BrandName", "CreatedDate", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1, "Iphone", new DateTime(2020, 12, 12, 0, 31, 42, 316, DateTimeKind.Local).AddTicks(387), "İos", true },
                    { 2, "Samsung", new DateTime(2020, 12, 12, 0, 31, 42, 316, DateTimeKind.Local).AddTicks(1241), "Android", true }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "Description", "IsActive" },
                values: new object[] { 1, "Cep Telefonu", new DateTime(2020, 12, 12, 0, 31, 42, 295, DateTimeKind.Local).AddTicks(9885), "İletişim Aracı", true });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "ID", "Address", "City", "CompanyName", "Country", "CreatedDate", "IsActive", "PhoneNummer" },
                values: new object[,]
                {
                    { 1, "Büyükdere caddesi Levent 199. Kat 22 - 23 Şişli", "İstanbul", "Apple Teknoloji ve Satış Limited Şirketi", "Türkiye", new DateTime(2020, 12, 12, 0, 31, 42, 310, DateTimeKind.Local).AddTicks(6326), true, "02123982800" },
                    { 2, "Flatofis İstanbul İş Merkezi Otakçılar Cad. No.78 K.3 No.B3 – K.4 No.59/1", "İstanbul", "Samsung Electronics Istanbul Pazarlama ve Ticaret Limited Şirketi", "Türkiye", new DateTime(2020, 12, 12, 0, 31, 42, 310, DateTimeKind.Local).AddTicks(8281), true, "08502010222" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 12, 0, 31, 42, 314, DateTimeKind.Local).AddTicks(8768));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 12, 8, 0, 30, 15, 158, DateTimeKind.Local).AddTicks(6957));
        }
    }
}
