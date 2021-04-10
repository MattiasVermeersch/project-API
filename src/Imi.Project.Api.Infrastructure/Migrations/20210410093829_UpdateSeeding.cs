using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 1301, 1079, 165 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 496, 1812 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 160, 1940, 215 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 1448, 395, 166 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 1538, 1814, 223 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1788, 1980 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 1607, 1652, 199 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 1385, 258, 222 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 424, 54 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0010-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 38, 538 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0011-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1279, 746 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0012-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 64, 1586 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0013-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 210, 1322 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0014-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 30, 1825 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0015-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 937, 885 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0016-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 517, 194 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0017-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 983, 1337 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0018-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1107, 64 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0019-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1810, 1648 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0020-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 344, 637 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0021-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1356, 1849 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0022-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1309, 2057 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0023-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1029, 296 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0024-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1401, 890 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0025-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1467, 1230 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0026-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1804, 1386 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0027-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 1910, 48 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0028-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 46, 1185 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0029-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 618, 944 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0030-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "Class", "ItemLevel" },
                values: new object[] { 604, 1808, "Paladin", 201 });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "AvailableBosses", "BossesKilled", "Date", "Difficulty", "InstanceName" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000000"), 10, 4, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" },
                    { new Guid("50000000-0000-0000-0000-000000000000"), 10, 4, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "ageydon0@marriott.com", true, "Aldwin Geydon", "Ct7JR2FEL" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Email", "IsAdmin", "IsRaidLeader", "Name", "Password" },
                values: new object[] { "cwoodland1@reference.com", false, true, "Clem Woodland", "GwV08icD" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Email", "IsRaidLeader", "Name", "Password" },
                values: new object[] { "msemeniuk2@prweb.com", true, "Mil Semeniuk", "0Sm8bO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Email", "IsRaidLeader", "IsWarlord", "Name", "Password" },
                values: new object[] { "awasbey3@google.it", false, true, "Aurel Wasbey", "YjYpKO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Email", "IsWarlord", "Name", "Password" },
                values: new object[] { "jingyon4@hao123.com", true, "Jackson Ingyon", "uTyKrtdJ6pk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "legell5@wikispaces.com", "Lucho Egell", "U64vxCUx" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "gbortolozzi6@friendfeed.com", "Giavani Bortolozzi", "4BR3Mr40YsD" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Email", "IsWarlord", "Name", "Password" },
                values: new object[] { "cmair7@dion.ne.jp", false, "Casie Mair", "sPcKvSnIoeEH" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "mrispine8@is.gd", "Madalena Rispine", "iQYb77c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "browena9@springer.com", "Broderick Rowena", "fWs8Sa" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "IsRaidLeader", "IsWarlord", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000027"), "rgabbyq@mozilla.org", false, false, false, "Reynold Gabby", "VcaYtXSUXm" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "pshillt@simplemachines.org", false, false, false, "Pooh Shill", "Hmb5OnSOKr" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "lgregorioua@storify.com", false, false, false, "Lenna Gregoriou", "P49llZ049pz" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "teastamb@phoca.cz", false, false, false, "Timi Eastam", "DfHR3lv2" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "glidierthc@freewebs.com", false, false, false, "Gweneth Lidierth", "uJd67JjN4tVh" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "lduttond@canalblog.com", false, false, false, "Lesya Dutton", "2gnClUF8" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "hfyerse@dmoz.org", false, false, false, "Hedvige Fyers", "L970io8cwz" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "nhalworthf@ezinearticles.com", false, false, false, "Nehemiah Halworth", "em18c5ls" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "rphing@europa.eu", false, false, false, "Robinetta Phin", "uRrbRG8co4w" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "cdirrh@ucsd.edu", false, false, false, "Correy Dirr", "HO5p9jajWl9" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "zferrerasi@cisco.com", false, false, false, "Zelda Ferreras", "8UV6YqrR" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "pninnisj@wix.com", false, false, false, "Paddy Ninnis", "1dFoZSvdA" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "jnindk@github.io", false, false, false, "Jeanna Nind", "s1cRs43a7" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "drichfordl@economist.com", false, false, false, "Darius Richford", "SebyyqXenu" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "cscocrofts@facebook.com", false, false, false, "Concettina Scocroft", "GzsICdL08z" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "mbaxstaren@mysql.com", false, false, false, "Micheil Baxstare", "2xhK9m1599T5" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "tklainero@admin.ch", false, false, false, "Terrance Klainer", "VbJgKJIIHVJo" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "klocklessp@un.org", false, false, false, "Killian Lockless", "Z6st864D" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "obartar@vistaprint.com", false, false, false, "Opaline Barta", "XW1MzRu" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "lsiebertm@mapy.cz", false, false, false, "Lindy Siebert", "5RI8u1feojGH" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ArenaRating", "BattlegroundRating", "Class", "IsDeleted", "ItemLevel", "Level", "Name", "Role", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0050-000000000000"), 639, 713, "Druid", false, 163, 60, "Laryngo", "Healer", new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0068-000000000000"), 1903, 1621, "Demon Hunter", false, 159, 60, "Orokki", "Dps", new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0067-000000000000"), 724, 439, "Paladin", false, 218, 60, "Stumpe", "Dps", new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0066-000000000000"), 1686, 709, "Mage", false, 209, 60, "Wulaer", "Dps", new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("00000000-0000-0000-0065-000000000000"), 547, 1767, "Shaman", false, 226, 60, "Squard", "Dps", new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("00000000-0000-0000-0064-000000000000"), 2004, 431, "Monk", false, 212, 60, "Thalgu", "Dps", new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("00000000-0000-0000-0063-000000000000"), 1291, 517, "Hunter", false, 224, 60, "Caitli", "Dps", new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0062-000000000000"), 739, 982, "Mage", false, 223, 60, "Cragho", "Dps", new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0069-000000000000"), 1516, 1267, "Warlock", false, 188, 60, "Sterne", "Dps", new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0061-000000000000"), 2068, 418, "Demon Hunter", false, 214, 60, "Lyrand", "Tank", new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0059-000000000000"), 1645, 1726, "Monk", false, 177, 60, "Elioth", "Healer", new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0058-000000000000"), 515, 2005, "Shaman", false, 161, 60, "Talade", "Healer", new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0057-000000000000"), 1072, 2055, "Rogue", false, 177, 60, "Lloydyr", "Dps", new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0056-000000000000"), 1147, 161, "Paladin", false, 202, 60, "Pillia", "Healer", new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0055-000000000000"), 1966, 1297, "Demon Hunter", false, 165, 60, "Falfda", "Dps", new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0054-000000000000"), 1447, 9, "Rogue", false, 200, 60, "Mimtoth", "Dps", new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0053-000000000000"), 1604, 1119, "Death Knight", false, 158, 60, "Asfaloth", "Dps", new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0060-000000000000"), 306, 1307, "Demon Hunter", false, 208, 60, "Kullem", "Dps", new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0052-000000000000"), 683, 1868, "Paladin", false, 161, 60, "Landarin", "Healer", new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0070-000000000000"), 1857, 1921, "Druid", false, 164, 60, "Zaldim", "Dps", new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0072-000000000000"), 862, 169, "Monk", false, 207, 60, "Reming", "Dps", new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0088-000000000000"), 1851, 1809, "Death Knight", false, 221, 60, "Rellan", "Tank", new Guid("00000000-0000-0000-0000-000000000030") },
                    { new Guid("00000000-0000-0000-0087-000000000000"), 1910, 645, "Mage", false, 206, 60, "Villia", "Dps", new Guid("00000000-0000-0000-0000-000000000029") },
                    { new Guid("00000000-0000-0000-0086-000000000000"), 238, 567, "Druid", false, 215, 60, "Alexil", "Dps", new Guid("00000000-0000-0000-0000-000000000029") },
                    { new Guid("00000000-0000-0000-0085-000000000000"), 1518, 306, "Hunter", false, 215, 60, "Deinon", "Dps", new Guid("00000000-0000-0000-0000-000000000029") },
                    { new Guid("00000000-0000-0000-0084-000000000000"), 522, 632, "Demon Hunter", false, 194, 60, "Aayunn", "Dps", new Guid("00000000-0000-0000-0000-000000000028") },
                    { new Guid("00000000-0000-0000-0083-000000000000"), 1807, 1995, "Shaman", false, 166, 60, "Bolynn", "Dps", new Guid("00000000-0000-0000-0000-000000000028") },
                    { new Guid("00000000-0000-0000-0082-000000000000"), 933, 1695, "Rogue", false, 203, 60, "Orghana", "Dps", new Guid("00000000-0000-0000-0000-000000000028") },
                    { new Guid("00000000-0000-0000-0071-000000000000"), 1876, 515, "Hunter", false, 183, 60, "Bluffw", "Dps", new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0081-000000000000"), 619, 1214, "Death Knight", false, 174, 60, "Riverh", "Dps", new Guid("00000000-0000-0000-0000-000000000027") },
                    { new Guid("00000000-0000-0000-0079-000000000000"), 1722, 2045, "Monk", false, 175, 60, "Pebble", "Tank", new Guid("00000000-0000-0000-0000-000000000027") },
                    { new Guid("00000000-0000-0000-0078-000000000000"), 1914, 306, "Demon Hunter", false, 201, 60, "Akzelo", "Tank", new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("00000000-0000-0000-0077-000000000000"), 241, 803, "Druid", false, 193, 60, "Mocarl", "Tank", new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("00000000-0000-0000-0076-000000000000"), 351, 1172, "Shaman", false, 166, 60, "Eunich", "Healer", new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("00000000-0000-0000-0075-000000000000"), 161, 685, "Shaman", false, 204, 60, "Statfo", "Healer", new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("00000000-0000-0000-0074-000000000000"), 1112, 1, "Priest", false, 173, 60, "Lantis", "Healer", new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("00000000-0000-0000-0073-000000000000"), 771, 1822, "Monk", false, 225, 60, "Merlac", "Healer", new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("00000000-0000-0000-0080-000000000000"), 1609, 1582, "Paladin", false, 182, 60, "Lyoria", "Healer", new Guid("00000000-0000-0000-0000-000000000027") },
                    { new Guid("00000000-0000-0000-0051-000000000000"), 611, 991, "Rogue", false, 220, 60, "Saveron", "Dps", new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0090-000000000000"), 1095, 271, "Priest", false, 192, 60, "Surest", "Healer", new Guid("00000000-0000-0000-0000-000000000030") },
                    { new Guid("00000000-0000-0000-0049-000000000000"), 1654, 85, "Warrior", false, 210, 60, "Sylvar", "Dps", new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0089-000000000000"), 1703, 965, "Priest", false, 173, 60, "Brann", "Healer", new Guid("00000000-0000-0000-0000-000000000030") },
                    { new Guid("00000000-0000-0000-0031-000000000000"), 73, 522, "Druid", false, 170, 60, "Malfurion", "Tank", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0032-000000000000"), 630, 421, "Priest", false, 193, 60, "Faron", "Dps", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0033-000000000000"), 505, 976, "Rogue", false, 209, 60, "Krilli", "Dps", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0034-000000000000"), 1679, 1013, "Hunter", false, 163, 60, "Fandor", "Dps", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0036-000000000000"), 1423, 418, "Hunter", false, 195, 60, "Aokie", "Dps", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0037-000000000000"), 151, 723, "Paladin", false, 199, 60, "Laughen", "Healer", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0038-000000000000"), 656, 80, "Druid", false, 189, 60, "Gartand", "Healer", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0039-000000000000"), 276, 1873, "Warrior", false, 166, 60, "Variann", "Dps", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0035-000000000000"), 1724, 1117, "Monk", false, 203, 60, "Marissa", "Tank", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0041-000000000000"), 1265, 357, "Druid", false, 224, 60, "Aralon", "Tank", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0040-000000000000"), 147, 1057, "Demon Hunter", false, 176, 60, "Irridan", "Dps", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0047-000000000000"), 1533, 1541, "Hunter", false, 160, 60, "Feeky", "Dps", new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0046-000000000000"), 1287, 1675, "Hunter", false, 205, 60, "Meeky", "Dps", new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0045-000000000000"), 1707, 1831, "Warrior", false, 164, 60, "Clerence", "Tank", new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0048-000000000000"), 1771, 904, "Hunter", false, 190, 60, "Beeky", "Dps", new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0043-000000000000"), 711, 114, "Hunter", false, 189, 60, "Tharon", "Dps", new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0042-000000000000"), 401, 626, "Paladin", false, 205, 60, "Sharyn", "Tank", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0044-000000000000"), 620, 866, "Rogue", false, 159, 60, "Phyrin", "Dps", new Guid("00000000-0000-0000-0000-000000000015") }
                });

            migrationBuilder.InsertData(
                table: "RaidCharacter",
                columns: new[] { "RaidId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0031-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0032-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0033-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0034-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0035-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0036-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0037-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0038-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0039-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0040-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0041-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0042-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0043-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0044-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0045-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0046-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0047-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0048-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0049-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0050-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0051-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0052-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0053-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0054-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0055-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0056-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0057-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0058-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0059-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0060-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0061-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0062-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0063-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0064-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0065-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0066-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0067-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0068-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0069-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0070-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0071-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0072-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0073-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0074-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0075-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0076-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0077-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0078-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0079-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0080-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0081-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0082-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0083-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0084-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0085-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0086-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0087-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0088-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0089-000000000000"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0090-000000000000"));

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") });

            migrationBuilder.DeleteData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 0, 0, 167 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 384, 192, 131 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 0, 0, 216 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 0, 0, 149 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 0, 0, 175 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "ItemLevel" },
                values: new object[] { 0, 0, 196 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0010-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0011-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0012-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0013-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0014-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0015-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0016-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0017-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0018-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0019-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0020-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0021-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0022-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0023-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0024-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0025-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0026-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0027-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0028-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0029-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0030-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating", "Class", "ItemLevel" },
                values: new object[] { 0, 0, "Warrior", 210 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "martin.foler@mail.com", false, "Martin Foler", "MartinF@2021" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Email", "IsAdmin", "IsRaidLeader", "Name", "Password" },
                values: new object[] { "suzy.galliger@mail.com", true, false, "Suzy Galliger", "SuzyG@2021" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Email", "IsRaidLeader", "Name", "Password" },
                values: new object[] { "n.romanov@avengers.com", false, "Natasha Romanov", "BruceHulkyBrenner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Email", "IsRaidLeader", "IsWarlord", "Name", "Password" },
                values: new object[] { "superman@justiceleague.com", true, false, "Clark Joseph Kent", "Kal-El@DeadKrypton" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Email", "IsWarlord", "Name", "Password" },
                values: new object[] { "brucewayne@wayne.com", false, "Bruce Wayne", "IamBatman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Tgemini@mail.com", "Tom Gemini", "Gemini@2021" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "geralt@witcher.com", "Geralt of Rivia", "Yennefer123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Email", "IsWarlord", "Name", "Password" },
                values: new object[] { "Olorin@aman.com", true, "Gandalf", "TrueWhiteWizard" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Ellesar@gondor.com", "Aragorn", "Anduril@FlameOfTheWest" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "capt.america", "Captain America", "PeggyCarter" });
        }
    }
}
