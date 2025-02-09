using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Models.Migrations
{
    /// <inheritdoc />
    public partial class ItemEntityEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "item",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "mileage",
                table: "item",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_url",
                table: "item");

            migrationBuilder.DropColumn(
                name: "mileage",
                table: "item");
        }
    }
}
