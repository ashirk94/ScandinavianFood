using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class Async : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f128533b-eae8-4540-9d96-49a2a01e344c", "7ad34bd6-ff52-4145-91c5-52adbb6d852e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddfddcde-44ca-405d-8707-fa62d6ef95d0", "a8517e7b-01a4-46e3-b9b7-b3fbfbef8995" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1798f7f0-103c-4298-a031-c60864e28b9e", "45c49d39-e269-452b-9bcb-9533fa0f9143" });
        }
    }
}
