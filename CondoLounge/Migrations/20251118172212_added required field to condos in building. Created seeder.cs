using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class addedrequiredfieldtocondosinbuildingCreatedseeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condo_Buildings_BuildingId",
                table: "Condo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condo",
                table: "Condo");

            migrationBuilder.RenameTable(
                name: "Condo",
                newName: "Condos");

            migrationBuilder.RenameIndex(
                name: "IX_Condo_BuildingId",
                table: "Condos",
                newName: "IX_Condos_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condos",
                table: "Condos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condos",
                table: "Condos");

            migrationBuilder.RenameTable(
                name: "Condos",
                newName: "Condo");

            migrationBuilder.RenameIndex(
                name: "IX_Condos_BuildingId",
                table: "Condo",
                newName: "IX_Condo_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condo",
                table: "Condo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Condo_Buildings_BuildingId",
                table: "Condo",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");
        }
    }
}
