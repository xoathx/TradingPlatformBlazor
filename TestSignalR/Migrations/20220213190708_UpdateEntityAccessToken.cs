using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformBlazor.Migrations
{
    public partial class UpdateEntityAccessToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Token",
                table: "AccessTokens",
                newName: "token");

            migrationBuilder.RenameColumn(
                name: "Passcrypt",
                table: "AccessTokens",
                newName: "passcrypt");

            migrationBuilder.RenameColumn(
                name: "Nick",
                table: "AccessTokens",
                newName: "nick");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "AccessTokens",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccessTokens",
                newName: "id");

            migrationBuilder.AddColumn<bool>(
                name: "isActivated",
                table: "AccessTokens",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActivated",
                table: "AccessTokens");

            migrationBuilder.RenameColumn(
                name: "token",
                table: "AccessTokens",
                newName: "Token");

            migrationBuilder.RenameColumn(
                name: "passcrypt",
                table: "AccessTokens",
                newName: "Passcrypt");

            migrationBuilder.RenameColumn(
                name: "nick",
                table: "AccessTokens",
                newName: "Nick");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "AccessTokens",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AccessTokens",
                newName: "Id");
        }
    }
}
