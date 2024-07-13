using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmMoi.Domain.Migrations
{
    /// <inheritdoc />
    public partial class hht : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7a118f30-af35-4364-a288-098704a94e08"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("cc140641-ef72-4918-a94f-79bc30755d62"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("82b4ff19-b8db-45e0-b10c-fe1ade8f989e"));

            migrationBuilder.DeleteData(
                table: "FilmActors",
                keyColumn: "ID",
                keyValue: new Guid("b8d9e65a-be9f-46b1-ac54-d83aaa5b63cd"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("0853c5a8-de68-471b-8bbf-343abdcb7b7c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("0914172c-19e3-417d-bedf-fc19400967d9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("14cc5350-f7ac-41ab-b94c-bece100dfa88"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("27a69a68-4fb5-49c7-bfc0-f5edc5d852b5"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("294f85fb-0ae3-4adb-9132-9e1c36a9cbfa"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("2af42872-85b8-432e-b859-663cc5b41374"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("2eecc00d-341f-4a92-8d5f-85350d3250d8"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("4252a101-b52a-40a6-b3e7-4165cf2dc96e"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("4af30cd9-d405-4911-8a5f-bfb350c65ea7"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("4b601c93-f48c-42ed-a782-03de913a2a75"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("5509dc9a-f83d-4276-be82-2a655271356b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("5e97ac13-1f35-4028-aa9f-4c8fc7560743"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("74dc0bc7-d385-46cb-a143-2831b344fda7"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("8612fceb-a08b-472b-9fed-e14c9f2f0c92"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("8ead14a4-40f3-41c2-b724-5e9abab15a9b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("91aaf245-b8b7-4b6f-8b87-19eb4a01fac8"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("92e31d89-0a40-4933-9202-2d62af114369"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("9cbfa2c9-ed94-4823-8e69-deddc159bcdf"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("9d440332-b5c9-4710-9859-a4791764abc6"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("a87fb86e-1e1a-47b4-9f66-69359c976577"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("ac5faa37-c702-4ea8-8145-3e409761ca58"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("afabc6a9-0fcd-4727-a6bb-0ae4ee7ce35a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("b06c358d-ac6c-40ac-ac5c-904aa049e9b8"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("bfa7cf54-986d-4008-9eee-c250076c6878"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("c717ae9d-c5a2-4220-a2e4-4e95a37a0e43"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f04401f4-41aa-4cca-87d0-c72eff41aa5e"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f6bea5a0-35ad-4394-b79b-9801943e9db4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f7a130cd-7fa6-44be-a7f8-af2adc705431"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f8320493-1db0-456a-90f6-c654b1721c67"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("fbc98e0c-4e4b-442b-848d-72d69148d6c2"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("034f32a9-64d9-42a5-90b6-f6497e7d7caf"));

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "ID",
                keyValue: new Guid("3abd8dcf-e6c4-49be-8272-d76e6c2e822c"));

            migrationBuilder.AddColumn<int>(
                name: "AvgRating",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AvgRating",
                table: "Films");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 20, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("794b3996-aac6-437e-87c6-197fde46149d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 20, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("e7ec9630-52da-4e31-9700-afe4627d672a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 20, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7164), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Dob", "Image", "ModifiedBy", "ModifiedTime", "Name", "Nationality" },
                values: new object[,]
                {
                    { new Guid("7a118f30-af35-4364-a288-098704a94e08"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 20, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1979, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor4.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Hermione Granger", "America" },
                    { new Guid("cc140641-ef72-4918-a94f-79bc30755d62"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 20, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "actor5.jpg", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Scarlett Johansson", "America" }
                });

            migrationBuilder.InsertData(
                table: "FilmActors",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_ACtor", "ID_Film", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("82b4ff19-b8db-45e0-b10c-fe1ade8f989e"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8353), new TimeSpan(0, 0, 0, 0, 0)), new Guid("7677bb7f-f9aa-4738-a61d-b52427d9dd62"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b8d9e65a-be9f-46b1-ac54-d83aaa5b63cd"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8364), new TimeSpan(0, 0, 0, 0, 0)), new Guid("794b3996-aac6-437e-87c6-197fde46149d"), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7340), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "AvgDuration", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Director", "Image", "ModifiedBy", "ModifiedTime", "Name", "Status", "TotalEpisode", "Year" },
                values: new object[,]
                {
                    { new Guid("0853c5a8-de68-471b-8bbf-343abdcb7b7c"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director7", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film7", 1, 0, 2024 },
                    { new Guid("0914172c-19e3-417d-bedf-fc19400967d9"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7575), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director3", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film3", 1, 0, 2024 },
                    { new Guid("14cc5350-f7ac-41ab-b94c-bece100dfa88"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director5", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film5", 1, 0, 2024 },
                    { new Guid("27a69a68-4fb5-49c7-bfc0-f5edc5d852b5"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director24", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film24", 1, 0, 2024 },
                    { new Guid("294f85fb-0ae3-4adb-9132-9e1c36a9cbfa"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7849), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director23", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film23", 1, 0, 2024 },
                    { new Guid("2af42872-85b8-432e-b859-663cc5b41374"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director18", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film18", 1, 0, 2024 },
                    { new Guid("2eecc00d-341f-4a92-8d5f-85350d3250d8"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director25", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film25", 1, 0, 2024 },
                    { new Guid("4252a101-b52a-40a6-b3e7-4165cf2dc96e"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director15", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film15", 1, 0, 2024 },
                    { new Guid("4af30cd9-d405-4911-8a5f-bfb350c65ea7"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director1", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film1", 1, 0, 2024 },
                    { new Guid("4b601c93-f48c-42ed-a782-03de913a2a75"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director2", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film2", 1, 0, 2024 },
                    { new Guid("5509dc9a-f83d-4276-be82-2a655271356b"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7896), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director27", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film27", 1, 0, 2024 },
                    { new Guid("5e97ac13-1f35-4028-aa9f-4c8fc7560743"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7840), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director22", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film22", 1, 0, 2024 },
                    { new Guid("74dc0bc7-d385-46cb-a143-2831b344fda7"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director0", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film0", 1, 0, 2024 },
                    { new Guid("8612fceb-a08b-472b-9fed-e14c9f2f0c92"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director17", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film17", 1, 0, 2024 },
                    { new Guid("8ead14a4-40f3-41c2-b724-5e9abab15a9b"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director19", "movie-7.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film19", 1, 0, 2024 },
                    { new Guid("91aaf245-b8b7-4b6f-8b87-19eb4a01fac8"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director4", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film4", 1, 0, 2024 },
                    { new Guid("92e31d89-0a40-4933-9202-2d62af114369"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director8", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film8", 1, 0, 2024 },
                    { new Guid("9cbfa2c9-ed94-4823-8e69-deddc159bcdf"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7667), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director10", "movie-3.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film10", 1, 0, 2024 },
                    { new Guid("9d440332-b5c9-4710-9859-a4791764abc6"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director29", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film29", 1, 0, 2024 },
                    { new Guid("a87fb86e-1e1a-47b4-9f66-69359c976577"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7764), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director16", "movie-4.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film16", 1, 0, 2024 },
                    { new Guid("ac5faa37-c702-4ea8-8145-3e409761ca58"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director11", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film11", 1, 0, 2024 },
                    { new Guid("afabc6a9-0fcd-4727-a6bb-0ae4ee7ce35a"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director14", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film14", 1, 0, 2024 },
                    { new Guid("b06c358d-ac6c-40ac-ac5c-904aa049e9b8"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7815), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director20", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film20", 1, 0, 2024 },
                    { new Guid("bfa7cf54-986d-4008-9eee-c250076c6878"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7657), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director9", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film9", 1, 0, 2024 },
                    { new Guid("c717ae9d-c5a2-4220-a2e4-4e95a37a0e43"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director12", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film12", 1, 0, 2024 },
                    { new Guid("f04401f4-41aa-4cca-87d0-c72eff41aa5e"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director28", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film28", 1, 0, 2024 },
                    { new Guid("f6bea5a0-35ad-4394-b79b-9801943e9db4"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director13", "movie-5.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film13", 1, 0, 2024 },
                    { new Guid("f7a130cd-7fa6-44be-a7f8-af2adc705431"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director21", "movie-2.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film21", 1, 0, 2024 },
                    { new Guid("f8320493-1db0-456a-90f6-c654b1721c67"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7881), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director26", "movie-6.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film26", 1, 0, 2024 },
                    { new Guid("fbc98e0c-4e4b-442b-848d-72d69148d6c2"), new TimeSpan(0, 0, 0, 0, 0), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Movie cute", "Director6", "movie-1.png", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Film6", 1, 0, 2024 }
                });

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "ID_Film", "ID_Genre", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("034f32a9-64d9-42a5-90b6-f6497e7d7caf"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 0, 0, 0, 0)), new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3abd8dcf-e6c4-49be-8272-d76e6c2e822c"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 0, 0, 0, 0)), new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8021), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8029), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: new Guid("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("98236a61-4d91-42fe-b956-fd64fb14ddc5"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8285), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumns: new[] { "ID_Film", "ID_User" },
                keyValues: new object[] { new Guid("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"), new Guid("f69cd789-4c44-401c-a021-5b6742af2279") },
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 7, 6, 13, 9, 33, 6, DateTimeKind.Unspecified).AddTicks(8294), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
