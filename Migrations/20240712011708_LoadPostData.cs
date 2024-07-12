using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostableRESTFulApi.Migrations
{
    /// <inheritdoc />
    public partial class LoadPostData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Post para crear una página web. Bienvenidos!!! en este post veremos los pasos para crear una página web", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5878), 1 },
                    { 2, "Introducción a C# y .NET. En este post aprenderemos sobre los fundamentos de C# y .NET", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5898), 1 },
                    { 3, "Cómo usar Entity Framework Core en tus proyectos. Tutorial paso a paso", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5900), 1 },
                    { 4, "Mejores prácticas en el desarrollo de APIs RESTful", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5901), 1 },
                    { 5, "Conceptos básicos de HTML y CSS", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5903), 2 },
                    { 6, "Cómo empezar con JavaScript", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5905), 2 },
                    { 7, "Guía para principiantes sobre React", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5906), 2 },
                    { 8, "Cómo crear un portafolio en línea", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5908), 2 },
                    { 9, "Introducción a SQL y bases de datos relacionales", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5910), 3 },
                    { 10, "Cómo optimizar consultas SQL", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5911), 3 },
                    { 11, "Manejo de transacciones en SQL Server", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5913), 3 },
                    { 12, "Diseño de esquemas de base de datos eficientes", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5915), 3 },
                    { 13, "Conceptos básicos de Python para principiantes", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5916), 4 },
                    { 14, "Cómo usar pandas para análisis de datos", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5918), 4 },
                    { 15, "Introducción a la inteligencia artificial con Python", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5920), 4 },
                    { 16, "Desarrollo de aplicaciones web con Flask", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5921), 4 },
                    { 17, "Fundamentos de programación orientada a objetos", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5923), 5 },
                    { 18, "Cómo escribir código limpio y mantenible", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5925), 5 },
                    { 19, "Introducción a los patrones de diseño", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5926), 5 },
                    { 20, "Cómo hacer pruebas unitarias en C#", new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5928), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 39, DateTimeKind.Local).AddTicks(2896));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 13, 5, 730, DateTimeKind.Local).AddTicks(2639));
        }
    }
}
