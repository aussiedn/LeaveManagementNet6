using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbff",
                column: "ConcurrencyStamp",
                value: "d84d147a-a683-4934-bc96-9d5e030eec5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbff",
                column: "ConcurrencyStamp",
                value: "c8d99bfc-507b-456d-a635-3932a0cd6772");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "85370f47-d8bb-4eb0-801d-aa8f77085949", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIF3p1nIMT14mtUQMUhSZ9IiT/d8Ekr6XIN9coa+0tFTU1voKoJKH9snOYg+2awSqQ==", "0b5386ee-51ee-4e2c-8819-20dce6c13c3c", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6bc14af6-77be-4ecb-8a7a-c6ec5e819d0a", true, "PETER@HOTMAIL.COM", "AQAAAAEAACcQAAAAEICtSIQX9MVLtcxS7uwp1/7s8xHqE/Lk3Pa4vY22A0TxtKLoPhZNgc5/3qRA8PquzQ==", "1b5f1209-4901-4b8b-a0bf-9a14e59bae66", "peter@hotmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbff",
                column: "ConcurrencyStamp",
                value: "3a494ac4-29cb-4883-964a-725be9f97725");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbff",
                column: "ConcurrencyStamp",
                value: "d5ebe61d-4ad1-4acf-8311-5f048ea1fa65");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "496f65df-6337-45f4-9e1c-ee0933fe88a7", false, null, "AQAAAAEAACcQAAAAEGbaWnC0Wbvqds7Z+JRteL7zFxWPE+Bm/uHMcQXmcQ/K3tzsVMV9oiiVUYTEBhhA6g==", "612eeae3-f20c-4834-bdec-e104b7f662e1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2604115b-d9ed-4e85-82b0-5b5493d83d37", false, null, "AQAAAAEAACcQAAAAEHcek3ofIBz1dRgucUuB4ezLPAiOpj9IfZvWvrykUogRu7iNQYvLECxFM10Vfkc5yQ==", "0347ee37-9c35-474c-8b11-4f7704de7c22", null });
        }
    }
}
