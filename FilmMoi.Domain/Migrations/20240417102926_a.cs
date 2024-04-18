using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmMoi.Domain.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvgDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalEpisode = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Film_Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Episodes_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmActors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_ACtor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FilmActors_Actors_ID_ACtor",
                        column: x => x.ID_ACtor,
                        principalTable: "Actors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActors_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreFilms",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Genre = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreFilms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GenreFilms_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreFilms_Genres_ID_Genre",
                        column: x => x.ID_Genre,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_ID_User",
                        column: x => x.ID_User,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => new { x.ID_User, x.ID_Film });
                    table.ForeignKey(
                        name: "FK_Ratings_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_ID_User",
                        column: x => x.ID_User,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchedFilms",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentPosition = table.Column<TimeSpan>(type: "time", nullable: false),
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Film = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchedFilms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WatchedFilms_Films_ID_Film",
                        column: x => x.ID_Film,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchedFilms_Users_ID_User",
                        column: x => x.ID_User,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("25801504-21c3-4ec1-9f4c-2a9941b5688e"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor1.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Kirigaya Kazuto", "Japan" },
                    { new Guid("794b3996-aac6-437e-87c6-197fde46149d"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3993), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor2.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Asuna Yuuki", "Japan" },
                    { new Guid("e4e55994-0c7d-44ec-b033-337c95797d35"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3999), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" },
                    { new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor3.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Levi Ackerman", "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "AvgDuration", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Director", "Image", "ModifiedBy", "ModifiedTime", "Name", "Status", "TotalEpisode", "Year" },
                values: new object[,]
                {
                    { new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Christopher Nolan", "film5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "The Dark Knight", 1, 0, 2024 },
                    { new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Quentin Tarantino", "film4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Pulp Fiction", 1, 0, 2024 },
                    { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4039), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Anime cute", "Reki Kawahara", "film1.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Sword Art Online", 1, 0, 2024 },
                    { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Frank Darabont", "film2.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "The Shawshank Redemption", 1, 0, 2024 },
                    { new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Christopher Nolan", "film3.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Inception", 1, 0, 2024 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Korea", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Romantic", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4097), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Anime", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Action", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a040eef1-1d71-437e-ac64-e94d0b65c856"), "92ed2915-6aa0-4a86-8e7a-8f828d8d9e1f", "Client", "CLIENT" },
                    { new Guid("a884280c-dd19-4022-85bd-7105c59b27f9"), "f6b25b9e-5ef2-4aaf-9e9b-7ae4fdac2e2b", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("142afd15-5af3-4856-bb98-c271a0320318"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4167), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fdd7731e-56c5-4dd2-a1d6-c11d9bc0e917"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("4a58988c-86a0-4de5-93c5-605b22dde61f"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4206), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("988a90ec-31a6-4c82-a20b-76d62b6e6cb9"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("84f0e463-e887-4143-a994-61ca73c4793c"), 0, "92ed2915-6aa0-4a86-8e7a-8f828d8d9e1f", "thend@gmail.com", true, true, null, "THEND@GMAIL.COM", "THEND", "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", "987654321", true, new Guid("a884280c-dd19-4022-85bd-7105c59b27f9"), "7S43J6OZ5E3H3Z2M3I2P8X7R7U5W2E7B", false, "thend" },
                    { new Guid("e24d664c-e45f-4ddb-8743-04812e1ca9f5"), 0, "f6b25b9e-5ef2-4aaf-9e9b-7ae4fdac2e2b", "dangs3007@gmail.com", true, true, null, "DANGS3007@GMAIL.COM", "DANGS", "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", "123456789", true, new Guid("a884280c-dd19-4022-85bd-7105c59b27f9"), "XQYOWUD3KZAC3K6A3OJ3M7NJI3J4D7YX", false, "dangs" },
                    { new Guid("f69cd789-4c44-401c-a021-5b6742af2279"), 0, "7d1c77f2-9b7e-4f5d-b0e6-3d13c7a4cc09", "dangs123@gmail.com", true, true, null, "DANGS123@GMAIL.COM", "CLIENTEST", "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", "123456789", true, new Guid("a040eef1-1d71-437e-ac64-e94d0b65c856"), "4b051b8e-4b64-4a2a-94e6-3f8a3b43b2c7", false, "clienttest" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "ID_Film", "ID_User", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Rating" },
                values: new object[,]
                {
                    { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 },
                    { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ID_Film",
                table: "Comments",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ID_User",
                table: "Comments",
                column: "ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_ID_Film",
                table: "Episodes",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActors_ID_ACtor",
                table: "FilmActors",
                column: "ID_ACtor");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActors_ID_Film",
                table: "FilmActors",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_GenreFilms_ID_Film",
                table: "GenreFilms",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_GenreFilms_ID_Genre",
                table: "GenreFilms",
                column: "ID_Genre");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ID_Film",
                table: "Ratings",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchedFilms_ID_Film",
                table: "WatchedFilms",
                column: "ID_Film");

            migrationBuilder.CreateIndex(
                name: "IX_WatchedFilms_ID_User",
                table: "WatchedFilms",
                column: "ID_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "FilmActors");

            migrationBuilder.DropTable(
                name: "GenreFilms");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "WatchedFilms");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
