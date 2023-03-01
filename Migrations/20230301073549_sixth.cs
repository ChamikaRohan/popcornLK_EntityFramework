using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopcornEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "C_Age",
                table: "Customers",
                newName: "C_age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "C_age",
                table: "Customers",
                newName: "C_Age");
        }
    }
}
