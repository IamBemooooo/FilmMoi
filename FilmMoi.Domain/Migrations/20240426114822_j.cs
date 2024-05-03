using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmMoi.Domain.Migrations
{
    /// <inheritdoc />
    public partial class j : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("25801504-21c3-4ec1-9f4c-2a9941b5688e"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e4e55994-0c7d-44ec-b033-337c95797d35"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("142afd15-5af3-4856-bb98-c271a0320318"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("fdd7731e-56c5-4dd2-a1d6-c11d9bc0e917"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("4a58988c-86a0-4de5-93c5-605b22dde61f"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("988a90ec-31a6-4c82-a20b-76d62b6e6cb9"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedTime",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedTime",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 18, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 18, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 18, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4437), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("21d7541c-7ed7-4388-b463-721965ec72ea"), null, new DateTimeOffset(new DateTime(2024, 4, 26, 18, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4441), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("576ab4b8-cd6a-438d-8ca8-f050a9188ed3"), null, new DateTimeOffset(new DateTime(2024, 4, 26, 18, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4439), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("7af6c6c3-a82a-4f88-a051-b8c52e08c0f8"), null, new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4619), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e62fd638-67a2-4d6f-a6a4-f5a7ac7ee5d6"), null, new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("8f4f8bf5-189e-4e53-a3c8-c44ee5343b38"), null, new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f6679613-c9eb-40ea-b9bd-da641b88ef50"), null, new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4648), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4555), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4538), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 26, 11, 48, 22, 400, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84f0e463-e887-4143-a994-61ca73c4793c"),
                columns: new[] { "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e24d664c-e45f-4ddb-8743-04812e1ca9f5"),
                columns: new[] { "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f69cd789-4c44-401c-a021-5b6742af2279"),
                columns: new[] { "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("21d7541c-7ed7-4388-b463-721965ec72ea"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("576ab4b8-cd6a-438d-8ca8-f050a9188ed3"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("7af6c6c3-a82a-4f88-a051-b8c52e08c0f8"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("e62fd638-67a2-4d6f-a6a4-f5a7ac7ee5d6"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("8f4f8bf5-189e-4e53-a3c8-c44ee5343b38"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("f6679613-c9eb-40ea-b9bd-da641b88ef50"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3993), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("25801504-21c3-4ec1-9f4c-2a9941b5688e"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("e4e55994-0c7d-44ec-b033-337c95797d35"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 17, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(3999), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("142afd15-5af3-4856-bb98-c271a0320318"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4167), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fdd7731e-56c5-4dd2-a1d6-c11d9bc0e917"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4039), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("4a58988c-86a0-4de5-93c5-605b22dde61f"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4206), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("988a90ec-31a6-4c82-a20b-76d62b6e6cb9"), null, new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4097), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 4, 17, 10, 29, 26, 441, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
