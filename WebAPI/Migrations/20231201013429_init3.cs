using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ships_Companies_AuthorCompanyId",
                table: "Ships");

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

            migrationBuilder.RenameColumn(
                name: "AuthorCompanyId",
                table: "Ships",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Ships_AuthorCompanyId",
                table: "Ships",
                newName: "IX_Ships_CompanyId");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("00a85644-6b92-474e-abfa-bb9ee74121f5"), 2, "Ryobi Usta", 45000.0 },
                    { new Guid("2acdc66f-b3cd-453e-a7a4-d0cfda41bf21"), 3, "Tsubasa Usta", 23232.0 },
                    { new Guid("45b5c30a-33b6-4ac0-b591-c01b71f49126"), 1, "Suat Usta", 20000.0 },
                    { new Guid("4e7817ed-fb84-4e0f-8173-c2595dd7f509"), 3, "Hans Usta", 22000.0 },
                    { new Guid("6f7d8c00-f162-4cc1-ad9b-435c0a36bb60"), 1, "Ahmet Usta", 5000.0 },
                    { new Guid("7dd5434a-628f-4ed3-b483-6d7069419605"), 2, "Makita Usta", 30000.0 },
                    { new Guid("8ae99910-1958-43f7-be1d-6db6efc25a78"), 2, "Hitachi Usta", 25000.0 },
                    { new Guid("954a684f-ab38-4685-a0a4-2451d11325de"), 1, "Hakkı Usta", 15000.0 },
                    { new Guid("95e7c78e-4427-4d34-ada6-755e10089fe4"), 3, "Nail Usta", 33000.0 },
                    { new Guid("c29046e6-320d-449a-8cc4-22abd1cacb52"), 4, "Iglesias Usta", 60000.0 },
                    { new Guid("cfe1bdd7-2d19-4e26-a448-3991ae307e97"), 3, "Buffon Usta", 20000.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_Companies_CompanyId",
                table: "Ships",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ships_Companies_CompanyId",
                table: "Ships");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00a85644-6b92-474e-abfa-bb9ee74121f5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2acdc66f-b3cd-453e-a7a4-d0cfda41bf21"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("45b5c30a-33b6-4ac0-b591-c01b71f49126"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4e7817ed-fb84-4e0f-8173-c2595dd7f509"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6f7d8c00-f162-4cc1-ad9b-435c0a36bb60"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7dd5434a-628f-4ed3-b483-6d7069419605"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8ae99910-1958-43f7-be1d-6db6efc25a78"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("954a684f-ab38-4685-a0a4-2451d11325de"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("95e7c78e-4427-4d34-ada6-755e10089fe4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c29046e6-320d-449a-8cc4-22abd1cacb52"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cfe1bdd7-2d19-4e26-a448-3991ae307e97"));

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Ships",
                newName: "AuthorCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Ships_CompanyId",
                table: "Ships",
                newName: "IX_Ships_AuthorCompanyId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_Companies_AuthorCompanyId",
                table: "Ships",
                column: "AuthorCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
