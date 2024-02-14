using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideFox.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCoordinateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Coordinate_CoordinateId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Scooter_Coordinate_CoordinateId",
                table: "Scooter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coordinate",
                table: "Coordinate");

            migrationBuilder.RenameTable(
                name: "Coordinate",
                newName: "Coordinates");

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Penalty",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coordinates",
                table: "Coordinates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Coordinates_CoordinateId",
                table: "Address",
                column: "CoordinateId",
                principalTable: "Coordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scooter_Coordinates_CoordinateId",
                table: "Scooter",
                column: "CoordinateId",
                principalTable: "Coordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Coordinates_CoordinateId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Scooter_Coordinates_CoordinateId",
                table: "Scooter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coordinates",
                table: "Coordinates");

            migrationBuilder.RenameTable(
                name: "Coordinates",
                newName: "Coordinate");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Penalty",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coordinate",
                table: "Coordinate",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Coordinate_CoordinateId",
                table: "Address",
                column: "CoordinateId",
                principalTable: "Coordinate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scooter_Coordinate_CoordinateId",
                table: "Scooter",
                column: "CoordinateId",
                principalTable: "Coordinate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
