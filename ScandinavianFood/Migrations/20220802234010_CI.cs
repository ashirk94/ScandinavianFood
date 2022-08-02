using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class CI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92f5d85c-762c-4342-973a-d047c9cb4131", "df34214f-e257-4564-8dba-ba8ab3912061" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53e27f76-bb67-41a4-a256-bdc6bfe5b254", "9849a5ea-c212-47fb-b0fb-48ed58d75848" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25834ab5-b0a6-45da-8a47-cff10cb2200a", "9364e0e5-3968-474d-905a-bdec76b08c32" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
