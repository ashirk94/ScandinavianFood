using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class ResetDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "022768de-14d9-4704-a086-eaeea3ad5ef2", "9654f4a3-a95e-40d3-b6f8-c932917c7b03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c929edb3-2d6a-454b-ad6e-ce33ebf8484d", "3b1a529f-4e27-4bf6-8319-57862cd96ee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c314f290-dabf-476d-bcfc-d35c5efe29e3", "02b065c3-412d-4519-88fb-9e393ade5445" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
