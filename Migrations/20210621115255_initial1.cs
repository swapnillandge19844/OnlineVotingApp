using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVotingApp.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "CandidateRegistration");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "CandidateRegistration");

            migrationBuilder.AddColumn<int>(
                name: "VoterId",
                table: "CandidateRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoterId",
                table: "CandidateRegistration");

            migrationBuilder.AddColumn<string>(
                name: "LoginId",
                table: "CandidateRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "CandidateRegistration",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
