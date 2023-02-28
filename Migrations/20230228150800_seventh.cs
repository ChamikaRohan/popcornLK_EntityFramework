using Microsoft.EntityFrameworkCore.Migrations;

namespace popcornLK.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "C_email",
                table: "Customers",
                newName: "C_Email");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNIC",
                table: "Tickets",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerNIC",
                table: "Tickets",
                column: "CustomerNIC");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Customers_CustomerNIC",
                table: "Tickets",
                column: "CustomerNIC",
                principalTable: "Customers",
                principalColumn: "NIC",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Customers_CustomerNIC",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_CustomerNIC",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CustomerNIC",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "C_Email",
                table: "Customers",
                newName: "C_email");
        }
    }
}
