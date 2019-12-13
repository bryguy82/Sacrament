using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament.Migrations
{
    public partial class multiplespeakershymnnumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "HymnNum",
                table: "Hymn");

            migrationBuilder.AddColumn<string>(
                name: "FirstName_1",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName_2",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName_3",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName_4",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName_1",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName_2",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName_3",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName_4",
                table: "Speaker",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Hymn_1Num",
                table: "Hymn",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hymn_2Num",
                table: "Hymn",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hymn_3Num",
                table: "Hymn",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hymn_4Num",
                table: "Hymn",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName_1",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "FirstName_2",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "FirstName_3",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "FirstName_4",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastName_1",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastName_2",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastName_3",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastName_4",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "Hymn_1Num",
                table: "Hymn");

            migrationBuilder.DropColumn(
                name: "Hymn_2Num",
                table: "Hymn");

            migrationBuilder.DropColumn(
                name: "Hymn_3Num",
                table: "Hymn");

            migrationBuilder.DropColumn(
                name: "Hymn_4Num",
                table: "Hymn");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Speaker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Speaker",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HymnNum",
                table: "Hymn",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
