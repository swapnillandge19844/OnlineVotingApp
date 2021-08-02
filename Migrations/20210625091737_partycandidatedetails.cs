using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVotingApp.Migrations
{
    public partial class partycandidatedetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartyCandidateDetails",
                columns: table => new
                {
                    PartyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyCandidateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Party = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyCandidateDetails", x => x.PartyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartyCandidateDetails");
        }
    }
}
