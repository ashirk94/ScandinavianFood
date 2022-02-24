using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class ForumChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Page",
                table: "ForumPosts");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "ForumPosts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9c667e1-8bbb-4877-9c0e-39ed593cf6c3", "9407434c-e94e-4e36-8962-947d5daac771" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52a79c7c-5ca9-4d36-bbe8-463aa6abf3c8", "7979ed1c-2528-4ed4-b363-025cadab0d10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4fad1dd-9b4e-44c9-938b-f3367783dfe3", "9463b399-6e40-4cb5-a9e6-ea7f7144cf2a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Page",
                table: "ForumPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "ForumPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2be866eb-07fe-41e4-bc4f-394aac43988a", "1531e96f-5f9d-413d-befb-2c7596927503" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da171397-41d8-4e33-a43b-9c2df6b1d498", "1aa86e66-912a-4516-aefe-9a4ce104558d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f772067-123c-447a-b36c-2be98df4529c", "9581433c-e347-448e-a1a2-ed708c2f7019" });

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Page", "Rating" },
                values: new object[] { "Forum", 5 });

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Page", "Rating" },
                values: new object[] { "Forum", 4 });
        }
    }
}
