using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OurTravel.API.Migrations
{
    /// <inheritdoc />
    public partial class relatingCityPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "interestedPlaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_interestedPlaces_CityId",
                table: "interestedPlaces",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_interestedPlaces_Cities_CityId",
                table: "interestedPlaces",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_interestedPlaces_Cities_CityId",
                table: "interestedPlaces");

            migrationBuilder.DropIndex(
                name: "IX_interestedPlaces_CityId",
                table: "interestedPlaces");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "interestedPlaces");
        }
    }
}
