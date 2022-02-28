using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class Dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "997c48a4-4ec2-4e27-98a1-b30f51a50be4", "2406ee6f-28ff-4cc8-a8d6-ee2ba799ad23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e36b454d-de03-44b2-afa3-0247b41054be", "be1fcaf2-c6a9-4473-b9fd-e3ba016b5f9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b5c5d58-a2e6-42f1-8915-2a06aad4ab25", "dd6f899a-cc2e-4f0c-ad96-1a818f932962" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
