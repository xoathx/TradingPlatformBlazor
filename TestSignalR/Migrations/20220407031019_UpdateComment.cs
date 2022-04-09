using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class UpdateComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "to_id",
                table: "Comments",
                newName: "to_user_id");

            migrationBuilder.AddColumn<int>(
                name: "to_shop_id",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "to_shop_id",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "to_user_id",
                table: "Comments",
                newName: "to_id");
        }
    }
}
