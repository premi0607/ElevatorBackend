using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElevatorTransaction.Migrations
{
    /// <inheritdoc />
    public partial class updateclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PersonWeight",
                table: "Transactions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonWeight",
                table: "Transactions");
        }
    }
}
