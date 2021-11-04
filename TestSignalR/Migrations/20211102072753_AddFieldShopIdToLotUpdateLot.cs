using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class AddFieldShopIdToLotUpdateLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Categories_categoryId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Users_vendorId",
                table: "Lots");

            migrationBuilder.DropIndex(
                name: "IX_Lots_categoryId",
                table: "Lots");

            migrationBuilder.DropIndex(
                name: "IX_Lots_vendorId",
                table: "Lots");

            migrationBuilder.AddColumn<int>(
                name: "shop_vendor",
                table: "Lots",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "shop_vendor",
                table: "Lots");

            migrationBuilder.CreateIndex(
                name: "IX_Lots_categoryId",
                table: "Lots",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Lots_vendorId",
                table: "Lots",
                column: "vendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Categories_categoryId",
                table: "Lots",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Users_vendorId",
                table: "Lots",
                column: "vendorId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
