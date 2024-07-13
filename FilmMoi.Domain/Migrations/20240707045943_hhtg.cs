using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmMoi.Domain.Migrations
{
    /// <inheritdoc />
    public partial class hhtg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1db6fa81-88d2-46fb-8658-f3e85a3a1052"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("68bae7e1-5703-47b6-98c4-cbddd1376404"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("0f6d5661-ccfe-4796-9895-f3eb11b14d4c"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("fef703d0-4138-491d-9c3d-174d7c56dd64"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("0906787f-1694-4aca-a686-0f081bf0e132"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("1887ee29-d8db-43e1-b28b-923e00b5e9c4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3086e700-aa47-4986-b50e-c1d855527174"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("346bad25-2698-4da2-8cee-ab19b7ab720a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("39463206-5743-4234-bafb-5d6e4ad5dad7"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3bed06cb-73fb-44a6-9131-1c5f91991917"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("483a1a9c-1dcb-40a2-b2bc-2547441bd684"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("55698e40-b5b3-4d6c-9098-03d7bb7c911a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("5c4dd9ca-062b-4fdb-8ab0-e7b7baa8fc35"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("737835dd-de6b-4485-b553-ee15900c8635"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("774d2aac-e9bd-453a-8094-2bf30d63c171"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7d194407-056d-458a-9e4d-472c9f1b7c75"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7d61831b-7be9-44dd-9730-90f6f68ca3e9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("8005a86a-345d-4071-b220-f2fc4c612d16"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("8450889b-85e2-459b-80d3-c7d7d5ebeda4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("8c58110d-c029-4632-abca-6d2ca226610b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("a06cbdad-d9d7-4b91-bcdb-81392b819ad8"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b081cf8c-486c-4ae6-b3ec-325b78d907f4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b0c6211e-5c18-4d32-bde1-2bab8982ef59"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b1087897-cbf5-4999-bd0c-43a518efd548"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b40e01d4-11d3-4fb8-82b5-be94ad9c7d96"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b99f4817-8928-4ae2-8f73-1433d7e31d90"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("c53fb043-fc8c-4de9-9d85-431ef13a38e1"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d734a0c7-5a92-4965-8ce5-721173d71593"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("e6b64f4d-6980-4667-a6bf-2452ceaa3581"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("ea8df262-4db6-46a8-a028-9964f7e3430b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f256be92-ce91-4faf-a67d-74ce918cc10e"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f3e4ce4e-847f-4005-bcad-439114683672"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f46e7a70-aa9c-4f14-89bf-71bf83cf92b2"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5938ab0-9c03-4b79-9f6b-28d091b1060b"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("4940de1d-5fd0-4736-8c0a-662b78cd8ca4"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("6bd33d39-d76b-43c8-ac5a-4f6fee78f94f"));

            migrationBuilder.AlterColumn<int>(
                name: "TotalEpisode",
                table: "Films",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AvgRating",
                table: "Films",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 11, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 11, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(8932), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 11, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("68f67614-7bae-41fe-94ac-5507d1fb53ba"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 11, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("dd16849f-2802-4b3d-a07f-28b3cb097d3a"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 11, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("873a8f31-3a64-469d-a163-4250357043f9"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d84535b8-ab5e-4eea-9ebb-c92eaf3efe8d"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9821), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9062), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9055), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9029), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "AvgDuration", "AvgRating", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Director", "Image", "ModifiedBy", "ModifiedTime", "Name", "Status", "TotalEpisode", "Year" },
                values: new object[,]
                {
                    { new Guid("0b11de38-c826-46d2-aff9-f3f7db8f1380"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director4", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film4", 1, 0, 2024 },
                    { new Guid("12ece4db-c8a9-4805-99bd-aa574684adb7"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9438), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director19", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film19", 1, 0, 2024 },
                    { new Guid("1f7ea1b1-114e-4501-9bdd-7f7c649cbb2b"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9341), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director11", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film11", 1, 0, 2024 },
                    { new Guid("28c671a4-10c7-4111-801f-7d63bf118d5c"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director7", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film7", 1, 0, 2024 },
                    { new Guid("2e130761-957d-4d0e-beb0-fc1fe1df5479"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9480), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director23", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film23", 1, 0, 2024 },
                    { new Guid("2e35322e-58ef-4bba-b93f-683d8f88d6bc"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director29", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film29", 1, 0, 2024 },
                    { new Guid("3776292f-33b6-46c3-9956-1c9b71dea911"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director13", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film13", 1, 0, 2024 },
                    { new Guid("41e94909-f48a-4e90-b162-7bc0ecd846f4"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director28", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film28", 1, 0, 2024 },
                    { new Guid("4a7089ad-07e4-4d37-a069-c9c0fb03bb85"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9372), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director14", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film14", 1, 0, 2024 },
                    { new Guid("5686a2ef-c048-444b-b6ee-58282bb2fa6e"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director2", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film2", 1, 0, 2024 },
                    { new Guid("60b49a99-e8fb-42e3-86e8-4a3c2c88c34a"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9287), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director6", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film6", 1, 0, 2024 },
                    { new Guid("646af27f-e3db-4ee7-a36d-a1333e58865d"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9468), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director22", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film22", 1, 0, 2024 },
                    { new Guid("70daba39-391a-4628-ba20-ff2f51f75cdc"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9354), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director12", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film12", 1, 0, 2024 },
                    { new Guid("7ddc834a-ec72-45fa-ac9d-610fafdcfb81"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9419), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director17", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film17", 1, 0, 2024 },
                    { new Guid("828ec340-b719-4433-b358-d45ae2c43b11"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9278), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director5", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film5", 1, 0, 2024 },
                    { new Guid("82b3ef21-5f2f-4f35-af2f-733d38aff904"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9119), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director0", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film0", 1, 0, 2024 },
                    { new Guid("84c65a1f-610e-4bcd-b922-876479366808"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director15", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film15", 1, 0, 2024 },
                    { new Guid("8c3d9793-174b-4097-b47f-c375317a541d"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9489), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director24", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film24", 1, 0, 2024 },
                    { new Guid("ab1ccf66-4fb0-49dc-a785-2b64bb723473"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director16", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film16", 1, 0, 2024 },
                    { new Guid("ad994872-75a4-44cf-9ef9-3bb2b7178ac7"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director27", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film27", 1, 0, 2024 },
                    { new Guid("b10843b2-2cee-4b83-ae93-7b68683f400a"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director8", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film8", 1, 0, 2024 },
                    { new Guid("c445faef-de3e-430f-a376-3cc9a30420e9"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director26", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film26", 1, 0, 2024 },
                    { new Guid("ca8c309d-d84b-4bc0-96c9-97ae0d99de3b"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9429), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director18", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film18", 1, 0, 2024 },
                    { new Guid("d9ad2188-c824-448e-8b44-fa6dd67c15e1"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9235), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director1", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film1", 1, 0, 2024 },
                    { new Guid("ddfa69cd-ccab-423e-a914-325c8cfa3ef6"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9331), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director10", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film10", 1, 0, 2024 },
                    { new Guid("de09a17d-d332-4a6b-9a2b-2a24fb82a56b"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director20", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film20", 1, 0, 2024 },
                    { new Guid("e1aad308-c2b0-4ddd-a595-9eb4e9a88ee6"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9500), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director25", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film25", 1, 0, 2024 },
                    { new Guid("e363bc29-c6ca-41a5-bdc2-a13369433755"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9458), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director21", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film21", 1, 0, 2024 },
                    { new Guid("e48cf1e9-1300-437c-a5e8-e87bd37c045e"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9323), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director9", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film9", 1, 0, 2024 },
                    { new Guid("f32e5443-ea5a-4eca-afee-bc37a3200ab1"), new TimeSpan(0, 0, 0, 0, 0), null, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director3", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film3", 1, 0, 2024 }
                });

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("2a08d9fc-157e-450f-9f0d-a1ce51540a49"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f6c81586-f136-4974-8179-13fbd425bf28"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9612), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9757), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 59, 43, 116, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("68f67614-7bae-41fe-94ac-5507d1fb53ba"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("dd16849f-2802-4b3d-a07f-28b3cb097d3a"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("873a8f31-3a64-469d-a163-4250357043f9"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("d84535b8-ab5e-4eea-9ebb-c92eaf3efe8d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("0b11de38-c826-46d2-aff9-f3f7db8f1380"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("12ece4db-c8a9-4805-99bd-aa574684adb7"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("1f7ea1b1-114e-4501-9bdd-7f7c649cbb2b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("28c671a4-10c7-4111-801f-7d63bf118d5c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("2e130761-957d-4d0e-beb0-fc1fe1df5479"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("2e35322e-58ef-4bba-b93f-683d8f88d6bc"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3776292f-33b6-46c3-9956-1c9b71dea911"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("41e94909-f48a-4e90-b162-7bc0ecd846f4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("4a7089ad-07e4-4d37-a069-c9c0fb03bb85"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("5686a2ef-c048-444b-b6ee-58282bb2fa6e"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("60b49a99-e8fb-42e3-86e8-4a3c2c88c34a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("646af27f-e3db-4ee7-a36d-a1333e58865d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("70daba39-391a-4628-ba20-ff2f51f75cdc"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7ddc834a-ec72-45fa-ac9d-610fafdcfb81"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("828ec340-b719-4433-b358-d45ae2c43b11"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("82b3ef21-5f2f-4f35-af2f-733d38aff904"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("84c65a1f-610e-4bcd-b922-876479366808"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("8c3d9793-174b-4097-b47f-c375317a541d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("ab1ccf66-4fb0-49dc-a785-2b64bb723473"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("ad994872-75a4-44cf-9ef9-3bb2b7178ac7"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b10843b2-2cee-4b83-ae93-7b68683f400a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("c445faef-de3e-430f-a376-3cc9a30420e9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("ca8c309d-d84b-4bc0-96c9-97ae0d99de3b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d9ad2188-c824-448e-8b44-fa6dd67c15e1"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("ddfa69cd-ccab-423e-a914-325c8cfa3ef6"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("de09a17d-d332-4a6b-9a2b-2a24fb82a56b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("e1aad308-c2b0-4ddd-a595-9eb4e9a88ee6"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("e363bc29-c6ca-41a5-bdc2-a13369433755"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("e48cf1e9-1300-437c-a5e8-e87bd37c045e"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f32e5443-ea5a-4eca-afee-bc37a3200ab1"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("2a08d9fc-157e-450f-9f0d-a1ce51540a49"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("f6c81586-f136-4974-8179-13fbd425bf28"));

            migrationBuilder.AlterColumn<int>(
                name: "TotalEpisode",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvgRating",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 11, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 11, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 11, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("1db6fa81-88d2-46fb-8658-f3e85a3a1052"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 11, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4881), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" },
                    { new Guid("68bae7e1-5703-47b6-98c4-cbddd1376404"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 11, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0f6d5661-ccfe-4796-9895-f3eb11b14d4c"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5512), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fef703d0-4138-491d-9c3d-174d7c56dd64"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4955), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4927), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                columns: new[] { "AvgRating", "CreatedTime" },
                values: new object[] { 0, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "AvgDuration", "AvgRating", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Director", "Image", "ModifiedBy", "ModifiedTime", "Name", "Status", "TotalEpisode", "Year" },
                values: new object[,]
                {
                    { new Guid("0906787f-1694-4aca-a686-0f081bf0e132"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director24", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film24", 1, 0, 2024 },
                    { new Guid("1887ee29-d8db-43e1-b28b-923e00b5e9c4"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5269), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director23", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film23", 1, 0, 2024 },
                    { new Guid("3086e700-aa47-4986-b50e-c1d855527174"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director17", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film17", 1, 0, 2024 },
                    { new Guid("346bad25-2698-4da2-8cee-ab19b7ab720a"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5088), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director1", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film1", 1, 0, 2024 },
                    { new Guid("39463206-5743-4234-bafb-5d6e4ad5dad7"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director29", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film29", 1, 0, 2024 },
                    { new Guid("3bed06cb-73fb-44a6-9131-1c5f91991917"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5103), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director2", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film2", 1, 0, 2024 },
                    { new Guid("483a1a9c-1dcb-40a2-b2bc-2547441bd684"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director8", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film8", 1, 0, 2024 },
                    { new Guid("55698e40-b5b3-4d6c-9098-03d7bb7c911a"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5114), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director3", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film3", 1, 0, 2024 },
                    { new Guid("5c4dd9ca-062b-4fdb-8ab0-e7b7baa8fc35"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director16", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film16", 1, 0, 2024 },
                    { new Guid("737835dd-de6b-4485-b553-ee15900c8635"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director21", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film21", 1, 0, 2024 },
                    { new Guid("774d2aac-e9bd-453a-8094-2bf30d63c171"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director14", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film14", 1, 0, 2024 },
                    { new Guid("7d194407-056d-458a-9e4d-472c9f1b7c75"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director5", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film5", 1, 0, 2024 },
                    { new Guid("7d61831b-7be9-44dd-9730-90f6f68ca3e9"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5176), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director11", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film11", 1, 0, 2024 },
                    { new Guid("8005a86a-345d-4071-b220-f2fc4c612d16"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director4", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film4", 1, 0, 2024 },
                    { new Guid("8450889b-85e2-459b-80d3-c7d7d5ebeda4"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5284), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director25", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film25", 1, 0, 2024 },
                    { new Guid("8c58110d-c029-4632-abca-6d2ca226610b"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director22", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film22", 1, 0, 2024 },
                    { new Guid("a06cbdad-d9d7-4b91-bcdb-81392b819ad8"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5248), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director20", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film20", 1, 0, 2024 },
                    { new Guid("b081cf8c-486c-4ae6-b3ec-325b78d907f4"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5203), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director15", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film15", 1, 0, 2024 },
                    { new Guid("b0c6211e-5c18-4d32-bde1-2bab8982ef59"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director6", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film6", 1, 0, 2024 },
                    { new Guid("b1087897-cbf5-4999-bd0c-43a518efd548"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director10", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film10", 1, 0, 2024 },
                    { new Guid("b40e01d4-11d3-4fb8-82b5-be94ad9c7d96"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5299), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director27", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film27", 1, 0, 2024 },
                    { new Guid("b99f4817-8928-4ae2-8f73-1433d7e31d90"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director18", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film18", 1, 0, 2024 },
                    { new Guid("c53fb043-fc8c-4de9-9d85-431ef13a38e1"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(4995), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director0", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film0", 1, 0, 2024 },
                    { new Guid("d734a0c7-5a92-4965-8ce5-721173d71593"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director13", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film13", 1, 0, 2024 },
                    { new Guid("e6b64f4d-6980-4667-a6bf-2452ceaa3581"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director26", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film26", 1, 0, 2024 },
                    { new Guid("ea8df262-4db6-46a8-a028-9964f7e3430b"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director12", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film12", 1, 0, 2024 },
                    { new Guid("f256be92-ce91-4faf-a67d-74ce918cc10e"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director7", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film7", 1, 0, 2024 },
                    { new Guid("f3e4ce4e-847f-4005-bcad-439114683672"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director28", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film28", 1, 0, 2024 },
                    { new Guid("f46e7a70-aa9c-4f14-89bf-71bf83cf92b2"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5160), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director9", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film9", 1, 0, 2024 },
                    { new Guid("f5938ab0-9c03-4b79-9f6b-28d091b1060b"), new TimeSpan(0, 0, 0, 0, 0), 0, null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director19", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film19", 1, 0, 2024 }
                });

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("4940de1d-5fd0-4736-8c0a-662b78cd8ca4"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("6bd33d39-d76b-43c8-ac5a-4f6fee78f94f"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5551), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5361), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5373), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 7, 4, 57, 39, 988, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
