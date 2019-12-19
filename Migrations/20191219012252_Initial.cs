using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preside = table.Column<string>(maxLength: 50, nullable: false),
                    Conduct = table.Column<string>(maxLength: 50, nullable: false),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    OpeningPrayer = table.Column<string>(maxLength: 50, nullable: false),
                    ClosingPrayer = table.Column<string>(maxLength: 50, nullable: false),
                    Hymn_1Num = table.Column<int>(nullable: false),
                    Hymn_1 = table.Column<string>(maxLength: 50, nullable: false),
                    Hymn_2Num = table.Column<int>(nullable: false),
                    Hymn_2 = table.Column<string>(maxLength: 50, nullable: false),
                    Hymn_3Num = table.Column<int>(nullable: true),
                    Hymn_3 = table.Column<string>(maxLength: 50, nullable: true),
                    Hymn_4Num = table.Column<int>(nullable: false),
                    Hymn_4 = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName_1 = table.Column<string>(maxLength: 50, nullable: true),
                    LastName_1 = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName_2 = table.Column<string>(maxLength: 50, nullable: true),
                    LastName_2 = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName_3 = table.Column<string>(maxLength: 50, nullable: true),
                    LastName_3 = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName_4 = table.Column<string>(maxLength: 50, nullable: true),
                    LastName_4 = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
