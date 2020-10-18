using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAssessment.Users.Migrations
{
    public partial class newcoloum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyType",
                table: "Log_Requests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyType",
                table: "Log_Requests");
        }
    }
}
