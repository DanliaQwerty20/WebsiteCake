using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteCake.Storage.Migrations
{
    /// <inheritdoc />
    public partial class NewFilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link_picture",
                table: "Fillings",
                newName: "LinkPicture");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkPicture",
                table: "Fillings",
                newName: "Link_picture");
        }
    }
}
