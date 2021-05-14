using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateCharacterAndSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_UserId1",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_UserId1",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "8af57707-f944-48b9-81b5-38b7ac39bfc7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "82325881-34a0-4ed3-8cf3-33586def583c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "c2fd7745-907b-4618-a332-d9cd45f96b4d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-000000000004", "75d719c3-9aa8-4ba6-91d1-1fee4682fc0b", "GuildMember", "GUILDMEMBER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "ee402304-3ad5-4752-bd1a-653ab37cc533", "AQAAAAEAACcQAAAAEPw9g541PAWtCjNiJVF1N+re5Uej8ajVN6xku2D0jX515mfi4w+sLtsdQ1hXUcmc9g==", "7ba3b998-ac2c-4d48-8645-a518f343d591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "3d901c01-b72f-4587-b95c-f098a262e61b", false, "AQAAAAEAACcQAAAAEBOhG7527X71op+MehQTURiOi42my0n4WJ2Syy1p7wDgaeoTq/c4WQz1MxOewwSKMg==", "34aeb52e-3232-4a0c-8ea7-6bb28d1744dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "7de5f209-22b9-4a3f-8ded-19df1c5eb700", "AQAAAAEAACcQAAAAEGLPEdA/UobgBm1humrqHaXXLg7PsAtc6Kg5kchEPdocKWEpFftlESTX5xvP4lDe1Q==", "8a3f437c-57c9-4074-b636-23e83520222e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "0f16894d-8e30-4aaa-a8d1-a6cc21f4bd6b", "AQAAAAEAACcQAAAAEPvHPMLvLrL4rZAJrO6C3XagglaDBKbm64JDe9B0sPxhmQVXZZ2x8VvAyzkYyS5s/A==", "9983770f-ba2c-45b7-8fa8-ec811b20fc1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "30b10550-69a8-4168-804a-a8919d72a17d", false, "AQAAAAEAACcQAAAAEF7J6mzpktRDRrftXthhtkdiedAob7sD1sBtaqxkG6+K+m/5IMbpe31wEWkcHAAfIA==", "f13cfc98-e121-4fc0-8e55-f6130f37f6d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "48aa25ee-9a48-4378-a539-f29469792dfb", false, "AQAAAAEAACcQAAAAEJ4hQRhpzrmOhF+cO7Vkb+LOk06v2NkRF8G8jF5u7WVnNVVipTW0XqPqyck3TQC5ww==", "6fdd2d9c-9cd5-4442-b426-e7d363636585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "096c0b33-653a-4ceb-bc70-c804cc29c235", true, "AQAAAAEAACcQAAAAEACxItEHvvyxDHbrIAO6xrcxlOT66hERrCvWI80BJPYZ0DPuD5f/K/249ftWOBxsJA==", "ac5c3a09-df5e-432d-a4cf-ec43e200c88c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "3d78360b-cd7a-4ad0-941d-cf7570f08602", "AQAAAAEAACcQAAAAEI7f2YI30gSOTLtdx2oHWLzk5sBW137c1teXQJ9/avCbCCKV3yRPR8gyRImiq9WVgg==", "9eb63640-41d1-438c-b60a-c7b55e60771e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "8fcdba20-cc36-4c5b-bd0c-3846da41e98c", true, "AQAAAAEAACcQAAAAEAtZEVhKsQkWdCKgwD7AFYDjPBrfa86yZaIzazA2UAf+qxawfrNTTuzji2PrTCtkxQ==", "b7eb3579-0ec4-484a-a8ed-09cc0665b98b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "27eeed31-4d4e-433e-a591-44fb0eb9aa87", "AQAAAAEAACcQAAAAEEJ0DjXvBKGYjyOUJuDXAQaGomeHNXcKnTcbDQGq2cb/mmlru3LnZm8ofMy7xh7eGw==", "3be992c4-3973-4c72-a83f-e06a8f8f3c0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "b5267d71-0922-4c1f-90c9-3d77666de3a4", false, "AQAAAAEAACcQAAAAEEjRwbYl3Ta800SfX1xah4tXeqghsfnYpnsIw/usCaL1LiDA8k0/HyKZD4LiNB7mwQ==", "ebb6d90c-fb0c-48a2-a9b5-6265d976bcb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1983, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "8ba7e6d6-1577-4c0c-b69c-0e3c79961925", false, "AQAAAAEAACcQAAAAEPR3zR0+SMHIasE/fVJgr1sZCd8LqxvQFB02kHpQZy8vmAKt9cjQFKzAC3901tfvkg==", "b8e3b66c-e181-4198-afec-0f4970a0c947" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "8ccc687b-a1c9-45b9-bc8c-abbc0796b0a5", "AQAAAAEAACcQAAAAELuQ181FUpQRHDw0Z7P8Ex5rSi+m7zjGYFGubGYCeNBRzYvatGA8rEEIqD3HTUn+Pw==", "3d940b65-b826-499b-a2cb-69a7ebd07e0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "c13de9d0-7d9d-4d3c-88d2-7a1ed4a07efa", "AQAAAAEAACcQAAAAEDKWZOaBGfLz/36QxAEcM/wivAvivhYX06YV93UjIszIna3tg2W77qnukqvAdzKX0w==", "0f270c1f-4ae8-4fc2-86e3-242687b17f5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "801bd66c-4c20-4ac4-b18e-f5a8e45be67a", "AQAAAAEAACcQAAAAEFZKh6DhODraUaKRUZe5XycefqOPJ3mf6YDSYF8Kf6WqyDYTHY/+dX6f1pDHZAYyoQ==", "759cc28d-3ae8-4d70-89c7-2aaed763e333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "10c26f50-749f-4597-b27c-861099f604fa", "AQAAAAEAACcQAAAAED1GxlQhWSe96pQE9cTrt0L3ShOotHu349tEPFBXtm7vCA/hWYbayWkXZrImK3Tmig==", "72da2dee-59c8-48bd-aa51-fcef0dead618" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "b9667bb1-3c35-4e01-9e1d-b639f3038552", true, "AQAAAAEAACcQAAAAEBR0rT1Fm+fiRZ/XvPAjxrGFCw7AgJxMkuBDEZILU9V8/mciCjUxolmp9kMSwISbrg==", "0f143386-95af-42a4-b1cd-3cb512bc6a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "50d5e469-a8ec-425a-a12e-67e705d3adb0", "AQAAAAEAACcQAAAAEIc9IPdwe5zpaG7FqQWO6APYaHqojgxwDHzQuD5Y9+1uYkOrwyFYo8nIvR/7srlmrw==", "60829b7c-ec9d-40a8-aa22-05103b4261f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "edafb93b-fb57-498c-8e16-7bed2b364247", true, "AQAAAAEAACcQAAAAEEhg+BRzyJ/Do4Oy4h8cIHmBkmOUxLdMFA5bO6IEoGc12aALPYwmCBHQQKzcOGTtvw==", "ace8155e-19ca-4915-ab72-9c299508befa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "5823715a-48a6-4e01-8e7f-66edc384a70b", "AQAAAAEAACcQAAAAEMdd8JJi7+dW1MDG+zEhoTAa4HxRQXrOAfY7l24x6+PR3DycrS/NUQwZmb1WZ/Kf/w==", "97d1ebf6-0f18-412b-b8df-2d48cb96c4d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "93f9bc8c-e4ad-4d67-a15a-7dbb57522bbe", "AQAAAAEAACcQAAAAEAIjejEELryk3H/nCFRu6PyRjSqas96xyB9G3FEqQzEAsqxDtRovm5a2CF3Vn9rh0A==", "d6a87cd5-2fbf-4eb7-a04b-b86e895ea379" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "2c5eb749-8c02-4654-aeac-d9ecd58b59a5", "AQAAAAEAACcQAAAAEHis0KbT2Qn7zCr1eRGoTaSXSyxUwp+9TF911WAqpqHCSdGuU4CCqODaXIBg4ScCAA==", "d25bb90a-5f08-4979-b6e9-605483d37360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "b94366f0-9111-498f-b11c-11e31dbcd3d7", true, "AQAAAAEAACcQAAAAEHw9vrxhnpjWsKZNgcrflgQkB8n6CsWzsnrPntoF/rchbMQnYC8DIQPjPOrxMV+NXw==", "93dbd751-35e7-4de7-8d11-024b5e7f71f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "436d02cd-3135-46fe-9d3d-0e6a85129699", "AQAAAAEAACcQAAAAEAq48Xyeu3IBnulTFM53mVe1N5BsGdowCzL1NHVCdcU0EQK1oblBhe1f5qgX5ZvBXQ==", "4e510c68-a1b0-4d12-9d5e-b2606bf7c0f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1976, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "9ce420a3-a73e-450f-96ea-7c2793ce4930", "AQAAAAEAACcQAAAAELnWJnvzKP0/NPc6uy1WRrH1XAR9vJtoI7AdVGXjka0uN40bMDmwiZ4eY15rXiVCcQ==", "6a99f8cc-ce7e-4c49-a45a-7ca9a29fa8cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "4e2eb758-3cd5-4ecc-8748-5bd008cd8c89", true, "AQAAAAEAACcQAAAAEN2nWCQBqyoLeXOTVHqM16Px+Z82RaBslR86UMTJ3TxewU8arcDUzTH6jCvtMaljdQ==", "149f4aaa-e8a0-4765-95be-666a45ef8b26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "ff08983a-de43-4c1d-9bf6-fad69b25f7fa", false, "AQAAAAEAACcQAAAAEAkJxjFK9LPVFEXQpKzpeSxJAkVIC8CeekPJP8UgluCGXTWbFfEI+fzkjLotx+Whow==", "4becb962-1064-493c-9f12-bf842bc76075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "e295e7d2-f6dc-470a-abcf-d657a9ef9ffe", true, "AQAAAAEAACcQAAAAEBEC0V969+fVCns7d5WNBv4MSySpco1PJJAaeb+y9QvZqahaSxrNoDyU4oNl8PBBcA==", "98f52c80-08fc-4ed5-97ac-4cb986d58f81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "ca284ca5-c7f3-4678-a775-7c74048a564b", "AQAAAAEAACcQAAAAEAtgFf/9KzrMg6djVtC29Frzr0G7wHMhj0JNk92rJDO7doXn7HZ2e7p32URc29oxxg==", "2abfbc73-e85e-4147-8a5d-304d9a7b9b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "391fb449-1d7e-4d94-a4fe-2cb0727a0355", "AQAAAAEAACcQAAAAEB97Z8ULQT7kI4AhkfwmN63XjtUHnT7dDobEB38GLOwZfNI8NPORetKEbDr77BdO5w==", "fbd7761b-f790-46f4-ba6f-2520cd81330c" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0010-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0011-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0012-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0013-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0014-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0015-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0016-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0017-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0018-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0019-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0020-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0021-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0022-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0023-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0024-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0025-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0026-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0027-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0028-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0029-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0030-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0031-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0032-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0033-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0034-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0035-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0036-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0037-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0038-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0039-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0040-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0041-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0042-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0043-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0044-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0045-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0046-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0047-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0048-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0049-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0050-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0051-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0052-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0053-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0054-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0055-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0056-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0057-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0058-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0059-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0060-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0061-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0062-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0063-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0064-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0065-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0066-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0067-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0068-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0069-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0070-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0071-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0072-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0073-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0074-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0075-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0076-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0077-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0078-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0079-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0080-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0081-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0082-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0083-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0084-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0085-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0086-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0087-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0088-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000030");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0089-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000030");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0090-000000000000"),
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000030");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000028", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000027", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000026", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000025", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000024", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000023", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000022", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000021", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000020", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000029", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000018", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000016", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000014", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000012", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000010", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000008", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000030", "00000000-0000-0000-000000000004" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_UserId",
                table: "Characters",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_UserId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_UserId",
                table: "Characters");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000008", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000010", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000012", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000014", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000016", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000018", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000020", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000021", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000022", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000023", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000024", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000025", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000026", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000027", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000028", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000029", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000030", "00000000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "7cc62e79-d189-416e-b078-0baff608c457");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "e0c45924-6242-4504-8c22-a9e34e4be961");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "5ff04843-d3bf-4e31-8112-0006d3b35117");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "5ed68bc7-990f-4fbe-9f98-c977f9b2e81f", "AQAAAAEAACcQAAAAEGCaV1a/pt/VmjwetJl8PE6a4VT0Nda52XW6qNni6Dz3rIeDDCqfpX6X5/tpM+H9sA==", "2670dd13-1514-45ed-bdff-72e1ecae6848" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "108ac3d2-f677-449f-a5cf-ce5c58106aff", true, "AQAAAAEAACcQAAAAEGQh9lImQIn+S+Cd+ijixRFaWR0tkxKnAgEuMr4hR/vShvl8XWWlbvfGWDPNOt8/CA==", "1fe5e517-d930-4eb1-8b47-ceed8e81a770" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "03a575a0-0b81-4c43-8524-4d5f59cd7e74", "AQAAAAEAACcQAAAAEJOLU1lIwFT6mlEQeHEoX6H82jpJkp2DbMkAksl7gbi7l6UNtVhNC6+hXMiNSWgxjw==", "7731062b-b342-4615-aeb5-4a60daa0aac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "2f74f38a-8cc7-4172-8b23-5d1faf0eb721", "AQAAAAEAACcQAAAAEDkqDC6fLgWe80Q/2gRDgGFaVFFuTDYidLQhh92PosFDsDJPp1rPZVXryUXbKMS7Bg==", "22582c92-2c5c-4ac9-ae48-7e78ae1133e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "bfb74765-90ed-40eb-ac23-e0da4410af88", true, "AQAAAAEAACcQAAAAEJT8sY9JZRFljxmokHlugcPKKJeWySimCjg9RgbE7vKS/s4k5UBjTw4lj5GiQRghpg==", "ff6b0358-8b05-4044-a62d-60f4cbd1ad05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "de2af1f0-879e-4274-b1c4-40798e9653d0", true, "AQAAAAEAACcQAAAAEMvdpsjVGML/8uvnJuKCu1njK/TJlAhl2cmoMvadVZMaPn8t5qDoyDXKYoTqfzmo+A==", "7c55e2c9-4998-49ab-8b52-ceecc7f9de3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "c911ed88-c01d-40e3-8d99-dbbb6145a187", false, "AQAAAAEAACcQAAAAEA8B+HBPnzb3Be5pBFmeUJ0IUtJ73oWEoIJ7NKJH2lvLXU4PSMAmUKXz151V6e6bGw==", "906b596f-1049-4e35-a32d-b6d45d6da2ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d09cdbf0-cec9-42a6-808f-a9dbc9f185a2", "AQAAAAEAACcQAAAAEP6peZTaux3KZ4flJjHOa/YygMM1FlkAqFVINgvwzBD47fH9+iMa9ajbX2gTymzE1w==", "d1d78abd-ad15-4894-b1e9-de2a2b257856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "0d589640-ec9c-4b5b-a13d-9fff3e2321c1", false, "AQAAAAEAACcQAAAAEDXLRLlWbecTzeG14CLLJwIwGGGk6RCWdtfoKrqGaLbvegR/bFEJO4HP8AVmXVNjVg==", "d404f991-232a-45ce-aad0-ea61defed10b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "63287954-7065-4374-849d-d1e310c0200b", "AQAAAAEAACcQAAAAEENvvmZlIUEhdd4+cG1aMig8Iu23qKYECLTRp0n+IzlShGqqShLZicB/6eR4A22hRQ==", "19a5a86b-e5c6-445b-8613-ced9632f6091" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "50ad50fd-0a3f-4462-9f93-e7e340d953ab", true, "AQAAAAEAACcQAAAAEHFxi+yesvDP+nbhCiTlDji+gzwRZEa5jrL+RvZ3kSVx60oGhqOooBsrtIehn3vxPg==", "07213708-f144-4df7-b870-cebf14ec935d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1991, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "b83c3445-b665-4da5-a7a7-82f410f26c0f", true, "AQAAAAEAACcQAAAAENprEmdhm2Hc5GqXFrSLqg8KTQ1XwOnNWzFNaw3peVaImYC6MCrezsdXHYZMokIZsQ==", "b4a1dab6-f795-4cd6-842e-78e5edfcedb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "0cb0be54-e581-4a90-9944-0dc15558ff9e", "AQAAAAEAACcQAAAAEB6n0LCDcfWFYzIVVhlYyO60NyiXMcLmmBhLTNOmsy1oeaZ/iH1Ic5dSuwYd+7fi0Q==", "d0ef17ee-aa93-4af4-8d34-2a588ff2b09c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "36147dbb-7244-49fb-af3a-08620e166605", "AQAAAAEAACcQAAAAEC7FNQiDkNe5ThOkW161mk22NS1I6ZoEJHaL7+w8qmAoRHLca80TmZeAzQnsnj03Fw==", "d8dbec6a-509e-4d00-a29a-3fdf0d8078ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d163184c-ce29-4015-ad02-23bddf511b94", "AQAAAAEAACcQAAAAEEklSoX+r8ZOgvVqt2GyYQsq4L0sbsvLGP/4bH18MaPoVq3nrrnKoOjzE+Z2MSQGJQ==", "873f8bcb-3d38-4eb2-8a3e-951039e75bd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "d7251231-0bf9-48b1-8c18-aed90a198140", "AQAAAAEAACcQAAAAEML8KnWW4EhlflyTxN+OoyFOKB0MNdSA1TrurwsTx4W7WniAUweATVtBu3BCnvGgKw==", "a4fe4ef0-6e8f-47cb-8b72-a602bba8ce10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "818c5f11-4b07-4739-bd64-96669c88b02c", false, "AQAAAAEAACcQAAAAEELID0WuB2VlKJqYbcj4hbZDWYA3/PuYkRsPP/XD0dnsgvQlth7gPHYR3pg9syzmCQ==", "15c3c68d-ae13-4ca7-86bf-e975ba6e1982" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "d0d35676-1696-4d64-85d2-4215d2855442", "AQAAAAEAACcQAAAAEBfFDpvocomMS6TQFv+27Vg30O0QlfG+X7+TlBZhTVJ42XZKskvoZvWYtdZEThgmxA==", "0f5dd142-205f-4c20-af17-08765c615957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "2879d350-b849-47a7-a83e-1d9f3f448373", false, "AQAAAAEAACcQAAAAEHDW2DXmbjTxT3V1c5BPzENygghK6uMSAqcZcIMwCWHy9u9hMXWEMGMumx1nark70Q==", "e1886ad2-51a0-406d-a25f-f541ae6592ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "536bf459-be86-4a09-8637-3c91e0db2d77", "AQAAAAEAACcQAAAAEFnyJ9nyioeAzr/LaOUIv7E42F4AyhucW0hlzMOtrOb94Bknmqvi5DSm0LdvPxhlYA==", "1c4b0996-566f-45ce-b915-117aafbc2c35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "756e563f-1fb6-40f8-b6dd-88b41c1cef86", "AQAAAAEAACcQAAAAENGanqdWpReRgIFNxn/BvWESzRBvQleLxjnLRXfaVCB5Z1qdoQXhQ5SZzTsgubsErA==", "d4a6c226-6286-417b-93ac-818851c50109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "00d7bd3a-d200-4b80-9ec2-f80521b31a14", "AQAAAAEAACcQAAAAEIFBrTwLMqJsdcJob265DO8vEv2YlgOla2ciIm+Ed7wXD3qSUAilOLUQxAaKjUCqpQ==", "815fe8b2-c099-45e6-b492-aca8d79942a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ee4f24eb-b37b-439c-9cce-d3656aaf92f4", false, "AQAAAAEAACcQAAAAEAatX1KQJDeyP9p7eIR1RzTZypB/nltApTG7G8kHdPzCZwSoknCvsSBhBgen9yQ2ag==", "d05929e2-4ce6-4eb4-8f6c-c8a0ae5c6092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "b2b1cdd0-712f-4520-8708-8f22d99c8874", "AQAAAAEAACcQAAAAEA3zBplnm464NKqNgsVk5QkaO9145B/5pgi/wibst6XNxAIGebDud4w1fpBv5EFxnw==", "d270cdba-8245-41a0-a54c-70f845c7c26e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "49306ba5-c458-4e37-b41d-104e08965c1d", "AQAAAAEAACcQAAAAEGLulqk4bOC41ylhBtlhzDNRH7TQHIpb3rQ4nP2VAii1kqkhjlZpT39lPDQcgKgWhQ==", "a32b1513-89c4-4465-b102-059a18fc8203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "85fc2c23-ae60-4658-b2db-ece7321c0c29", false, "AQAAAAEAACcQAAAAEJU8hNE/AUSwvKLdsWqZpM+RxdWvycTGGuJir5WWpDTkMno5l30jsMFTf/RiwaNIAg==", "c268bf28-04eb-4442-8a3a-8d12590145c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "a09a2201-e276-448b-87d6-a247fa045c4b", true, "AQAAAAEAACcQAAAAEGkeaBBC+uSGgranQZGssKFTLTH+O/qIChnSwBXcaiFAh2XXpRPWU/bmDl0XQeZ/kg==", "5f77fd15-e677-4651-948e-2673ad0ad87e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "de2bd8cb-e86a-4128-876c-b99916d921b8", false, "AQAAAAEAACcQAAAAEEKgLOBP/fvjlYnFxL8Xm5VWb5Y0geemuz30sXPRUXQSxRS76ZMaRl8w38LlFmNwSQ==", "a9064620-8b7f-48f2-8fe7-57963b3f9a7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d9afed0c-1b03-4593-ae4e-32c92401d8dd", "AQAAAAEAACcQAAAAEBrL1yX2H6qZe/HLTBUuqIDrI70KX1WJjeKWgD9J+Hu47Ck1PsXt7HuWeoPsXkQomw==", "41fdf888-1eb5-4c26-9af6-fbb1296afc4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "cab1c41a-f412-48c2-858c-3ff4f93eaa53", "AQAAAAEAACcQAAAAEIKSfpyJ+t6h43CXbzeTJxUmIiIAeOpc+kEBOSEyZ3/QHW5BZCOUIDrSPv0LqeUF7w==", "c34c15f1-c3f9-4026-af03-da0f669afdba" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0010-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0011-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0012-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0013-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0014-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0015-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0016-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0017-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0018-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0019-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0020-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0021-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0022-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0023-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0024-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0025-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0026-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0027-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0028-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0029-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0030-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0031-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0032-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0033-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0034-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0035-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0036-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0037-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0038-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0039-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0040-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0041-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0042-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0043-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0044-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0045-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0046-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0047-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0048-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0049-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0050-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0051-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0052-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0053-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0054-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0055-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0056-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0057-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0058-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0059-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0060-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0061-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0062-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0063-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0064-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0065-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0066-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0067-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0068-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0069-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0070-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0071-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0072-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0073-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0074-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0075-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0076-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0077-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0078-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0079-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0080-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0081-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0082-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0083-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0084-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0085-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0086-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0087-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0088-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0089-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0090-000000000000"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId1",
                table: "Characters",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_UserId1",
                table: "Characters",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
