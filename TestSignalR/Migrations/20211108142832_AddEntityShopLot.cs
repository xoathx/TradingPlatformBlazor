using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class AddEntityShopLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopLots",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameLot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descLot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    shop_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopLots", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopLots");
        }
    }
}
