using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppConcertTicket.Migrations
{
    /// <inheritdoc />
    public partial class FixTicketForeignKeyNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustAccountId",
                table: "Tickets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustAccountId",
                table: "Tickets",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
