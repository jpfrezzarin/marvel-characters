using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarvelCharacters.Data.Migrations
{
    public partial class Comics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Modified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterComics",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    ComicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterComics", x => new { x.CharacterId, x.ComicId });
                    table.ForeignKey(
                        name: "FK_CharacterComics_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterComics_Comics_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 16, 20, 39, 520, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 16, 20, 39, 521, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 16, 20, 39, 521, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 16, 20, 39, 521, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "Description", "Modified", "Title" },
                values: new object[,]
                {
                    { 1, "The Amazing Spider-Man is an American comic book series published by Marvel Comics, featuring the fictional superhero Spider-Man as its main protagonist. Being in the mainstream continuity of the franchise, it began publication in 1963 as a monthly periodical and was published continuously, with a brief interruption in 1995, until its relaunch with a new numbering order in 1999. In 2003 the series reverted to the numbering order of the first volume.", new DateTime(2020, 2, 2, 16, 20, 39, 522, DateTimeKind.Local).AddTicks(5120), "The Amazing Spider-Man" },
                    { 2, "The Avengers are a fictional team of superheroes appearing in American comic books published by Marvel Comics. The team made its debut in The Avengers #1 (cover-dated Sept. 1963), created by writer-editor Stan Lee and artist/co-plotter Jack Kirby. The Avengers is Lee and Kirby's renovation of a previous superhero team, All-Winners Squad, who appeared in comic books series published by Marvel Comics' predecessor Timely Comics.", new DateTime(2020, 2, 2, 16, 20, 39, 522, DateTimeKind.Local).AddTicks(5631), "The Avengers" }
                });

            migrationBuilder.InsertData(
                table: "CharacterComics",
                columns: new[] { "CharacterId", "ComicId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterComics_ComicId",
                table: "CharacterComics",
                column: "ComicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterComics");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 11, 41, 49, 628, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 11, 41, 49, 629, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 11, 41, 49, 629, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4,
                column: "Modified",
                value: new DateTime(2020, 2, 2, 11, 41, 49, 629, DateTimeKind.Local).AddTicks(2919));
        }
    }
}
