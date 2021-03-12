using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArenaCharacter_Arenas_ArenaId",
                table: "ArenaCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_BattlegroundCharacter_Battlegrounds_BattlegroundId",
                table: "BattlegroundCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_DungeonCharacter_Dungeons_DungeonId",
                table: "DungeonCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_RaidCharacter_Raids_RaidId",
                table: "RaidCharacter");

            migrationBuilder.AddForeignKey(
                name: "FK_ArenaCharacter_Arenas_ArenaId",
                table: "ArenaCharacter",
                column: "ArenaId",
                principalTable: "Arenas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattlegroundCharacter_Battlegrounds_BattlegroundId",
                table: "BattlegroundCharacter",
                column: "BattlegroundId",
                principalTable: "Battlegrounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DungeonCharacter_Dungeons_DungeonId",
                table: "DungeonCharacter",
                column: "DungeonId",
                principalTable: "Dungeons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RaidCharacter_Raids_RaidId",
                table: "RaidCharacter",
                column: "RaidId",
                principalTable: "Raids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArenaCharacter_Arenas_ArenaId",
                table: "ArenaCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_BattlegroundCharacter_Battlegrounds_BattlegroundId",
                table: "BattlegroundCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_DungeonCharacter_Dungeons_DungeonId",
                table: "DungeonCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_RaidCharacter_Raids_RaidId",
                table: "RaidCharacter");

            migrationBuilder.AddForeignKey(
                name: "FK_ArenaCharacter_Arenas_ArenaId",
                table: "ArenaCharacter",
                column: "ArenaId",
                principalTable: "Arenas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BattlegroundCharacter_Battlegrounds_BattlegroundId",
                table: "BattlegroundCharacter",
                column: "BattlegroundId",
                principalTable: "Battlegrounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DungeonCharacter_Dungeons_DungeonId",
                table: "DungeonCharacter",
                column: "DungeonId",
                principalTable: "Dungeons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaidCharacter_Raids_RaidId",
                table: "RaidCharacter",
                column: "RaidId",
                principalTable: "Raids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
