using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbff",
                column: "ConcurrencyStamp",
                value: "0fe63d26-56ed-4fdf-b4b1-d460e88af9bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbff",
                column: "ConcurrencyStamp",
                value: "fcd03031-e360-4dbb-8227-fc4530c61237");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba1ab4d-133e-4564-93b4-03f6a8a454aa", "AQAAAAEAACcQAAAAEKVLvG9qRQrWgtkod9a/J1nen+Le0B9jOM6YXEQkbO2YK4c1BMDerYLMCieSOocfLA==", "89d078bb-bdf0-4c11-b866-93fed943d846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2238cd23-2b87-42d8-a836-814a6701f2f5", "AQAAAAEAACcQAAAAEHJwNgTV6GzhZIBe6ZQzD/53v+W/ZAJS/VjDf5ifPmY6OuEg96oVwPXL5pujTtl5Pw==", "42afec31-c0e5-452b-a9a2-c13026c8f7e6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85370f47-d8bb-4eb0-801d-aa8f77085949", "AQAAAAEAACcQAAAAEIF3p1nIMT14mtUQMUhSZ9IiT/d8Ekr6XIN9coa+0tFTU1voKoJKH9snOYg+2awSqQ==", "0b5386ee-51ee-4e2c-8819-20dce6c13c3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc14af6-77be-4ecb-8a7a-c6ec5e819d0a", "AQAAAAEAACcQAAAAEICtSIQX9MVLtcxS7uwp1/7s8xHqE/Lk3Pa4vY22A0TxtKLoPhZNgc5/3qRA8PquzQ==", "1b5f1209-4901-4b8b-a0bf-9a14e59bae66" });
        }
    }
}
