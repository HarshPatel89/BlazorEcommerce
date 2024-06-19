using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class firstPersistence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 1, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 1, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 1, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedUtc",
                value: new DateTime(2024, 6, 19, 6, 59, 26, 2, DateTimeKind.Utc).AddTicks(547));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 811, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 811, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 811, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedUtc",
                value: new DateTime(2023, 4, 28, 10, 30, 12, 812, DateTimeKind.Utc).AddTicks(112));
        }
    }
}
