using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElevatorTransaction.Migrations
{
    /// <inheritdoc />
    public partial class updatetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LiftConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiftBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiftMaxSpeed = table.Column<int>(type: "int", nullable: false),
                    LiftCapacity = table.Column<int>(type: "int", nullable: false),
                    MaxWeight = table.Column<int>(type: "int", nullable: false),
                    BatteryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatteryLevel = table.Column<int>(type: "int", nullable: false),
                    BatteryCapacity = table.Column<int>(type: "int", nullable: false),
                    PowerConsumed = table.Column<int>(type: "int", nullable: false),
                    DoorOpenCloseSpeed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiftConfiguration", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiftConfiguration");
        }
    }
}
