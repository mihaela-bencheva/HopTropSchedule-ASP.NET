using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.DataConnection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanceCloths",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ClothType = table.Column<string>(nullable: true),
                    ShoesType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanceCloths", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DanceGroups",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    DanceGroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanceGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DanceSongs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SongName = table.Column<string>(nullable: true),
                    SongUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanceSongs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FolkDances",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FolkDanceName = table.Column<string>(nullable: true),
                    FolkDanceSize = table.Column<string>(nullable: true),
                    FolkDanceRegion = table.Column<string>(nullable: true),
                    DanceClothId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolkDances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FolkDances_DanceCloths_DanceClothId",
                        column: x => x.DanceClothId,
                        principalTable: "DanceCloths",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    DanceGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_DanceGroups_DanceGroupId",
                        column: x => x.DanceGroupId,
                        principalTable: "DanceGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PracticeSchedules",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    DayName = table.Column<string>(nullable: true),
                    PracticeTime = table.Column<string>(nullable: true),
                    DanceGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeSchedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PracticeSchedules_DanceGroups_DanceGroupId",
                        column: x => x.DanceGroupId,
                        principalTable: "DanceGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    DanceGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_DanceGroups_DanceGroupId",
                        column: x => x.DanceGroupId,
                        principalTable: "DanceGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanceGroupFolkDances",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    DanceGroupId = table.Column<string>(nullable: true),
                    FolkDanceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanceGroupFolkDances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DanceGroupFolkDances_DanceGroups_DanceGroupId",
                        column: x => x.DanceGroupId,
                        principalTable: "DanceGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanceGroupFolkDances_FolkDances_FolkDanceId",
                        column: x => x.FolkDanceId,
                        principalTable: "FolkDances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FolkDanceSong",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FolkDanceId = table.Column<string>(nullable: true),
                    DanceSongId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolkDanceSong", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FolkDanceSong_DanceSongs_DanceSongId",
                        column: x => x.DanceSongId,
                        principalTable: "DanceSongs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FolkDanceSong_FolkDances_FolkDanceId",
                        column: x => x.FolkDanceId,
                        principalTable: "FolkDances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanceGroupFolkDances_DanceGroupId",
                table: "DanceGroupFolkDances",
                column: "DanceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DanceGroupFolkDances_FolkDanceId",
                table: "DanceGroupFolkDances",
                column: "FolkDanceId");

            migrationBuilder.CreateIndex(
                name: "IX_FolkDances_DanceClothId",
                table: "FolkDances",
                column: "DanceClothId",
                unique: true,
                filter: "[DanceClothId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FolkDanceSong_DanceSongId",
                table: "FolkDanceSong",
                column: "DanceSongId");

            migrationBuilder.CreateIndex(
                name: "IX_FolkDanceSong_FolkDanceId",
                table: "FolkDanceSong",
                column: "FolkDanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_DanceGroupId",
                table: "Images",
                column: "DanceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticeSchedules_DanceGroupId",
                table: "PracticeSchedules",
                column: "DanceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DanceGroupId",
                table: "Users",
                column: "DanceGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanceGroupFolkDances");

            migrationBuilder.DropTable(
                name: "FolkDanceSong");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "PracticeSchedules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DanceSongs");

            migrationBuilder.DropTable(
                name: "FolkDances");

            migrationBuilder.DropTable(
                name: "DanceGroups");

            migrationBuilder.DropTable(
                name: "DanceCloths");
        }
    }
}
