using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class AddFieldToComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_to_shop_comment",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_to_shop_comment",
                table: "Comments");
        }
    }
}
