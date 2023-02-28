using Microsoft.EntityFrameworkCore.Migrations;

namespace popcornLK.Migrations
{
    public partial class eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comming_Soon",
                table: "Theaters");

            migrationBuilder.DropColumn(
                name: "Now_Showing",
                table: "Theaters");

            migrationBuilder.AddColumn<int>(
                name: "TheaterID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TheaterID",
                table: "Tickets",
                column: "TheaterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Theaters_TheaterID",
                table: "Tickets",
                column: "TheaterID",
                principalTable: "Theaters",
                principalColumn: "T_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Theaters_TheaterID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TheaterID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TheaterID",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "Comming_Soon",
                table: "Theaters",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Now_Showing",
                table: "Theaters",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
