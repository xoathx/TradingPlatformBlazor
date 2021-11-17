using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class RemoveShopIdFromLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "shop_vendor",
                table: "Lots");

            migrationBuilder.RenameColumn(
                name: "vendorId",
                table: "Lots",
                newName: "vendor_id");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Lots",
                newName: "category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vendor_id",
                table: "Lots",
                newName: "vendorId");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Lots",
                newName: "categoryId");

            migrationBuilder.AddColumn<int>(
                name: "shop_vendor",
                table: "Lots",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
