using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBradster.Migrations
{
    public partial class updatedDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "password", "Timebinder" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "password", "Bradster" });
        }
    }
}
