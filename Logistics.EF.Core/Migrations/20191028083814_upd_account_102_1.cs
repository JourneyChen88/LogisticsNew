using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class upd_account_102_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankType",
                table: "Account");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "BankType",
                table: "Account",
                nullable: false,
                defaultValue: 0);
        }
    }
}
