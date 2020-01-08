using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNetCore3API.Migrations
{
    public partial class PhoneIncreaseLength2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 15, 30, 56, 73, DateTimeKind.Local).AddTicks(522),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 1, 8, 15, 28, 14, 959, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 15, 30, 56, 69, DateTimeKind.Local).AddTicks(9702),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 1, 8, 15, 28, 14, 956, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Business",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(12) CHARACTER SET utf8mb4",
                oldMaxLength: 12,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 15, 28, 14, 959, DateTimeKind.Local).AddTicks(8116),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 8, 15, 30, 56, 73, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 15, 28, 14, 956, DateTimeKind.Local).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 8, 15, 30, 56, 69, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Business",
                type: "varchar(12) CHARACTER SET utf8mb4",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 16,
                oldNullable: true);
        }
    }
}
