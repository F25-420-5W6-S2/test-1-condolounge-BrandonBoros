using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class updatedbuildingtohavecondos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "Condo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Condo_BuildingId",
                table: "Condo",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Condo_Buildings_BuildingId",
                table: "Condo",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condo_Buildings_BuildingId",
                table: "Condo");

            migrationBuilder.DropIndex(
                name: "IX_Condo_BuildingId",
                table: "Condo");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Condo");
        }
    }
}
