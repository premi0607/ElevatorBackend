using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElevatorTransaction.Migrations
{
    /// <inheritdoc />
    public partial class AddedTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "TransactionDateOnly",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionTimeOnly",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDateOnly",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransactionTimeOnly",
                table: "Transactions");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
