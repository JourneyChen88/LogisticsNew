using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class upd_order_1025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PicPath",
                table: "Order",
                newName: "PicPath4");

            migrationBuilder.AddColumn<string>(
                name: "PicPath1",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PicPath2",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PicPath3",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicPath1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PicPath2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PicPath3",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "PicPath4",
                table: "Order",
                newName: "PicPath");
        }
    }
}
