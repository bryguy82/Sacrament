using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament.Migrations
{
    public partial class initialmigration : Migration
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
                    HymnId = table.Column<int>(nullable: true),
                    SpeakerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HymnNum = table.Column<int>(nullable: false),
                    Hymn_1 = table.Column<string>(maxLength: 50, nullable: false),
                    Hymn_2 = table.Column<string>(maxLength: 50, nullable: false),
                    Hymn_3 = table.Column<string>(maxLength: 50, nullable: true),
                    Hymn_4 = table.Column<string>(maxLength: 50, nullable: false),
                    MeetingID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnId);
                    table.ForeignKey(
                        name: "FK_Hymn_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    TopicId = table.Column<int>(nullable: true),
                    MeetingID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speaker_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    TopicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(maxLength: 50, nullable: false),
                    SpeakerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.TopicId);
                    table.ForeignKey(
                        name: "FK_Topic_Speaker_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speaker",
                        principalColumn: "SpeakerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hymn_MeetingID",
                table: "Hymn",
                column: "MeetingID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_HymnId",
                table: "Meeting",
                column: "HymnId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SpeakerId",
                table: "Meeting",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingID",
                table: "Speaker",
                column: "MeetingID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_TopicId",
                table: "Speaker",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_SpeakerId",
                table: "Topic",
                column: "SpeakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Hymn_HymnId",
                table: "Meeting",
                column: "HymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Speaker_SpeakerId",
                table: "Meeting",
                column: "SpeakerId",
                principalTable: "Speaker",
                principalColumn: "SpeakerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Speaker_Topic_TopicId",
                table: "Speaker",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hymn_Meeting_MeetingID",
                table: "Hymn");

            migrationBuilder.DropForeignKey(
                name: "FK_Speaker_Meeting_MeetingID",
                table: "Speaker");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Speaker_SpeakerId",
                table: "Topic");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
