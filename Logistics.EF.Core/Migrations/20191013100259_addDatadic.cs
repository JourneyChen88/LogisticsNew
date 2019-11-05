using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class addDatadic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataDic",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TypeCode = table.Column<string>(maxLength: 64, nullable: true),
                    TypeName = table.Column<string>(maxLength: 64, nullable: true),
                    ItemCode = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemRemark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataDic", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataDic");
        }
    }
}
