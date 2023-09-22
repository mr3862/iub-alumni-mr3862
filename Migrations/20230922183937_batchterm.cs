using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUBAlumniUSA.Migrations
{
    public partial class batchterm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f7ba3a8-290a-42a9-a2cc-1b83af651ff9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccde504d-243e-4878-8949-4b047139beee");

            migrationBuilder.AlterColumn<string>(
                name: "BatchTerm",
                table: "Profiles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97dedee8-286b-4e42-85f4-270a872a8849");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb3d17b9-c706-4f3c-9fde-2d1399e31090");

            migrationBuilder.AlterColumn<int>(
                name: "BatchTerm",
                table: "Profiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6b344c74-8ee3-478d-8e63-740eeb7cb4f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f7ba3a8-290a-42a9-a2cc-1b83af651ff9", "3508be63-b9bd-4b9b-8927-83ce0567f9ad", "Basic", "BASIC" },
                    { "ccde504d-243e-4878-8949-4b047139beee", "c489481d-9254-43c4-8554-5a51e56fefe1", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "482f882d-0363-4c0e-a7ed-8b6b8e2c5563", "AQAAAAEAACcQAAAAEHFr91hVGOHj3SPynQAWmas9JaoeJWe0jSBPhzg6XyllOqtXH5RzKyOYyBsWRLRWFg==", "c2f8e0d6-13ef-443d-b6d2-ea559e5c535f" });
        }
    }
}
