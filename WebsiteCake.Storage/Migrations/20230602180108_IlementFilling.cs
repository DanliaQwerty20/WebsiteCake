using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteCake.Storage.Migrations
{
    /// <inheritdoc />
    public partial class IlementFilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link_picture",
                table: "Fillings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link_picture",
                table: "Fillings");
        }
    }
}
