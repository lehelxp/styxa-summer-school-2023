using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.Migrations
{
    public partial class AddGoogleMapsToCitiesPoisAndUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "PointsOfInterest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MapsURL",
                table: "PointsOfInterest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MapsURL",
                table: "Cities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "MapsURL",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "MapsURL",
                table: "Cities");
        }
    }
}
