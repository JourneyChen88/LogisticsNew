using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.EF.Core.Migrations
{
    public partial class adress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetModel",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetNumber",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "ProductionDate",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Asset");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Asset",
                newName: "Linker");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Asset",
                newName: "LinkPhone");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Asset",
                newName: "IsDefault");

            migrationBuilder.AddColumn<string>(
                name: "DetailInfo",
                table: "Asset",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailInfo",
                table: "Asset");

            migrationBuilder.RenameColumn(
                name: "Linker",
                table: "Asset",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LinkPhone",
                table: "Asset",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "IsDefault",
                table: "Asset",
                newName: "IsActive");

            migrationBuilder.AddColumn<string>(
                name: "AssetModel",
                table: "Asset",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetNumber",
                table: "Asset",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Asset",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionDate",
                table: "Asset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Asset",
                maxLength: 1024,
                nullable: true);
        }
    }
}
