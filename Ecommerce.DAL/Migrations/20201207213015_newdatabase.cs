using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Ecommerce.DAL.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    BrandName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "ActivationCode", "Address", "BirthDate", "City", "Country", "CreatedDate", "Email", "FirstName", "IsActive", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { 1, new Guid("00000000-0000-0000-0000-000000000000"), "Maltepe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2020, 12, 8, 0, 30, 15, 158, DateTimeKind.Local).AddTicks(6957), "bilal.kirkgul@gmail.com", "Bilal", true, "Kırkgül", "123", null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandID",
                table: "Product",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandID",
                table: "Product",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandID",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Product_BrandID",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }
    }
}
