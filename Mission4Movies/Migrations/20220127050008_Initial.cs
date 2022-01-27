using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4Movies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Sci-Fi Thriller", "Christpoher Nolan", false, "", "Top 10", "PG-13", "Interstellar", 2015 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "French Musical Drama", "Jacques Demy", false, "Keanna", "Top 5", "PG", "Umbrellas of Cherbourg", 1964 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Bibliographical Musical Drama", "Lin-Manuel Miranda", false, "", "Top 20", "UR", "Tick, Tick... Boom!", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
