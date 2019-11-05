using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class updOrder1021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "PicPath",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicPath",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Order",
                nullable: false,
                defaultValue: 0);
        }
    }
}
