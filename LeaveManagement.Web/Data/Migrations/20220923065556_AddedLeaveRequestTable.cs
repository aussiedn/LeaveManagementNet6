using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
