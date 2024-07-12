using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostableRESTFulApi.Migrations
{
    /// <inheritdoc />
    public partial class LoadLikeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "CreatedAt", "PostId", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8575), 1, 4 },
                    { 3, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8593), 1, 6 },
                    { 4, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8594), 1, 8 },
                    { 5, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8595), 1, 9 },
                    { 6, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8596), 1, 10 },
                    { 7, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8597), 1, 11 },
                    { 8, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8598), 2, 1 },
                    { 9, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8600), 2, 2 },
                    { 10, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8602), 2, 3 },
                    { 11, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8603), 2, 5 },
                    { 12, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8604), 2, 6 },
                    { 13, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8605), 2, 7 },
                    { 14, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8606), 2, 8 },
                    { 15, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8607), 2, 9 },
                    { 16, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8608), 2, 10 },
                    { 17, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8609), 2, 11 },
                    { 18, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8610), 3, 1 },
                    { 19, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8611), 3, 2 },
                    { 20, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8612), 3, 3 },
                    { 21, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8613), 3, 4 },
                    { 22, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8615), 3, 5 },
                    { 23, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8616), 3, 6 },
                    { 24, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8617), 3, 7 },
                    { 25, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8618), 3, 8 },
                    { 26, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8619), 3, 9 },
                    { 27, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8620), 3, 10 },
                    { 28, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8621), 3, 11 },
                    { 29, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8622), 4, 1 },
                    { 30, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8623), 4, 2 },
                    { 31, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8625), 4, 3 },
                    { 32, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8626), 4, 4 },
                    { 33, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8627), 4, 5 },
                    { 34, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8632), 4, 6 },
                    { 35, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8633), 4, 7 },
                    { 36, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8634), 4, 8 },
                    { 37, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8635), 4, 9 },
                    { 38, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8636), 4, 10 },
                    { 39, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8638), 4, 11 },
                    { 40, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8639), 5, 1 },
                    { 41, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8640), 5, 2 },
                    { 42, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8641), 5, 3 },
                    { 43, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8642), 5, 4 },
                    { 44, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8643), 5, 5 },
                    { 45, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8644), 5, 6 },
                    { 46, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8645), 5, 7 },
                    { 47, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8646), 5, 8 },
                    { 48, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8648), 5, 9 },
                    { 49, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8649), 5, 10 },
                    { 50, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8650), 5, 11 },
                    { 51, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8651), 6, 1 },
                    { 52, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8652), 6, 2 },
                    { 53, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8653), 6, 3 },
                    { 54, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8654), 6, 4 },
                    { 55, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8655), 6, 5 },
                    { 56, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8656), 6, 6 },
                    { 57, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8657), 6, 7 },
                    { 58, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8659), 6, 8 },
                    { 59, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8660), 6, 9 },
                    { 60, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8661), 6, 10 },
                    { 61, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8663), 6, 11 },
                    { 62, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8664), 7, 1 },
                    { 63, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8665), 7, 2 },
                    { 64, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8666), 7, 3 },
                    { 65, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8667), 7, 4 },
                    { 66, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8668), 7, 5 },
                    { 67, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8669), 7, 6 },
                    { 68, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8670), 7, 7 },
                    { 69, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8672), 7, 8 },
                    { 70, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8673), 7, 9 },
                    { 71, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8674), 7, 10 },
                    { 72, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8675), 7, 11 },
                    { 73, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8676), 8, 1 },
                    { 74, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8677), 8, 2 },
                    { 75, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8678), 8, 3 },
                    { 76, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8679), 8, 4 },
                    { 77, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8680), 8, 5 },
                    { 78, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8682), 8, 6 },
                    { 79, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8683), 8, 7 },
                    { 80, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8684), 8, 8 },
                    { 81, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8685), 8, 9 },
                    { 82, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8686), 8, 10 },
                    { 83, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8688), 8, 11 },
                    { 84, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8689), 9, 1 },
                    { 85, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8690), 9, 2 },
                    { 86, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8691), 9, 3 },
                    { 87, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8692), 9, 4 },
                    { 88, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8694), 9, 5 },
                    { 89, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8695), 9, 6 },
                    { 90, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8696), 9, 7 },
                    { 91, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8697), 9, 8 },
                    { 92, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8698), 9, 9 },
                    { 93, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8699), 9, 10 },
                    { 94, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8700), 9, 11 },
                    { 95, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8701), 10, 1 },
                    { 96, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8702), 10, 2 },
                    { 97, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8703), 10, 3 },
                    { 98, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8704), 10, 4 },
                    { 99, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8705), 10, 5 },
                    { 100, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8706), 10, 6 },
                    { 101, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8707), 10, 7 },
                    { 102, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8710), 10, 8 },
                    { 103, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8711), 10, 9 },
                    { 104, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8712), 10, 10 },
                    { 105, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8713), 10, 11 },
                    { 106, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8714), 11, 1 },
                    { 107, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8715), 11, 2 },
                    { 108, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8718), 11, 3 },
                    { 109, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8719), 11, 4 },
                    { 110, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8720), 11, 5 },
                    { 111, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8721), 11, 6 },
                    { 112, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8722), 11, 7 },
                    { 113, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8723), 11, 8 },
                    { 114, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8724), 11, 9 },
                    { 115, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8725), 11, 10 },
                    { 116, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8726), 11, 11 },
                    { 117, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8727), 12, 1 },
                    { 118, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8728), 12, 2 },
                    { 119, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8729), 12, 3 },
                    { 120, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8730), 12, 4 },
                    { 121, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8803), 12, 5 },
                    { 122, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8805), 12, 6 },
                    { 123, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8806), 12, 7 },
                    { 124, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8807), 12, 8 },
                    { 125, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8808), 12, 9 },
                    { 126, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8809), 12, 10 },
                    { 127, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8810), 12, 11 },
                    { 128, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8812), 13, 1 },
                    { 129, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8813), 13, 2 },
                    { 130, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8814), 13, 3 },
                    { 131, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8815), 13, 4 },
                    { 132, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8816), 13, 5 },
                    { 133, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8818), 13, 6 },
                    { 134, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8819), 13, 7 },
                    { 135, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8820), 13, 8 },
                    { 136, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8821), 13, 9 },
                    { 137, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8822), 13, 10 },
                    { 138, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8824), 13, 11 },
                    { 139, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8825), 14, 1 },
                    { 140, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8826), 14, 2 },
                    { 141, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8827), 14, 3 },
                    { 142, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8828), 14, 4 },
                    { 143, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8829), 14, 5 },
                    { 144, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8830), 14, 6 },
                    { 145, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8831), 14, 7 },
                    { 146, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8832), 14, 8 },
                    { 147, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8833), 14, 9 },
                    { 148, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8834), 14, 10 },
                    { 149, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8836), 14, 11 },
                    { 150, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8837), 15, 1 },
                    { 151, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8838), 15, 2 },
                    { 152, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8839), 15, 3 },
                    { 153, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8840), 15, 4 },
                    { 154, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8841), 15, 5 },
                    { 155, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8842), 15, 6 },
                    { 156, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8843), 15, 7 },
                    { 157, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8845), 15, 8 },
                    { 158, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8846), 15, 9 },
                    { 159, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8847), 15, 10 },
                    { 160, new DateTime(2024, 7, 11, 20, 38, 38, 276, DateTimeKind.Local).AddTicks(8849), 15, 11 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 38, 38, 277, DateTimeKind.Local).AddTicks(8063));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 11, 20, 17, 8, 38, DateTimeKind.Local).AddTicks(5928));

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
    }
}
