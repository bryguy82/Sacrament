using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament.Migrations
{
    public partial class topics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Topic_1",
                table: "Meeting",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic_2",
                table: "Meeting",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic_3",
                table: "Meeting",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic_4",
                table: "Meeting",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topic_1",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Topic_2",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Topic_3",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Topic_4",
                table: "Meeting");
        }
    }
}
