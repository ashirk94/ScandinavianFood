using Microsoft.EntityFrameworkCore.Migrations;

namespace ScandinavianFood.Migrations
{
    public partial class Next : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "894cb3ab-69ae-4e9f-874b-de4e8c62e81a", "a0ff044b-1403-48cc-932c-88f58d7407eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbbc971c-e137-4a0e-8de6-d3a22c6f4244", "829f4d30-6307-458c-ad48-8d4b90f16a56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c16cdf22-08a9-4b7d-b819-8b3f4469349f", "eabd868d-e6e7-4c55-b0fd-3068b434277a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
