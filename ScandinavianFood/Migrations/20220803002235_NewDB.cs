using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f187f19-48c9-497f-a1b0-5fe3a06e3330", "3be2dd1e-5ef9-4fce-b52b-926d5cb0767d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c987447-86e8-47cd-a444-4a480c6cc5e4", "082a17c7-4fb5-4da7-b2be-bd0b63beaa5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "944273e6-125d-4928-9f6b-e1124557c9f3", "18e12b60-955a-49fb-88d0-cf6e1f2224da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce317b25-a0c2-4822-a8f6-8b69e5c719b1", "ef58d704-579e-48f8-baa4-c958eda32be8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55632dea-c7fc-46cf-be42-186000ad8d79", "ee7338f7-f38f-4a41-ae0d-b32dffd0edde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02df8242-c3ef-41bc-aa93-b357f6149fde", "500f3008-71ff-4ef2-a738-58cfbcdeab6e" });
        }
    }
}
