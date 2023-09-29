using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class degree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97dedee8-286b-4e42-85f4-270a872a8849");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb3d17b9-c706-4f3c-9fde-2d1399e31090");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d7b4dc0-31de-422d-9775-b5250ad190fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fb953da-3ab4-4562-8721-5eaa2e36b221", "265dfaa2-9b01-4181-8210-a604f24905d5", "Admin", "ADMIN" },
                    { "b13fef42-24ce-40a5-b03a-249fac113fa7", "d6a589f0-4c1b-46d5-b20a-3310bda4c991", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b9a9373-a87f-4fef-8718-05f46c42f8dc", "AQAAAAEAACcQAAAAEPuPuP7ooEANEVlqG97l8DMfPwFdtIxtw/u73f3E9/ShQWgbT8hLLdPKyF0UKbL04A==", "f9176fff-1757-4d18-91ab-828afc263bbc" });

            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "Id", "DegreeLevel", "DegreeName" },
                values: new object[,]
                {
                    { 3, "B", "B.Sc. in Electrical & Telecommunication Engineering" },
                    { 4, "B", "B.Sc. in Computer Science & Engineering" },
                    { 5, "B", "B.Sc. in Pharmacy" },
                    { 6, "B", "Bachelor of Business Administration" },
                    { 7, "M", "M.Sc. in Computer Science" },
                    { 8, "M", "M.Sc. in Software Engineering" },
                    { 9, "M", "M.Sc. in  Computer Networks and Communications" },
                    { 10, "M", "M.Sc. in Telecommunication Engineering" },
                    { 11, "M", "Master of Business Administration" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fb953da-3ab4-4562-8721-5eaa2e36b221");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13fef42-24ce-40a5-b03a-249fac113fa7");

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d301fe5e-f290-4550-9432-184b30107343");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "97dedee8-286b-4e42-85f4-270a872a8849", "fa476ce5-686e-4385-af4e-a1ff7431ef46", "Admin", "ADMIN" },
                    { "fb3d17b9-c706-4f3c-9fde-2d1399e31090", "a81fb8df-fdcf-4b7e-96b6-7697866cd3f5", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "533b6769-07ea-4127-9051-557f6fb99dd2", "AQAAAAEAACcQAAAAEAwXrCcWxuVjkBpPWa1a1O3sPTeNhaN4OYH86o6KLL4K4r7nAgnskxxLSSw5eDsGcQ==", "37c05dd8-90ac-4c8a-83c4-cc7bd17d80ed" });
        }
    }
}
