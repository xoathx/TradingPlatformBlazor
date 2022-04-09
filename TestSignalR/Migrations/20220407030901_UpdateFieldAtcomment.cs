using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class UpdateFieldAtcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "to_user_id",
                table: "Comments",
                newName: "to_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "to_id",
                table: "Comments",
                newName: "to_user_id");
        }
    }
}
