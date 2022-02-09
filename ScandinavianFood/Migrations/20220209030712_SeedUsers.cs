using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ScandinavianFood.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "A", 0, "f128533b-eae8-4540-9d96-49a2a01e344c", null, false, false, null, null, null, null, null, false, "7ad34bd6-ff52-4145-91c5-52adbb6d852e", false, "AlanS" },
                    { "B", 0, "ddfddcde-44ca-405d-8707-fa62d6ef95d0", null, false, false, null, null, null, null, null, false, "a8517e7b-01a4-46e3-b9b7-b3fbfbef8995", false, "SolaireA" },
                    { "C", 0, "1798f7f0-103c-4298-a031-c60864e28b9e", null, false, false, null, null, null, null, null, false, "45c49d39-e269-452b-9bcb-9533fa0f9143", false, "LautrecC" }
                });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "Page", "PostDate", "Rating", "Text", "User" },
                values: new object[,]
                {
                    { 1, "Forum", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Hello World", "AlanS" },
                    { 2, "Forum", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Seed Data", "SolaireA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
