using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    IdReservation = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuestName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CheckinDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumberOfNights = table.Column<int>(type: "INTEGER", nullable: false),
                    IncludeBreakfast = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.IdReservation);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Theme = table.Column<string>(type: "TEXT", nullable: false),
                    FloreNum = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomNum = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerNight = table.Column<double>(type: "REAL", nullable: false),
                    NumberOfBeds = table.Column<int>(type: "INTEGER", nullable: false),
                    HasSpa = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdReservation = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_IdReservation",
                        column: x => x.IdReservation,
                        principalTable: "Reservations",
                        principalColumn: "IdReservation",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_IdReservation",
                table: "Rooms",
                column: "IdReservation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
