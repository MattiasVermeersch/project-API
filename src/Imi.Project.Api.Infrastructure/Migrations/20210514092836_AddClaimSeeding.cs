using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddClaimSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "75b3d80b-033d-47f8-91b3-bf4f64dfc683");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "18865642-796a-4198-9a16-d89967c2f418");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "3c6f9d39-8195-42d8-9a3e-ae3b8d12ada9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004",
                column: "ConcurrencyStamp",
                value: "422b5f3a-2ac8-496f-b0f2-21cef8150610");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 25,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 26,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 27,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 28,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 29,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 30,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 31,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 32,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 33,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 34,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 35,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 36,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 37,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 38,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 39,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 40,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 41,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 42,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 43,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 44,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 45,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 46,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 47,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 48,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 49,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 50,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 51,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 52,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 53,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 54,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 55,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 56,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 57,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 58,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 59,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000030");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 60,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000030");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 2, "has-characters", "true", "00000000-0000-0000-0000-000000000001" },
                    { 1, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000001" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "39f583bd-8f57-4366-9a87-03e132d6d9c2", "AQAAAAEAACcQAAAAECbZPoO93vQv0F1aBIMZ4tKtSXv4n87JNdVwBlfPpsBHwDiyNq3QQvrIGppPpvJdDA==", "b7eeed52-19e4-46bf-9bf8-96679d5f620b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1973, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "919b79cd-019e-4b1e-8b7f-e2404e8c2eec", "AQAAAAEAACcQAAAAEDzMpHW2MiSRGooXxhyYmom/5d5hkYO/TtzCmwvSmOW3JNPXhOLlSyoEt7bruzxVcg==", "b3b995f6-7ec6-4f38-9c66-6cf4a86a5746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "997c2365-d8c3-4ba9-b528-3ce8fdb30bb8", "AQAAAAEAACcQAAAAEJY1+ztRUuRbFIrJWJ1j+bLU1P6yWe2u55W68QHQSFNDGcjrZERHeeI1X/xaewTvxA==", "76e42442-022e-41ff-9165-691278501860" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "5ebd866d-a430-4e88-adce-699489241e8c", true, "AQAAAAEAACcQAAAAEH9Qy92mXCRSmrgYXNWHr/2uiMJ5kRRDVDC+tMgk5Fp3PogoRG9fDaeiw47aZGOWbA==", "b8cf80ea-51d1-4be8-9101-c71b70fbb149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "7a06f81d-32bb-4074-9f2b-3f6d016de35f", true, "AQAAAAEAACcQAAAAEJ9PA0X5jJDrE5ywo1llyxoOnyN/HUz5zviQBQFA9MeDwvCUHZ3JMANOgx0AGIAGXg==", "4343a7b2-8d24-4fa8-afc4-dfafb5ebd73c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "140889b6-d279-4eae-a3a3-9347fb66773e", "AQAAAAEAACcQAAAAEMbRfK3VsVwSpKNnbDWB7eOK02d0j9Yl53f50ZuaeAq3kLFDdZmy884ShYDqtdF3sg==", "e689808a-1287-4888-98ae-5c869607d4c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "d19156ff-8203-4503-933b-3dd4709787e4", "AQAAAAEAACcQAAAAECbRWOskqMxmOhUc6+puD1LUMg+uJmPnpxccpfwT6X8TJUbutHPKDv93zosSAkahhw==", "20e2ad0b-208c-40fd-bc97-463de08a9e8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "95f18a07-9fad-4204-8bcd-e14cb8211ff9", false, "AQAAAAEAACcQAAAAEJQVZg6u67cICtARQ3W7+u6hVAZONKTiVOvnelhlhtSKQ4EwfYK37nV/RwVar5wSaw==", "c1f2d62e-6083-430c-aeec-6c60c79d1135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1978, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "d65f69ca-c83f-4675-a127-1a3b0945e521", "AQAAAAEAACcQAAAAELjNWxlSWTHric+Z011wWJCM3Ps87aC3dMfRgjCY6u1pYJtYGQtD8kGsxIrnanljaw==", "0cca7718-af64-4241-b95a-eca9135f8d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "121711b0-685f-4d11-9926-e05c4da002b6", "AQAAAAEAACcQAAAAECKdB6iAZ8LZGqYBpAkpZDAsUhZxIp0U03KAGOAc31UpGkBDakmMPHvXpuJhu0eMiA==", "d2e4c436-c894-4020-8c05-1312e23233a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "1258fa3d-175e-4fbf-80c2-72288b3063ba", true, "AQAAAAEAACcQAAAAEM2emz3kIbT6A1LrOH/aICLcujO85GdnMMtuCdXdx8f8IQGlGAlQe0MK/VGt73nOag==", "047c385d-aa7c-49c4-9036-f54142ede268" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "2d0a98a0-80ee-48c8-a7e0-87f5692eaa4e", "AQAAAAEAACcQAAAAEBn2JN9ol9UgIfLCEzsypmj56QasGh0R/PK03VZNOXD/eWbekw9stOU0PG8sTHRKHw==", "0cac219d-7b19-4696-a181-4e6531ec5040" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "6ee6f76c-3d84-48e3-87a0-631417922f43", "AQAAAAEAACcQAAAAEH+LO1K0AIrQ9FbaLYTlQtvYAifrEhZlpdRcBvlGKEruuRt+PPNAvbDxbgedSV370Q==", "a7a9deb3-2e0e-4886-abb3-ef3610b4261b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "8396be6e-5502-4c93-b078-5248518b95c8", "AQAAAAEAACcQAAAAEBxh7M7IB5EC7CYOzotA9CnOvM+IZY/gUC+f9OlwmiyRWWShvl+YQnmCY78xWlhPUg==", "1d48c8d3-ad9d-4224-8ac8-915921b29263" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "0d69c356-5c4e-4439-90fd-84e8c9910cda", false, "AQAAAAEAACcQAAAAEM8KOqP94H4jhKoNaM57fMfStlDZdrI13KMCYkTBo7nfnIEZi4IdE8+Y1r+kdWsiRA==", "3c62ee53-b347-4a81-aa2a-30252035b4af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "302022c8-145c-4e3d-b76a-aade40d23099", true, "AQAAAAEAACcQAAAAEADnICpXU+iG+BSImwE3DiqAiRq7k3WQFix5hsdnAb27QeLxZCBCw/cHbSWCjNIbrw==", "c8306e6c-7fc0-462c-9844-18aaecb2925d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "acf72689-e9ef-4748-b7e2-dd528891b1e0", "AQAAAAEAACcQAAAAEMC2sSjgszEZgYHh8w6nNlI8SzVb/aJMBNRUj//CFDtHcLwqpNx+0UAZvYWKe6vVow==", "41f865e9-9cc8-481a-b671-0324b5eae1d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1983, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d578914b-dff5-4dba-9d9f-930a114fcc1f", "AQAAAAEAACcQAAAAEN4t8R9CrRbQm+Bk7DOzZmDdH8Y3DMi0DG8gLsjXpTT5LZbu8cesQC1Dzscn4sNbTQ==", "b18f7bb0-a77d-4e27-b6dc-86389b6f4286" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "2da29e45-7c76-4ec3-87aa-9ed3d8647cd3", "AQAAAAEAACcQAAAAEKxSWn7IhVTrJ0P/w9Zf0gabLkMWO5dsLXgeL5mz/0dYvi6JpvHOKPW4VT5gnu9o8A==", "add71354-be92-4d24-81ee-850802c6243c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "55080271-a8ce-4577-b130-bd13db0a719d", true, "AQAAAAEAACcQAAAAEFmArFSR86zNOrazDoMKFHs7yhHG1IfFEt3umrrrv93k9ssIgPTq5Z6gR91oqqRzJw==", "f3160320-12da-4c4c-bdc5-0206a312e036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "43687c90-ac1c-46f5-9a17-69d8bb4050aa", "AQAAAAEAACcQAAAAEHV4Pk5zWH7s4aEGqZ/4H3/AdVyMeGszeQsDwYgj8ZcjgU5Rt3axN4K6QnyabyWm6Q==", "d5df410b-3b60-4b67-95cd-d59f768fecf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "ba10f8f6-770e-41ef-8d5f-536d6ee5c456", "AQAAAAEAACcQAAAAEBRCrn8iTqvrhwJZJwwznITW/THq2BMRwdDn7wVb1ceHqk9yxZ0WxRVQSCe1JSUkAg==", "061b3738-e20c-429a-8645-653d1d7f8eaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "ca2cbd2b-1626-45f4-9a8a-344d3d088406", "AQAAAAEAACcQAAAAEDXxMT1Sek0wE/cmLvRjJKQJP0IWqkUk5YeYgoS6WM7B3Rec2Behm/Y+6hnBWoOdiQ==", "6eb23ab7-647d-477b-81e1-5da21ba1aa64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "b51726e6-42bc-4e37-a218-21bea233126a", true, "AQAAAAEAACcQAAAAEATuyeJuuG7jdnAw7LhLBPqDEQTuwkn8WCnne4VMX6Qg3hd3b+AtVVRoXGihs4qfjg==", "e0791858-3486-4447-bc7e-e5ea972e2172" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "e1b11504-a434-4681-8291-9b70a0793ce3", "AQAAAAEAACcQAAAAEBXxAtAnI53PJRULo1wvU11tOh4pMmBFGb1LLkgx7Ip6AsmfRBj/5Gwz+9/7g9sHcg==", "cf1a89c1-fb7c-421e-aa17-f1860a1351e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1973, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "0199653e-71c7-4bb3-aa20-760c5948f974", "AQAAAAEAACcQAAAAEBG84/22KdztX2+zCtxNw6zqm8015xn4siQoNktMvDcYnNTZLO5/nnJym4/ngMx/zA==", "ffc376ca-1cc2-4e12-a850-2653082137c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "bb96153f-b1db-4cc6-a028-e5d023380304", true, "AQAAAAEAACcQAAAAEH9GC+uKJqABuDXDgrgNkd6JExnJ7xvvaKVM6ar3wCafsBJOuioqpEETHyuYHUxORg==", "6faf00b8-b2a3-40ed-aca5-91adc93b5a69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "590930c2-694d-4664-98b0-a53a157ce4c3", "AQAAAAEAACcQAAAAEMh2VU3357zAoyEgvtdYgrK8ajf1YpVo7SfsYTFwYU/TfSlgazEjdv8IYeg2fgngJQ==", "c15d5a86-ec7b-44b5-aaa7-59ccf58cc910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "5b55d8e7-d26e-44ce-ad3d-df58fe39e8f2", true, "AQAAAAEAACcQAAAAEDBHfEykCPTUHCFYGBdir7xBQu6He0ErX247Q24D7r7BNE5JN7dyfks7uUVKbfsnuA==", "4d6d90b7-276f-4239-b9d3-327d0172d8a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "65498488-54e0-4b9f-abaf-7eadb49f9232", "AQAAAAEAACcQAAAAEA7ZA5F/7wva3FRWAeunexzE5HUEQStpnDCoVePhALjS2v9grgFmbPGGZo/Xwl+s6A==", "aeb65d62-b26d-490e-b668-90d81e56369a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "3e6de620-a79a-4d95-ba31-8d35539fd924");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "affe471e-b2fe-4668-8afa-893f5f1bc7bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "5b987251-c75f-4afe-80ce-e7d21aa44219");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004",
                column: "ConcurrencyStamp",
                value: "27980847-4962-4d59-92fa-7ccf087e1d70");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 25,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 26,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 27,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 28,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 29,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 30,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 31,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 32,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 33,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 34,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 35,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 36,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 37,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 38,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 39,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 40,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 41,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 42,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 43,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 44,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 45,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 46,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 47,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 48,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 49,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 50,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 51,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 52,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 53,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 54,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 55,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 56,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 57,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 58,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 59,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 60,
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 62, "has-characters", "true", "00000000-0000-0000-0000-000000000030" },
                    { 61, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000030" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "c817f505-76ec-4891-a874-8ae04545a30b", "AQAAAAEAACcQAAAAELc+ZXXgnZCXBN6hbp4Bnl+8JDqVRLsZE4aZmT4CVc4tATItWFWLklbgst7EKGi/Yw==", "0304f228-d8b6-4677-a740-96246fb71657" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "2188ef7a-7825-43a7-a7c1-aed4f3bcc288", "AQAAAAEAACcQAAAAEHjLYPnB7q0iu7uTCzo0Wj1VoDA4mv8m8qVP6N2+rSjmA4XM4uBXP54JJhbVVRYG5Q==", "c5a69e54-e49a-4786-8824-ddb83db47425" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "4b721221-f7aa-49dc-b581-20c8f2cebbba", "AQAAAAEAACcQAAAAECuzB4qNHLQYvzih+HO+rSTx90ryxvdjXca3we5mP00cqhoduO6ie3EKoEbh2rkCgg==", "d938c5b7-4d54-44a9-bb09-390c9163a15b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1978, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "5a6fab94-4208-4b53-85e6-ac9b1307936b", false, "AQAAAAEAACcQAAAAEEaTaE4nCaLMfd1m7jWbzwvhx0wGVkb2wJkbX2MGqvhJONT07RrIVM09m2fJO4RORQ==", "04cb5e7d-6ca3-40ee-8826-f176aea32829" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "9e4b016f-d4d8-4725-86a8-17c2e8bcbd68", false, "AQAAAAEAACcQAAAAEJAgSrD8O4cpXri6g4ooWnPIS6oGSjeo4mC/F37s2UlA67LkSviPg/xtbBuF+Pex0Q==", "86f00a14-7f37-42ee-849a-dc8052aa94c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "8584ed80-f6c9-4983-8d24-1f183cf36faa", "AQAAAAEAACcQAAAAEMAZ1zmwjSY+xAqE/RjIpwMRDSFQQWL8VJ1giXAcBmTOUqX2Q3YBL68wJpsguspPZQ==", "ea1fcfeb-885c-4065-b658-17158dec11a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "cb141c81-f4a1-43e5-b93d-4d690a60db4a", "AQAAAAEAACcQAAAAEPaWZw1y7GKRrEj6N/zPWsQ6FOa/LwP+fSZSgZV3JYiFRvrYT2pxrwhr3rsoSZDRUw==", "24cd389f-2d7b-4a67-a879-22795a665aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "548bbcf5-b2a7-4a5b-bb0b-b6338a47bbf4", true, "AQAAAAEAACcQAAAAEKyL7Vwxdsq1yOHQQi9tlVy2ajXaSWBOgFKZnBvtEfohuy8Fsd28G/Oh5gkxW4HlBw==", "15adb406-57b6-4b81-9771-d41a1c7794be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "1d9e05ba-97a8-4d25-bb7f-315ac5722da7", "AQAAAAEAACcQAAAAEP44K/qkNOMCanEE8rIUYLAvNKAiv64RV1x9jgBZogQgtQMb82EFSz+Sor7wT47AJw==", "050354d5-711d-4608-92d4-c4a4bd1d71ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1991, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6f99cc49-62f5-48af-ae52-a4bf163a4353", "AQAAAAEAACcQAAAAEOc4DahMf3+nwadsk6QHOvlBcrT2qvFxxRrhPH4u1xNRFBdXC5q+j61RgBwRdhkIYQ==", "2cadbd59-e81b-4fc9-89dc-4a5c7cda1e85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "53a97539-9aeb-42fe-a7ed-e4c0db2bb5f4", false, "AQAAAAEAACcQAAAAEP70cV3N1JTwEbkFu5mFYbyRdrvW2c/mya+ADtq5zrK7OjBshTP/MP4pWulh0Ki9Lw==", "d56cdde5-3373-49d8-bee2-cc7923d36fe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "56e5dde3-ab87-4cc3-95bd-bf07348d99c7", "AQAAAAEAACcQAAAAEE++9Ye1ax8/De/2nFvx/GvWS7A8i9n+iv14dyqlaHmvhjNeaWb+oTtvrHUfSrXPPA==", "eadba881-7319-4732-b530-97c319c81939" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "b6022fec-7edc-400b-81d4-5a272825fbc6", "AQAAAAEAACcQAAAAEF3P/u32AemafERgOjQeILGCffx19eW9JM7+CKUt6S+yviaTymb31H6zk/7qTN8ZRw==", "56e65f3a-4e48-4aca-a768-d4167b7f6b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "12826250-3fdd-4ecb-b3b3-5af8d264f858", "AQAAAAEAACcQAAAAEOyrbWA5/R6Xfl0oSA/8yhiH23i+8GWxZg7xwAx0bi0R35GYC5CxXrmj+zYx5rqrIQ==", "d81482ef-e3f0-4181-b89f-97f8249a2093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "bd0d46d1-2ca8-44bb-a315-8b59e0d88821", true, "AQAAAAEAACcQAAAAEHb1awYe/2PhXffEMCtx4UKPIqdye7MFQypZAoYDn+uHqYv+xZN/AiUQD+EBZu9lww==", "b74fe0e5-c0d5-4cbe-bffc-8ea30bbb57ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "6e5fd2e1-f807-439c-ac6c-3a2eecd37e2f", false, "AQAAAAEAACcQAAAAEB9Vdip2kgM7UydtSjsUX0mgfCzl+6VwlVkQ3Z8JWjrbR7oqtDR4Th8iZCZHMiz96w==", "b323b419-d8d8-473c-a178-9bc28a39ef4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "245492d3-7f9a-4a3b-8169-51cd4558872a", "AQAAAAEAACcQAAAAEA54YWx3wZ061lQeaO6dfnINX0P4PN74ZNQE56PnC7GtS5nzknF2Lh9ooLAGKVhUwQ==", "7b0bcee0-b0d2-4ad7-aa6e-bcd6a2104929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "14316645-6717-47d8-bbdc-c3c6d664d550", "AQAAAAEAACcQAAAAEDj0i1J56FmTjTOusOkx9aXmU4F7CqzYpEgWFJO5aFHUaeDUFBTZD5tLf0NLshyYWg==", "ecc082a2-4604-4ecd-a253-6181311780f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "290027ee-3667-4a11-b0ae-bc9d332cada1", "AQAAAAEAACcQAAAAEHkYrN491c3C5Uvd8S7ol7tPiucsC2G9thn0ydqu+oM1KaHlMmDH4cHNapHZk8+XtQ==", "fe9aef73-de07-4aed-9b53-293791eea684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "7f79377f-f95a-4430-9da1-28b1a9817773", false, "AQAAAAEAACcQAAAAED7VuDl7CZan+Evt9NF4697v1in4EsNwX9BsVKDFc0w3cVgFOO/EXrQAWPcR1p0ixw==", "b832bc15-dbf8-46f3-b3dd-bb8aeda43e85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc8f3f47-f83a-4801-b937-984e3f40e799", "AQAAAAEAACcQAAAAEC/2mFadL9aegBPYnZV7yB9tl7DJeI2m6njW2SaD+J6dxscgS5nWJwCUmhht8UuvZA==", "9a9bcdbc-cf11-475e-9238-be96d67f8e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "79f5f576-7181-49d7-9868-ed208e35879d", "AQAAAAEAACcQAAAAEEQLkP9kNhrAygkrtB62BB43y1p1NNpnfMlKozcaSb4JWdl3uWMpOyxThQpbeB23cg==", "68aa1369-9ee6-4156-b5cb-8fdb20104882" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "ecbb2506-da7a-4fd6-97b8-f4118f810de0", "AQAAAAEAACcQAAAAEIZdyEOIGz6dZYuUE8fkFyyJP3yC7p5cqjAlz0+1WF1B5jBfEglJiMzI8QtIQkaA2g==", "e4983e49-5086-4036-8276-1259b83696f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "fe71627b-3ed3-4b30-a018-524c1fe28ce8", false, "AQAAAAEAACcQAAAAENmSYfZkJiaeNSFmzXR/gX4geYqdC6b3kuxVMhhrOICql+3J4brsCvRwc2XeB3rK+Q==", "70820fb6-fc4f-4a44-94f8-e31463f88e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "23e3c43a-0bd0-4f6f-a049-7cc6a3f714a6", "AQAAAAEAACcQAAAAEG5qSxrJcbaD3aYJQabKz1gHPoBdei0kITIG/pM1/+nWtr4lGhL7fmjpdk+vFMRLMw==", "ea0898af-958d-4a27-b639-8f1d8f2210e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "f64a8f68-9da4-4079-9ce7-b3940e8b5f8f", "AQAAAAEAACcQAAAAENh0MN54j1iVEEixBuIqEisNFQPlQ4R22rMTUhAaIC3cR9Fzlct4dzFtoIrSfeH2Rg==", "29a731c9-7e16-408e-897c-99b30456353a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "67d52c69-3369-4e89-a6c7-bbbd271331aa", false, "AQAAAAEAACcQAAAAEJEupQahfqRqn5ojiws5k8EsIWSOKJfUcnZELD8djVEMvM72dmKyGAm4vLuSIyj1WA==", "10275688-ded7-47c3-86c3-262d261d244c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1978, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "1e4663c3-5a16-4d03-a9ed-2af088546db3", "AQAAAAEAACcQAAAAEOw0ENImGxRkxvhNobdVpH6REjvuJcu+6qhEAseJXnc3Kl/ZYn2mdmgTe7pe5xnNzQ==", "3d448d5e-b915-4f71-9abd-ed01524485eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "dc399073-7296-4367-aefe-ade9bd9a47e1", false, "AQAAAAEAACcQAAAAEABoaHgy6Yu/AGgvJpvvj1IT2lq8JytQoe3PBgjuKS9U1CfYVIHx+ZxTC9Bbc82lDQ==", "472ea770-4d7e-4bcf-bc64-f0c3c6ca56be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "ace1724f-8480-4dd9-b408-af6f64f25346", "AQAAAAEAACcQAAAAEMF5T05LQSqKN53NmxWoU0XhKUgK3x/E+YHR6x1EZ+j6ALlX2/2dGSCVdRQLcFgdmw==", "b83f1da7-0f47-4a69-9c3d-280f053e71ba" });
        }
    }
}
