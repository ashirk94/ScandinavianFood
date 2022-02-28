using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class UtcTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b56870b8-e56d-4e63-9725-71abe4a338dd", "646db9cb-5a07-4f26-8a72-425b83d19eab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "371f0ec9-8342-4866-a6a7-ddf2f39f69c6", "4ce7fcb0-78b2-462f-92a0-b99c67dac065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cf33c9e-d888-49ec-87ad-5ca04c5c7cad", "510c5bfa-13ef-44d4-896c-1246adea3b7b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
