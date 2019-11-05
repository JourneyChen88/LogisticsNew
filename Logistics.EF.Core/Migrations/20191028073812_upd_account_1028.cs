using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class upd_account_1028 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Account");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Account",
                nullable: true);
        }
    }
}
