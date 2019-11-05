using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class upd_order_1026 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetailInfo",
                table: "Address",
                newName: "Detail");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Address",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Address",
                newName: "DetailInfo");
        }
    }
}
