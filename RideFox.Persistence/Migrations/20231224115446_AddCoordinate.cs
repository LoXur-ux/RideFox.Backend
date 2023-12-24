using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideFox.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCoordinate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "CoordinateId",
                table: "Address",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Coordinate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinate", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CoordinateId",
                table: "Address",
                column: "CoordinateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Coordinate_CoordinateId",
                table: "Address",
                column: "CoordinateId",
                principalTable: "Coordinate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Coordinate_CoordinateId",
                table: "Address");

            migrationBuilder.DropTable(
                name: "Coordinate");

            migrationBuilder.DropIndex(
                name: "IX_Address_CoordinateId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CoordinateId",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Address",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Address",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
