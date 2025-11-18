using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class attempttomakeusershaveacondo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Condos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CondoNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Condos");

            migrationBuilder.DropColumn(
                name: "CondoNumber",
                table: "AspNetUsers");
        }
    }
}
