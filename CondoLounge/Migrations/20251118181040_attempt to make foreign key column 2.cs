using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class attempttomakeforeignkeycolumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Condos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BuildingId",
                table: "AspNetUsers",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Buildings_BuildingId",
                table: "AspNetUsers",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Buildings_BuildingId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BuildingId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Condos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");
        }
    }
}
