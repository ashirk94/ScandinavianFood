using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class Ratings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumRating",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumPostId = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    RaterId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumRating", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_ForumRating_ForumPosts_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPosts",
                        principalColumn: "ForumPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumRating_AspNetUsers_RaterId",
                        column: x => x.RaterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5db2dfdb-15a2-4dba-a06d-3606672c8b65", "a583daa5-4fb2-4de9-98d6-a96213ab4bfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8994e06-21d3-4f65-897b-c44f5da554c4", "82213feb-56c4-40d9-8d4c-e12be6fac4c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "998cfbbf-3096-44a6-b947-6c37c2944443", "646d879a-17a0-4ba1-83fe-d8fdd0402235" });

            migrationBuilder.CreateIndex(
                name: "IX_ForumRating_ForumPostId",
                table: "ForumRating",
                column: "ForumPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumRating_RaterId",
                table: "ForumRating",
                column: "RaterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumRating");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6862069-4f22-44b5-b017-80e500c888aa", "198e75bf-9c25-4488-ad7c-3d47cdd708b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09518339-76cc-4532-9a37-9636a0d99b66", "b6bef506-6431-4f6b-a5c2-bafe7340a3cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3990125-ca21-439b-8894-85be556ab6fc", "f696062e-c53e-427c-b2b6-ed043b64f40f" });
        }
    }
}
