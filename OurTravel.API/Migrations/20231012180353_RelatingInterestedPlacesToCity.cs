using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OurTravel.API.Migrations
{
    /// <inheritdoc />
    public partial class RelatingInterestedPlacesToCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GalleryInterestedPlace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterestedPlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryInterestedPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryInterestedPlace_interestedPlaces_InterestedPlaceId",
                        column: x => x.InterestedPlaceId,
                        principalTable: "interestedPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryInterestedPlace_InterestedPlaceId",
                table: "GalleryInterestedPlace",
                column: "InterestedPlaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryInterestedPlace");
        }
    }
}
