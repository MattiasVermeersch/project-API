using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateCharacterPvpInstanceEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BattlegroundRating",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ArenaRating",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

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
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 384, 192 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

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
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });

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
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "BattlegroundRating",
                table: "Characters",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "ArenaRating",
                table: "Characters",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 384.0, 192.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0010-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0011-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0012-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0013-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0014-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0015-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0016-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0017-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0018-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0019-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0020-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0021-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0022-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0023-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0024-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0025-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0026-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0027-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0028-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0029-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0030-000000000000"),
                columns: new[] { "ArenaRating", "BattlegroundRating" },
                values: new object[] { 0.0, 0.0 });
        }
    }
}
