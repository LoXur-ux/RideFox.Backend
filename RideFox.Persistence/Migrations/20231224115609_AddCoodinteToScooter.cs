using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideFox.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCoodinteToScooter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Scooter");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Scooter");

            migrationBuilder.AddColumn<Guid>(
                name: "CoordinateId",
                table: "Scooter",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Scooter_CoordinateId",
                table: "Scooter",
                column: "CoordinateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scooter_Coordinate_CoordinateId",
                table: "Scooter",
                column: "CoordinateId",
                principalTable: "Coordinate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scooter_Coordinate_CoordinateId",
                table: "Scooter");

            migrationBuilder.DropIndex(
                name: "IX_Scooter_CoordinateId",
                table: "Scooter");

            migrationBuilder.DropColumn(
                name: "CoordinateId",
                table: "Scooter");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Scooter",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Scooter",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
