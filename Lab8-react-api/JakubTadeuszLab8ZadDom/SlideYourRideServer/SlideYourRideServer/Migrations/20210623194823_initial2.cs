using Microsoft.EntityFrameworkCore.Migrations;

namespace SlideYourRideServer.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Stops_EndStopId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_EndStopId",
                table: "Tracks");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_StartStopId",
                table: "Tracks",
                column: "StartStopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Stops_StartStopId",
                table: "Tracks",
                column: "StartStopId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Stops_StartStopId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_StartStopId",
                table: "Tracks");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_EndStopId",
                table: "Tracks",
                column: "EndStopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Stops_EndStopId",
                table: "Tracks",
                column: "EndStopId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
