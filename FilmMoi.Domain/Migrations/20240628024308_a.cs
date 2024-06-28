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
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
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
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.LoginProvider, x.UserId });
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
                    ConfirmCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    { new Guid("499b6c60-3a50-40c3-a33a-e8e4022a1eef"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3367), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" },
                    { new Guid("6b2e7a56-27ff-4b2c-b2ad-98814457e6ee"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3316), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor1.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Kirigaya Kazuto", "Japan" },
                    { new Guid("794b3996-aac6-437e-87c6-197fde46149d"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3361), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor2.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Asuna Yuuki", "Japan" },
                    { new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3364), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor3.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Levi Ackerman", "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "AvgDuration", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Director", "Image", "ModifiedBy", "ModifiedTime", "Name", "Status", "TotalEpisode", "Year" },
                values: new object[,]
                {
                    { new Guid("030d330d-5ad2-4a28-b122-c3222383562a"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director20", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film20", 1, 0, 2024 },
                    { new Guid("085fc35f-e453-4ba0-8b0e-e85f96d7e91c"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director12", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film12", 1, 0, 2024 },
                    { new Guid("0c85a87c-477e-450d-9e1e-b9bf0aa05135"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director0", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film0", 1, 0, 2024 },
                    { new Guid("2792b5f7-9cd8-48cb-b6bd-677c169f9f79"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director7", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film7", 1, 0, 2024 },
                    { new Guid("36874110-a8bf-4cc8-9b56-6e1c6edd0639"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director21", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film21", 1, 0, 2024 },
                    { new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3437), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Christopher Nolan", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "The Dark Knight", 1, 0, 2024 },
                    { new Guid("3f4ccf01-5f75-4198-a5b1-2ec3cdda2399"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director10", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film10", 1, 0, 2024 },
                    { new Guid("4026f57c-726c-44e7-a050-b66136027d2b"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director23", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film23", 1, 0, 2024 },
                    { new Guid("4a75beee-5a3b-47e9-9b62-38a97b4e4605"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director3", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film3", 1, 0, 2024 },
                    { new Guid("72db7e1e-3c9b-4f0f-932b-dc1dbbb2b635"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3576), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director1", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film1", 1, 0, 2024 },
                    { new Guid("7349d68f-2be4-4e98-8082-52b3e28d035d"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3744), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director28", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film28", 1, 0, 2024 },
                    { new Guid("7ad492bb-44c1-4ad6-99dd-9a15718322fe"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director16", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film16", 1, 0, 2024 },
                    { new Guid("7b5650c7-484e-4d18-b5ca-46648ce30eed"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director8", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film8", 1, 0, 2024 },
                    { new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3433), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Quentin Tarantino", "series-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Pulp Fiction", 1, 0, 2024 },
                    { new Guid("8441cec9-5153-4b7e-a768-4f004d23b569"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3681), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director17", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film17", 1, 0, 2024 },
                    { new Guid("90f2997f-668a-486c-994a-926df3ad1459"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director13", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film13", 1, 0, 2024 },
                    { new Guid("95f17636-2156-4962-86cb-cb58153191e2"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3635), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director9", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film9", 1, 0, 2024 },
                    { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3409), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Anime cute", "Reki Kawahara", "series-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Sword Art Online", 1, 0, 2024 },
                    { new Guid("99215d8c-cd9d-4f0a-b039-dfed1bef0bca"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director27", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film27", 1, 0, 2024 },
                    { new Guid("a0f054ad-73a4-44d5-a31d-5cc30d9a99ba"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director18", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film18", 1, 0, 2024 },
                    { new Guid("afe6b966-11f3-447c-9cda-e476b5349790"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director6", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film6", 1, 0, 2024 },
                    { new Guid("bb6a2ac9-39a2-4449-a10f-2742918b78fc"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director29", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film29", 1, 0, 2024 },
                    { new Guid("be5e1ab1-9cd3-44df-920b-f8c160edde93"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3733), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director26", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film26", 1, 0, 2024 },
                    { new Guid("bf101e80-82ad-42a1-8de3-184839701042"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3668), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director15", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film15", 1, 0, 2024 },
                    { new Guid("bf73398f-dc47-4a67-895b-110e7115a9bf"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director25", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film25", 1, 0, 2024 },
                    { new Guid("c09ad538-55d2-4b71-9cfa-199e4478d564"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3603), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director4", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film4", 1, 0, 2024 },
                    { new Guid("c7bc5400-9477-4509-b545-c9db4419163f"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3609), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director5", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film5", 1, 0, 2024 },
                    { new Guid("d19cbe13-eedf-4f12-a3d3-e0e59515c07d"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3722), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director24", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film24", 1, 0, 2024 },
                    { new Guid("d3d734e4-68f4-40c0-98d2-341a2eff9319"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director2", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film2", 1, 0, 2024 },
                    { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3424), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Frank Darabont", "series-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "The Shawshank Redemption", 1, 0, 2024 },
                    { new Guid("e230a376-a72e-47fc-94db-27870f3ee481"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director19", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film19", 1, 0, 2024 },
                    { new Guid("e6f3786e-cf89-49a4-b3ad-49c002f312d3"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director14", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film14", 1, 0, 2024 },
                    { new Guid("eabda0cf-ca91-418b-8b37-2886394af522"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director22", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film22", 1, 0, 2024 },
                    { new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3428), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Christopher Nolan", "series-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Inception", 1, 0, 2024 },
                    { new Guid("fb6ce8a4-9042-4a7d-bc61-7acc484120bf"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director11", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film11", 1, 0, 2024 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3789), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Korea", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Romantic", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Anime", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3794), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Action", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
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
                    { new Guid("0c257c82-831d-431e-892e-8e90dc2121aa"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3910), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9ffccfe3-b88d-421e-99a0-5069a2ab1454"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3915), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("8a45c891-f4e1-4bbd-9b36-32ff4249e7f5"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3953), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("af257151-7ee2-4855-892a-0f9f35b2e059"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmCode", "CreatedBy", "CreatedTime", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "SentTime", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("84f0e463-e887-4143-a994-61ca73c4793c"), 0, "92ed2915-6aa0-4a86-8e7a-8f828d8d9e1f", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "thend@gmail.com", true, true, null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "THEND@GMAIL.COM", "THEND", "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", "987654321", true, new Guid("a884280c-dd19-4022-85bd-7105c59b27f9"), "7S43J6OZ5E3H3Z2M3I2P8X7R7U5W2E7B", null, false, "thend" },
                    { new Guid("e24d664c-e45f-4ddb-8743-04812e1ca9f5"), 0, "f6b25b9e-5ef2-4aaf-9e9b-7ae4fdac2e2b", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dangs3007@gmail.com", true, true, null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "DANGS3007@GMAIL.COM", "DANGS", "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", "123456789", true, new Guid("a884280c-dd19-4022-85bd-7105c59b27f9"), "XQYOWUD3KZAC3K6A3OJ3M7NJI3J4D7YX", null, false, "dangs" },
                    { new Guid("f69cd789-4c44-401c-a021-5b6742af2279"), 0, "7d1c77f2-9b7e-4f5d-b0e6-3d13c7a4cc09", null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dangs123@gmail.com", true, true, null, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "DANGS123@GMAIL.COM", "CLIENTEST", "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", "123456789", true, new Guid("a040eef1-1d71-437e-ac64-e94d0b65c856"), "4b051b8e-4b64-4a2a-94e6-3f8a3b43b2c7", null, false, "clienttest" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "ID_Film", "ID_User", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Rating" },
                values: new object[,]
                {
                    { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 },
                    { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 2, 43, 8, 352, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 }
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
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

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
