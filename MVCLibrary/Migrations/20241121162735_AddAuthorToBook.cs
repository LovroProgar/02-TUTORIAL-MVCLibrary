using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "book");
        }
    }
}
