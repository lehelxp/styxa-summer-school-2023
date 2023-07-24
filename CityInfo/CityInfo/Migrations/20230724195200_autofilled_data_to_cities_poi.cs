using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.Migrations
{
    public partial class autofilled_data_to_cities_poi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Area", "MapsURL", "Population" },
                values: new object[] { 1223, "https://goo.gl/maps/yTTiy8L1FjhYhK3i8", 7888121 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "MapsURL", "Population" },
                values: new object[] { 204, "https://goo.gl/maps/RubRthrVoynjvyTi9", 536079 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "MapsURL", "Population" },
                values: new object[] { 105, "https://goo.gl/maps/tZ2zjTmQDwNb1x5R9", 2102650 });

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 1,
                column: "MapsURL",
                value: "https://goo.gl/maps/ZfXi1UjzE1DovGFS9");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "MapsURL",
                value: "https://goo.gl/maps/RhLeHfoo3U4KMEsy6");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 3,
                column: "MapsURL",
                value: "https://goo.gl/maps/7G37THFH52KMB2WL7");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 4,
                column: "MapsURL",
                value: "https://goo.gl/maps/bpcT8jx9yuVjd8Z5A");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 5,
                column: "MapsURL",
                value: "https://goo.gl/maps/a3yoLH55VhV4uk7LA");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "MapsURL",
                value: "https://goo.gl/maps/VbPUHpf3RJbA1Znj7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Area", "MapsURL", "Population" },
                values: new object[] { 0, null, 0 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "MapsURL", "Population" },
                values: new object[] { 0, null, 0 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "MapsURL", "Population" },
                values: new object[] { 0, null, 0 });

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 1,
                column: "MapsURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "MapsURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 3,
                column: "MapsURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 4,
                column: "MapsURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 5,
                column: "MapsURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "MapsURL",
                value: null);
        }
    }
}
