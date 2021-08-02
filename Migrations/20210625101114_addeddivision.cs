using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVotingApp.Migrations
{
    public partial class addeddivision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DivisionName",
                table: "PartyCandidateDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DivisionName",
                table: "PartyCandidateDetails");
        }
    }
}
