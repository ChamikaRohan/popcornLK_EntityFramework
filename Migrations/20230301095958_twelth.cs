using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopcornEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class twelth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.AddColumn<int>(
                name: "MovieM_ID",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieM_ID",
                table: "Genres",
                column: "MovieM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Movies_MovieM_ID",
                table: "Genres",
                column: "MovieM_ID",
                principalTable: "Movies",
                principalColumn: "M_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Movies_MovieM_ID",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MovieM_ID",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MovieM_ID",
                table: "Genres");

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    BelongsToGenre_ID = table.Column<int>(type: "int", nullable: false),
                    BelongsToM_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.BelongsToGenre_ID, x.BelongsToM_ID });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_BelongsToGenre_ID",
                        column: x => x.BelongsToGenre_ID,
                        principalTable: "Genres",
                        principalColumn: "Genre_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_BelongsToM_ID",
                        column: x => x.BelongsToM_ID,
                        principalTable: "Movies",
                        principalColumn: "M_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_BelongsToM_ID",
                table: "GenreMovie",
                column: "BelongsToM_ID");
        }
    }
}
