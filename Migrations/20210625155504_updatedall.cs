using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVotingApp.Migrations
{
    public partial class updatedall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadharId",
                table: "CandidateRegistration");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AadharDB");

            migrationBuilder.AddColumn<double>(
                name: "AadharNumber",
                table: "CandidateRegistration",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CandidateRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "CandidateRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "CandidateRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "AadharNumber",
                table: "AadharDB",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AadharDB",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadharNumber",
                table: "CandidateRegistration");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CandidateRegistration");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "CandidateRegistration");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "CandidateRegistration");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AadharDB");

            migrationBuilder.AddColumn<int>(
                name: "AadharId",
                table: "CandidateRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AadharNumber",
                table: "AadharDB",
                type: "float",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AadharDB",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
