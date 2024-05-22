using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Net.Data.Migrations
{
    /// <inheritdoc />
    public partial class CRUDMigrationFinalV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelNumber",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
