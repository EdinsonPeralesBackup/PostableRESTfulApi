using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostableRESTFulApi.Migrations
{
    /// <inheritdoc />
    public partial class LoadUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2607), "edi_perales@neelvat.com", "Edinson", "Perales", "123456", "Admin", "EdinsonPerales" },
                    { 2, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2626), null, "John", "Doe", "password1", "User", "JohnDoe" },
                    { 3, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2627), "jane_smith@example.com", null, null, "password2", "User", "JaneSmith" },
                    { 4, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2629), null, "Mike", null, "password3", "User", "MikeBrown" },
                    { 5, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2631), null, null, "Connor", "password4", "Admin", "SaraConnor" },
                    { 6, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2632), null, null, null, "password5", "User", "TomHanks" },
                    { 7, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2633), "emma_watson@example.com", "Emma", "Watson", "password6", "User", "EmmaWatson" },
                    { 8, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2635), "robert_downey@example.com", null, null, "password7", "User", "RobertDowney" },
                    { 9, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2636), null, "Chris", null, "password8", "User", "ChrisEvans" },
                    { 10, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2638), null, null, "Johansson", "password9", "User", "ScarlettJohansson" },
                    { 11, new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2639), null, "Bruce", "Wayne", "password10", "User", "BruceWayne" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
