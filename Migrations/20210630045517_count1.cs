using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVotingApp.Migrations
{
    public partial class count1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VotingCount",
                table: "VotingCount");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "VotingCount");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "VotingCount",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VotingCount",
                table: "VotingCount",
                column: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VotingCount",
                table: "VotingCount");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "VotingCount",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "VotingCount",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VotingCount",
                table: "VotingCount",
                column: "ID");
        }
    }
}
