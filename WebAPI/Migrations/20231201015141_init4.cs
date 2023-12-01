using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Owners_OwnerId",
                table: "Companies");

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
                name: "OwnerId",
                table: "Companies",
                newName: "CompanyOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_OwnerId",
                table: "Companies",
                newName: "IX_Companies_CompanyOwnerId");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("3afa7636-aba3-4562-92b3-a3c07a5c7411"), 1, "Suat Usta", 20000.0 },
                    { new Guid("43e7d70a-e308-4f6b-a8b7-9216bb6c7077"), 2, "Hitachi Usta", 25000.0 },
                    { new Guid("5b76820b-26df-46a6-987c-d908dc6040bb"), 4, "Iglesias Usta", 60000.0 },
                    { new Guid("6a251fa1-fd88-45c4-8d09-7277941ab148"), 1, "Hakkı Usta", 15000.0 },
                    { new Guid("7b1cd380-5cb5-4fa9-a208-a03acd8bf8d8"), 2, "Makita Usta", 30000.0 },
                    { new Guid("b8f466ac-e51f-427e-abdb-cb4a4efb566e"), 3, "Hans Usta", 22000.0 },
                    { new Guid("bc1982bc-838d-4006-9c11-baa7ff323282"), 3, "Buffon Usta", 20000.0 },
                    { new Guid("e5b2346e-e4fc-4570-8617-adfa0c621362"), 2, "Ryobi Usta", 45000.0 },
                    { new Guid("ea4df93b-6508-4faf-b572-7edf453efd7f"), 1, "Ahmet Usta", 5000.0 },
                    { new Guid("f12ab5fa-f8a5-4049-a674-e2fdfbf6ad15"), 3, "Nail Usta", 33000.0 },
                    { new Guid("fa90374f-10ed-4344-a185-9d40e718f9a4"), 3, "Tsubasa Usta", 23232.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Owners_CompanyOwnerId",
                table: "Companies",
                column: "CompanyOwnerId",
                principalTable: "Owners",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Owners_CompanyOwnerId",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3afa7636-aba3-4562-92b3-a3c07a5c7411"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("43e7d70a-e308-4f6b-a8b7-9216bb6c7077"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5b76820b-26df-46a6-987c-d908dc6040bb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6a251fa1-fd88-45c4-8d09-7277941ab148"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7b1cd380-5cb5-4fa9-a208-a03acd8bf8d8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b8f466ac-e51f-427e-abdb-cb4a4efb566e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bc1982bc-838d-4006-9c11-baa7ff323282"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e5b2346e-e4fc-4570-8617-adfa0c621362"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ea4df93b-6508-4faf-b572-7edf453efd7f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f12ab5fa-f8a5-4049-a674-e2fdfbf6ad15"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fa90374f-10ed-4344-a185-9d40e718f9a4"));

            migrationBuilder.RenameColumn(
                name: "CompanyOwnerId",
                table: "Companies",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CompanyOwnerId",
                table: "Companies",
                newName: "IX_Companies_OwnerId");

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
                name: "FK_Companies_Owners_OwnerId",
                table: "Companies",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id");
        }
    }
}
