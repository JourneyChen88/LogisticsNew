using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class updOrder1014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderNo",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "Order");
        }
    }
}
