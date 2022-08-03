using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class Scandifood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce3458bd-689d-4bba-8e4c-715580491bad", "4f390006-38c5-4f78-8c6d-79089344b587" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ff044f1-29f1-41a0-b3ee-2972aa8c6363", "727be093-127d-408f-ac6b-3c91b6d2ebf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7bf3dcf-1b03-4cf3-bb82-3806e22c7b94", "111648e3-0668-4f80-82c6-65d3da3b39bd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
