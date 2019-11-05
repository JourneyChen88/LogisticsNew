using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class updAddress_1027 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Address",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Address");
        }
    }
}
