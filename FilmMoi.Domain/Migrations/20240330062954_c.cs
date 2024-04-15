using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmMoi.Models.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ID_Film",
                table: "WatchedFilms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ID_User",
                table: "WatchedFilms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Operations_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operations_Users_ID_User",
                        column: x => x.ID_User,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WatchedFilms_ID_Film",
                table: "WatchedFilms",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_WatchedFilms_ID_User",
                table: "WatchedFilms",
                column: "ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_ID_Film",
                table: "Operations",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_ID_User",
                table: "Operations",
                column: "ID_User");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchedFilms_Films_ID_Film",
                table: "WatchedFilms",
                column: "ID_Film",
                principalTable: "Films",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchedFilms_Users_ID_User",
                table: "WatchedFilms",
                column: "ID_User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchedFilms_Films_ID_Film",
                table: "WatchedFilms");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchedFilms_Users_ID_User",
                table: "WatchedFilms");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_WatchedFilms_ID_Film",
                table: "WatchedFilms");

            migrationBuilder.DropIndex(
                name: "IX_WatchedFilms_ID_User",
                table: "WatchedFilms");

            migrationBuilder.DropColumn(
                name: "ID_Film",
                table: "WatchedFilms");

            migrationBuilder.DropColumn(
                name: "ID_User",
                table: "WatchedFilms");
        }
    }
}
