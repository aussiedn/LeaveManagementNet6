using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbff",
                column: "ConcurrencyStamp",
                value: "281105c2-3c8c-4090-a247-c2e9202a8e8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbff",
                column: "ConcurrencyStamp",
                value: "022e8e82-1ddb-4561-b21e-67beb661c05c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7649905d-47c5-491a-a2e0-24a360ed1325", "AQAAAAEAACcQAAAAEG6kCUDiyouH3VUtSS+rSadXw81tcfkHmkOK2UxHV5IN/hOrNIcxUXakTFUCuqfE5Q==", "cf290d88-5b66-4863-baa1-682bca3d1aed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "556c8901-6713-4890-af61-be5116155c89", "AQAAAAEAACcQAAAAEDSWmZZ9K/ooCG9on7NVDBdHvwXfRzLPj+lWAE4uKsdRMTIhGiZhkIy4bzsWl2DDAg==", "25871b3f-8c2b-49cc-8868-d5b95f294950" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbff",
                column: "ConcurrencyStamp",
                value: "9469f928-a960-4999-a977-007d2c16721d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbff",
                column: "ConcurrencyStamp",
                value: "50e4f46c-a0fe-4836-83e8-55f4042f1ca3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed98623b-9def-4039-8e75-2f7318502797", "AQAAAAEAACcQAAAAEHJkQTqRBmzB2NOxz2HeJhOaDnEwsl/S+oYol6iHXzCnjLPnFHzfUIihd5lFHZygFQ==", "dffc79fa-f3af-42ab-8e38-de07f5eae5d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b388ded5-bb32-46c5-95d6-f10e62ec27f9", "AQAAAAEAACcQAAAAEPahgEbo/KMh0UMpipwSEC2U5HRuLd/OTzrCek+DH3RYcEAVJMbcMVpkEzXVLanUZw==", "cd981f4a-54a7-4fe2-aaae-0e9638f9c800" });
        }
    }
}
