using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    Accommodation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accommodation", "AccommodationEmail", "AccommodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 1, null, null, null, "Boise", new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visit Tammy", null, null });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accommodation", "AccommodationEmail", "AccommodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 2, "The Benson Hotel", "staff@bensonhotel.com", "503-555-1234", "Portland", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go to Voodoo Doughnuts", "Walk in the rain", "Go to Powell's" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
