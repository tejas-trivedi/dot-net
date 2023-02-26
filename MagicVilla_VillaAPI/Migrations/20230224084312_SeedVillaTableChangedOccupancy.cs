using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableChangedOccupancy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Occupancy",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4438), "5" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4453), "5" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4455), "5" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4458), "5" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4460), "5" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4463), "5" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 14, 13, 12, 58, DateTimeKind.Local).AddTicks(4466), "5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Occupancy",
                table: "Villas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(528), 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(544), 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(547), 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(549), 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(552), 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(555), 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Occupancy" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 57, 1, 528, DateTimeKind.Local).AddTicks(557), 5 });
        }
    }
}
