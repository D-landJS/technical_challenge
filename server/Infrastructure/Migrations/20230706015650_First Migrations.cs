using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandName", "CreateDate", "DetailName", "Price", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "MOTOROLA", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3085), "Celular Motorola Moto G13\"", 500, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3094) },
                    { 2, "LG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3096), "Televisor LG LED 50\"", 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3096) },
                    { 3, "LG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3097), "Televisor LG LED 55\"", 1199, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3098) },
                    { 4, "SAMSUNG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3099), "Celular Samsung Galaxy A24", 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3099) },
                    { 5, "LENOVO", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3100), "Laptop Lenovo IdeaPad Gaming 3i 15.6\"", 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3100) },
                    { 6, "SONY", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3101), "Consola Playstation 5", 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3101) },
                    { 7, "SONY", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3102), "Consola Playstation 4", 1500, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3103) },
                    { 8, "APPLE", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3104), "Phone 13 128GB Azul", 3229, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3104) },
                    { 9, "APPLE", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3105), "Phone 12 128GB Azul", 2999, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3105) },
                    { 10, "APPLE", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3106), "Phone 11 128GB Azul", 1549, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3107) },
                    { 11, "LG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3107), "Televisor LG 65\"", 1549, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3108) },
                    { 12, "APPLE", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3109), "Apple AirPods 3ra Gen", 699, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3109) },
                    { 13, "SAMSUNG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3110), "Celular Samsung Galaxy A73 ", 1699, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3110) },
                    { 14, "LG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3111), "Televisor LG LED 50\"", 999, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3112) },
                    { 15, "LG", new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3112), "Televisor LG LED 60\"", 1899, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3113) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
