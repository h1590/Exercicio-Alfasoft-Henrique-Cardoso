using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExercicioAlfasoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class contactsWithIsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Contact");
        }
    }
}
