using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNetCore3API.Migrations
{
    public partial class UserCreationDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 14, 48, 51, 105, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 8, 14, 48, 51, 109, DateTimeKind.Local).AddTicks(1627));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "User");
        }
    }
}
