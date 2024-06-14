using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmMoi.Domain.Migrations
{
    /// <inheritdoc />
    public partial class _5_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("6d2b7703-081a-4355-a1ef-5adf9c2ba9ce"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("8a1b29ec-b125-4d26-a4ad-d710ff3122f5"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("452a20da-ceb1-4bc6-a7d4-cfaa3ce32386"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("d04d492e-d1ad-42d0-83fa-45a62d562909"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("a50f6fa6-1e4f-48c6-bf6d-0f6f93771cbb"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("f3a809ce-6dd0-47ca-a374-1122bedf7abd"));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 13, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 13, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 13, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("a6d64173-e859-4e44-9557-e05d4af0ed93"), null, new DateTimeOffset(new DateTime(2024, 6, 5, 13, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("c5ef3028-9f11-4bc1-b8ad-f03b9af8a2cd"), null, new DateTimeOffset(new DateTime(2024, 6, 5, 13, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("dfe47685-60bf-4109-92ec-8827fd17efde"), null, new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5364), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("eaf061a9-b5c7-4a23-bf27-5015873389be"), null, new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("14d4a2a7-878c-46e2-8f19-9b564349b769"), null, new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5385), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ad22806c-ebf4-447f-8f08-2d2e75f51a38"), null, new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5390), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5303), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 5, 6, 11, 14, 905, DateTimeKind.Unspecified).AddTicks(5339), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("a6d64173-e859-4e44-9557-e05d4af0ed93"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("c5ef3028-9f11-4bc1-b8ad-f03b9af8a2cd"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("dfe47685-60bf-4109-92ec-8827fd17efde"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("eaf061a9-b5c7-4a23-bf27-5015873389be"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("14d4a2a7-878c-46e2-8f19-9b564349b769"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("ad22806c-ebf4-447f-8f08-2d2e75f51a38"));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 13, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2722), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 13, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2763), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 13, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("6d2b7703-081a-4355-a1ef-5adf9c2ba9ce"), null, new DateTimeOffset(new DateTime(2024, 5, 16, 13, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2785), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" },
                    { new Guid("8a1b29ec-b125-4d26-a4ad-d710ff3122f5"), null, new DateTimeOffset(new DateTime(2024, 5, 16, 13, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2788), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("452a20da-ceb1-4bc6-a7d4-cfaa3ce32386"), null, new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2918), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d04d492e-d1ad-42d0-83fa-45a62d562909"), null, new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2922), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2832), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("a50f6fa6-1e4f-48c6-bf6d-0f6f93771cbb"), null, new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2945), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f3a809ce-6dd0-47ca-a374-1122bedf7abd"), null, new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2941), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2865), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2873), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 16, 6, 41, 7, 357, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
