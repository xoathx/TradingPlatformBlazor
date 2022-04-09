using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class AddShopBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "shop_balance",
                table: "Shops",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "shop_balance",
                table: "Shops");
        }
    }
}
