using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsRaidLeader = table.Column<bool>(nullable: false),
                    IsWarlord = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    ItemLevel = table.Column<int>(nullable: false),
                    ArenaRating = table.Column<double>(nullable: false),
                    BattlegroundRating = table.Column<double>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arenas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsWon = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arenas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arenas_Characters_LeaderId",
                        column: x => x.LeaderId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Battlegrounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsWon = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LeaderId = table.Column<Guid>(nullable: false),
                    InstanceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battlegrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Battlegrounds_Characters_LeaderId",
                        column: x => x.LeaderId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dungeons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InstanceName = table.Column<string>(nullable: true),
                    AvailableBosses = table.Column<int>(nullable: false),
                    Difficulty = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    LeaderId = table.Column<Guid>(nullable: false),
                    KeyIncrease = table.Column<int>(nullable: true),
                    Succes = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dungeons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dungeons_Characters_LeaderId",
                        column: x => x.LeaderId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raids",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InstanceName = table.Column<string>(nullable: true),
                    AvailableBosses = table.Column<int>(nullable: false),
                    Difficulty = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    LeaderId = table.Column<Guid>(nullable: false),
                    BossesKilled = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raids_Characters_LeaderId",
                        column: x => x.LeaderId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArenaCharacter",
                columns: table => new
                {
                    ArenaId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArenaCharacter", x => new { x.ArenaId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_ArenaCharacter_Arenas_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arenas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArenaCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BattlegroundCharacter",
                columns: table => new
                {
                    BattlegroundId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattlegroundCharacter", x => new { x.BattlegroundId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_BattlegroundCharacter_Battlegrounds_BattlegroundId",
                        column: x => x.BattlegroundId,
                        principalTable: "Battlegrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattlegroundCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DungeonCharacter",
                columns: table => new
                {
                    DungeonId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungeonCharacter", x => new { x.DungeonId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_DungeonCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DungeonCharacter_Dungeons_DungeonId",
                        column: x => x.DungeonId,
                        principalTable: "Dungeons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaidCharacter",
                columns: table => new
                {
                    RaidId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidCharacter", x => new { x.RaidId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_RaidCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaidCharacter_Raids_RaidId",
                        column: x => x.RaidId,
                        principalTable: "Raids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "IsRaidLeader", "IsWarlord", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "martin.foler@mail.com", false, false, false, "Martin Foler", "MartinF@2021" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "suzy.galliger@mail.com", true, false, false, "Suzy Galliger", "SuzyG@2021" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "n.romanov@avengers.com", false, false, false, "Natasha Romanov", "BruceHulkyBrenner" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "superman@justiceleague.com", false, true, false, "Clark Joseph Kent", "Kal-El@DeadKrypton" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "brucewayne@wayne.com", false, false, false, "Bruce Wayne", "IamBatman" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Tgemini@mail.com", false, false, false, "Tom Gemini", "Gemini@2021" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "geralt@witcher.com", false, false, false, "Geralt of Rivia", "Yennefer123" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Olorin@aman.com", false, false, true, "Gandalf", "TrueWhiteWizard" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Ellesar@gondor.com", false, false, false, "Aragorn", "Anduril@FlameOfTheWest" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "capt.america", false, false, false, "Captain America", "PeggyCarter" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ArenaRating", "BattlegroundRating", "Class", "ItemLevel", "Level", "Name", "Role", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0001-000000000000"), 0.0, 0.0, "Death Knight", 167, 60, "Ghortak", "Tank", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0028-000000000000"), 0.0, 0.0, "Druid", 152, 60, "Phandalor", "Healer", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0027-000000000000"), 0.0, 0.0, "Monk", 152, 60, "Bromir", "Dps", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0026-000000000000"), 0.0, 0.0, "Rogue", 169, 60, "Yreleth", "Dps", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0025-000000000000"), 0.0, 0.0, "Warrior", 177, 60, "GilGalad", "Tank", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0024-000000000000"), 0.0, 0.0, "Mage", 192, 60, "Coolbone", "Dps", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0023-000000000000"), 0.0, 0.0, "Hunter", 188, 60, "Umbrion", "Dps", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0022-000000000000"), 0.0, 0.0, "Death Knight", 187, 60, "Ashifal", "Dps", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0021-000000000000"), 0.0, 0.0, "Demon Hunter", 157, 60, "Malefikh", "Dps", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0020-000000000000"), 0.0, 0.0, "Warlock", 139, 60, "Morgoroth", "Dps", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0019-000000000000"), 0.0, 0.0, "Druid", 199, 60, "Eranthil", "Healer", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0018-000000000000"), 0.0, 0.0, "Shaman", 201, 60, "Baradhor", "Healer", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0017-000000000000"), 0.0, 0.0, "Monk", 201, 60, "Trech", "Healer", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0016-000000000000"), 0.0, 0.0, "Paladin", 202, 60, "Aeternus", "Healer", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0015-000000000000"), 0.0, 0.0, "Rogue", 187, 60, "Tyrigon", "Dps", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0014-000000000000"), 0.0, 0.0, "Priest", 187, 60, "Ebrothil", "Dps", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0013-000000000000"), 0.0, 0.0, "Shaman", 185, 60, "Rhamanji", "Dps", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0012-000000000000"), 0.0, 0.0, "Mage", 145, 60, "Nuremor", "Dps", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0011-000000000000"), 0.0, 0.0, "Monk", 193, 60, "Ghinin", "Tank", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0010-000000000000"), 0.0, 0.0, "Demon Hunter", 145, 60, "Aerenthil", "Dps", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0009-000000000000"), 0.0, 0.0, "Paladin", 200, 60, "Liutasil", "Tank", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0008-000000000000"), 0.0, 0.0, "Hunter", 196, 60, "Wildstrider", "Dps", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0007-000000000000"), 0.0, 0.0, "Warrior", 175, 60, "Borugor", "Dps", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0006-000000000000"), 0.0, 0.0, "Mage", 187, 60, "Tary", "Dps", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0005-000000000000"), 0.0, 0.0, "Warlock", 149, 60, "Elen", "Dps", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0004-000000000000"), 0.0, 0.0, "Shaman", 216, 60, "Yoriko", "Healer", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0003-000000000000"), 384.0, 192.0, "Priest", 131, 60, "Shiroe", "Healer", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0002-000000000000"), 0.0, 0.0, "Druid", 216, 60, "Bauglir", "Dps", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0029-000000000000"), 0.0, 0.0, "Hunter", 174, 60, "Myriad", "Dps", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0030-000000000000"), 0.0, 0.0, "Warrior", 210, 60, "Ithaela", "Dps", new Guid("00000000-0000-0000-0000-000000000010") }
                });

            migrationBuilder.InsertData(
                table: "Arenas",
                columns: new[] { "Id", "Date", "IsWon", "LeaderId" },
                values: new object[,]
                {
                    { new Guid("00000000-0008-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0001-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0002-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0003-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0004-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0018-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Battlegrounds",
                columns: new[] { "Id", "Date", "InstanceName", "IsWon", "LeaderId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0005-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warsong Gulch", true, new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twin Peaks", true, new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twin Peaks", false, new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twin Peaks", true, new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warsong Gulch", true, new Guid("00000000-0000-0000-0022-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Dungeons",
                columns: new[] { "Id", "AvailableBosses", "Date", "Difficulty", "InstanceName", "KeyIncrease", "LeaderId", "Succes" },
                values: new object[,]
                {
                    { new Guid("00000001-0000-0000-0000-000000000000"), 4, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "De Other Side", null, new Guid("00000000-0000-0000-0030-000000000000"), true },
                    { new Guid("00000004-0000-0000-0000-000000000000"), 4, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic", "Plaguefall", null, new Guid("00000000-0000-0000-0009-000000000000"), true },
                    { new Guid("00000008-0000-0000-0000-000000000000"), 5, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic+ 8", "Sanguine Depths", null, new Guid("00000000-0000-0000-0011-000000000000"), false },
                    { new Guid("00000007-0000-0000-0000-000000000000"), 5, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic+ 7", "Theater of Pain", 1, new Guid("00000000-0000-0000-0011-000000000000"), true },
                    { new Guid("00000006-0000-0000-0000-000000000000"), 4, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic+ 5", "Halls of Atonement", 2, new Guid("00000000-0000-0000-0011-000000000000"), true },
                    { new Guid("00000005-0000-0000-0000-000000000000"), 4, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic", "Spires of Ascension", null, new Guid("00000000-0000-0000-0009-000000000000"), true },
                    { new Guid("00000002-0000-0000-0000-000000000000"), 3, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Mists of Tirna Scithe", null, new Guid("00000000-0000-0000-0030-000000000000"), true },
                    { new Guid("00000003-0000-0000-0000-000000000000"), 4, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "The Necrotic Wake", null, new Guid("00000000-0000-0000-0030-000000000000"), true }
                });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "AvailableBosses", "BossesKilled", "Date", "Difficulty", "InstanceName", "LeaderId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000000"), 10, 10, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria", new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), 10, 10, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria", new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), 10, 10, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria", new Guid("00000000-0000-0000-0024-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ArenaCharacter",
                columns: new[] { "ArenaId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000000-0010-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0004-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0003-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0002-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "BattlegroundCharacter",
                columns: new[] { "BattlegroundId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "DungeonCharacter",
                columns: new[] { "DungeonId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0021-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0029-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0027-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0021-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0027-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0029-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0021-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0027-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0029-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "RaidCharacter",
                columns: new[] { "RaidId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArenaCharacter_CharacterId",
                table: "ArenaCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Arenas_LeaderId",
                table: "Arenas",
                column: "LeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_BattlegroundCharacter_CharacterId",
                table: "BattlegroundCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Battlegrounds_LeaderId",
                table: "Battlegrounds",
                column: "LeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DungeonCharacter_CharacterId",
                table: "DungeonCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Dungeons_LeaderId",
                table: "Dungeons",
                column: "LeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RaidCharacter_CharacterId",
                table: "RaidCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Raids_LeaderId",
                table: "Raids",
                column: "LeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArenaCharacter");

            migrationBuilder.DropTable(
                name: "BattlegroundCharacter");

            migrationBuilder.DropTable(
                name: "DungeonCharacter");

            migrationBuilder.DropTable(
                name: "RaidCharacter");

            migrationBuilder.DropTable(
                name: "Arenas");

            migrationBuilder.DropTable(
                name: "Battlegrounds");

            migrationBuilder.DropTable(
                name: "Dungeons");

            migrationBuilder.DropTable(
                name: "Raids");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
