using Microsoft.EntityFrameworkCore.Migrations;

namespace popcornLK.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "C_Email",
                table: "Customers",
                newName: "C_email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "C_email",
                table: "Customers",
                newName: "C_Email");
        }
    }
}
