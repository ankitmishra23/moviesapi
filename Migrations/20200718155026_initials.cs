using Microsoft.EntityFrameworkCore.Migrations;

namespace weekendtask.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    languageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.languageId);
                });

            migrationBuilder.CreateTable(
                name: "MyReviews",
                columns: table => new
                {
                    reviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reviews = table.Column<string>(nullable: true),
                    movieName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyReviews", x => x.reviewId);
                });

            migrationBuilder.CreateTable(
                name: "MyMovies",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieName = table.Column<string>(nullable: true),
                    languageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyMovies", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_MyMovies_Languages_languageId",
                        column: x => x.languageId,
                        principalTable: "Languages",
                        principalColumn: "languageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyMovies_languageId",
                table: "MyMovies",
                column: "languageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyMovies");

            migrationBuilder.DropTable(
                name: "MyReviews");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
