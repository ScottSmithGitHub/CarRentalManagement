using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "96e9b795-d146-46b2-a8e7-03f2609ba66e", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "00a609d6-5c71-4dcc-b82c-76c27cdf5758", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "59bb23ff-a3e0-4806-92e6-bb6f66568907", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAoqY8n80Sr2UEfaOC4v7QKRTQOpUhK2Mm90aoXEaPjCu2KFyOjvx3ZQK5LFQbniFQ==", null, false, "bf414f91-9024-406e-a86c-e4a5c312f6d5", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "35a59c84-b02a-4f6d-aea3-1bd465355562", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFTWkFPiU0yK1OaBwdqyr2iWOCs9OvGjCrANpF//Y4dBX3cm2stBnl02wz581s9KyQ==", null, false, "7715312b-af6c-47b5-b3d6-362cb56e2923", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6786), "Black", "System" },
                    { 2, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6792), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6981), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6984), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(6988), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7073), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7075), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7078), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7079), "Vitz", "System" },
                    { 3, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7082), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7084), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7086), new DateTime(2022, 1, 19, 12, 42, 1, 161, DateTimeKind.Local).AddTicks(7088), "X5", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
