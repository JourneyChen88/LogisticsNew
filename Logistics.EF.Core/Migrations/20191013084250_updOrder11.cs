using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class updOrder11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderUser",
                table: "Order",
                newName: "Sender");

            migrationBuilder.AddColumn<string>(
                name: "Receiver",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverPhone",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ReceiverPhone",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Order",
                newName: "OrderUser");
        }
    }
}
