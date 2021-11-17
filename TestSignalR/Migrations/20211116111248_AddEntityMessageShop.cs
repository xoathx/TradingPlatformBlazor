using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class AddEntityMessageShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageShops",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_message = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_shop_message = table.Column<bool>(type: "bit", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    shop_id = table.Column<int>(type: "int", nullable: false),
                    shop_member_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageShops", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageShops");
        }
    }
}
