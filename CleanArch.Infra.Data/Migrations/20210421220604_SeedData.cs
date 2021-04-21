using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "Id", "Artist", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Leonardo Da Vinci", "Mona Lisa", "1503" },
                    { 2, "Johannes Vermeer", "Girl with a Pealr Earring", "1665" },
                    { 3, "Michelangelo", "David", "1501" },
                    { 4, "Banksy", "Love is in the Bin", "2006" },
                    { 5, "Vincent van Gogh", "The Starry Night", "1889" },
                    { 6, "Auguste Rodin", "The Thinker", "1880" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
