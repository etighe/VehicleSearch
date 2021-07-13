using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLib.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    _id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<short>(type: "smallint", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    hasSunroof = table.Column<bool>(type: "bit", nullable: false),
                    isFourWheelDrive = table.Column<bool>(type: "bit", nullable: false),
                    hasLowMiles = table.Column<bool>(type: "bit", nullable: false),
                    hasPowerWindows = table.Column<bool>(type: "bit", nullable: false),
                    hasNavigation = table.Column<bool>(type: "bit", nullable: false),
                    hasHeatedSeats = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x._id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
