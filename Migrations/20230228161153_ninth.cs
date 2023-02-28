using Microsoft.EntityFrameworkCore.Migrations;

namespace popcornLK.Migrations
{
    public partial class ninth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "M_ID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieM_ID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_Tickets_MovieM_ID",
                table: "Tickets",
                column: "MovieM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_BelongsToM_ID",
                table: "GenreMovie",
                column: "BelongsToM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Movies_MovieM_ID",
                table: "Tickets",
                column: "MovieM_ID",
                principalTable: "Movies",
                principalColumn: "M_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Movies_MovieM_ID",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_MovieM_ID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "M_ID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "MovieM_ID",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "Movies",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
