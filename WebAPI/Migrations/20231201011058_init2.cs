using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tuna GÜL" },
                    { 2, "Zatoichi Kiroshi" },
                    { 3, "Raquel Sanchez" },
                    { 4, "Emilio Zanetti" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 1, "Turkey Ship-Co", 1 },
                    { 2, "Japan Ship-Co", 1 },
                    { 3, "Monaco Ship-Co", 2 },
                    { 4, "Spain Ship-Co", 3 },
                    { 5, "Germany Ship-Co", 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("150dffda-3026-4502-b310-8b19c7893f82"), 1, "Hakkı Usta", 15000.0 },
                    { new Guid("3ecb3928-6d42-4a6a-bf85-af2b9ac6ea70"), 2, "Ryobi Usta", 45000.0 },
                    { new Guid("41793fae-baa1-479e-b1a3-7809440af4d4"), 3, "Hans Usta", 22000.0 },
                    { new Guid("4202e56e-ed55-4a58-b05f-b15f9adc5560"), 4, "Iglesias Usta", 60000.0 },
                    { new Guid("5af64fe6-5094-48d4-a422-ea261d72736c"), 1, "Suat Usta", 20000.0 },
                    { new Guid("70f6a785-073c-403e-81ae-0dd788892085"), 3, "Tsubasa Usta", 23232.0 },
                    { new Guid("7b67c7c5-001e-4ef1-9697-03c9448876c2"), 2, "Hitachi Usta", 25000.0 },
                    { new Guid("7c388946-875f-4a0b-9546-2451c914ac2a"), 3, "Nail Usta", 33000.0 },
                    { new Guid("97cdb7cf-363f-447b-8e51-9dc3d0a8a1eb"), 2, "Makita Usta", 30000.0 },
                    { new Guid("d446fdb6-560f-4f54-ac6e-0fce609ea568"), 3, "Buffon Usta", 20000.0 },
                    { new Guid("f534024d-5f26-4786-9249-da3e8af14272"), 1, "Ahmet Usta", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Ships",
                columns: new[] { "Id", "AuthorCompanyId", "Length", "Name", "ShipColor" },
                values: new object[,]
                {
                    { 1, 1, 50.0, "Uçak Gemisi", 5 },
                    { 2, 1, 30.0, "Yük Gemisi", 4 },
                    { 3, 1, 30.0, "Buğday Gemisi", 3 },
                    { 4, 2, 40.0, "Oil Ship", 0 },
                    { 5, 2, 30.0, "Car Ship", 1 },
                    { 6, 2, 25.0, "Drone Ship", 1 },
                    { 7, 3, 10.0, "Fisher Boat", 0 },
                    { 8, 3, 5.0, "Mussell Hunter", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("150dffda-3026-4502-b310-8b19c7893f82"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3ecb3928-6d42-4a6a-bf85-af2b9ac6ea70"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("41793fae-baa1-479e-b1a3-7809440af4d4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4202e56e-ed55-4a58-b05f-b15f9adc5560"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5af64fe6-5094-48d4-a422-ea261d72736c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("70f6a785-073c-403e-81ae-0dd788892085"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7b67c7c5-001e-4ef1-9697-03c9448876c2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7c388946-875f-4a0b-9546-2451c914ac2a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("97cdb7cf-363f-447b-8e51-9dc3d0a8a1eb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d446fdb6-560f-4f54-ac6e-0fce609ea568"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f534024d-5f26-4786-9249-da3e8af14272"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
