using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostableRESTFulApi.Migrations
{
    /// <inheritdoc />
    public partial class PostIdAndUserIdUniquesInLikeTabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_PostId",
                table: "Likes");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId_UserId",
                table: "Likes",
                columns: new[] { "PostId", "UserId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_PostId_UserId",
                table: "Likes");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");
        }
    }
}
