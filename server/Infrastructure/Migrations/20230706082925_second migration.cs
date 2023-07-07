using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6747), 1000, new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6752), 2000, new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6753), 2400, new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "DetailName", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6760), "Televisor SONY 65\"", 3000, new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6763), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 7, 6, 3, 29, 25, 705, DateTimeKind.Local).AddTicks(6766) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3096), 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3100), 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3101), 949, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3105), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "DetailName", "Price", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3107), "Televisor LG 65\"", 1549, new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 7, 5, 20, 56, 50, 717, DateTimeKind.Local).AddTicks(3113) });
        }
    }
}
