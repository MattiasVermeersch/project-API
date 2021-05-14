using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "b540e59c-dd93-423d-80de-09931e332dce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "1836e004-1a55-4951-9721-e0ffc1373f31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "e58e1e2f-9ec4-49ac-9e39-13948e5f8b0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004",
                column: "ConcurrencyStamp",
                value: "691f6c26-2726-4eb2-ae33-06266db1a6be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "cc191f24-a317-48ad-b651-28842fd425ee", "AQAAAAEAACcQAAAAENNQ3irxc91BZjMbVIdJzn2JAZiQ1PTPYAMFJM21saPNVSfD5P5XqjBY1dUrHF2h1w==", "56b6abaf-beca-409d-b1f0-2cfe2c947bf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "feb07677-a65d-40bd-80d1-96e98ba43be1", true, "AQAAAAEAACcQAAAAEL5izjC0YcvHag7oZZPo0k/6iRNCu5BBrBBIeYGfMFhw0OSXIhtf4dsdjtM2YvdXPA==", "91480e2d-8afd-4c35-a01c-9864e646f974" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "dd8c4028-a619-453c-a1a4-9603d49c6110", "AQAAAAEAACcQAAAAEMft/dKsEU3GQ2nMsBWltd2HQJA3h2CzzwEjqZ5O2POksXLmaQD5u9FjTZVzEXODMg==", "a71cacd2-f156-459e-bc89-251f42e3b041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "999f4622-a358-4e1c-88d3-7009b5f5942e", "AQAAAAEAACcQAAAAEGGnWxEnLl5D/RiLJCYXhALENmRLdhBTI9Yysl0O0OEIs/ZtV7ZebXvzj4Yi0rcW8Q==", "657edc93-4279-4d09-bf6d-ad4e140229bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1973, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "e5fdf9bb-3098-4e80-a9a4-41e6571a3e87", true, "AQAAAAEAACcQAAAAEKltn4Sj5ZeYVZdLfWuDR3cTOju/hxcAmZzBH2hBalQUSKQoL8Om0SkN2IgKj5tnGg==", "2678a970-07d6-4484-8c15-e75648759de5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "39249df5-b262-4bab-ae6a-017d0277d6e3", "AQAAAAEAACcQAAAAEC6MHjNz1PbeXhB9DVv3ANp+ARpW0E4nVR7hB65IixcF11FikzlyCm5vpOn5QyXauw==", "9ca6c88a-5fbe-4d5c-899c-0bf455a04092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "7efcc85a-1745-41d5-adab-a4f617f1ea8b", "AQAAAAEAACcQAAAAEMZl4RQq0B2ZVuufT1xTJqDq2jRLRCJH/ChP1G8JjDOv8KaIG5qMA7/ZH23YthAbRw==", "788173a7-e629-4677-87d2-6891549648a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "13adb090-41e7-4749-9dc6-fa7b8f9b747f", true, "AQAAAAEAACcQAAAAEBOi33NSbIluc2a85r0/cYG6s0gzxq2KVzpXL0bdHdsQ9mfozH7gXyMnDeX4IFaG9Q==", "ecb29c3f-f2e3-43e4-aa4b-5652815dda0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "27a438b1-91c7-4f5c-a725-3f7d68703fc0", "AQAAAAEAACcQAAAAEGR1mIvenrH/cwkKk7QZfytpxH6/RDbJe/EioVOosMGVrAKxm5FtIb87QgvPM7YLWw==", "33073e02-a710-46a1-aca5-eb4ef3d19c8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1978, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "630eb107-e5f3-47f7-8c00-cddc8b7cca66", "AQAAAAEAACcQAAAAEJuAPMxHXPAj2yhlXq7hF30GYz3iA7khlqTj/J/cD60AUXdlnR5rUPbU9kC28AkXmQ==", "66dd2942-8fc7-4fd6-baa2-0570b957faaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "f5d9d619-810c-4b44-ac18-15d0de1a6217", true, "AQAAAAEAACcQAAAAEJYIHoiry7kQ0PzKqA4TqApRLzlkNW1DtZi5wi4Fsj3uqHQuhQN9eL3dHBFrtDekjg==", "64b35ffe-3019-4a4e-994f-988cceae4407" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "76ebf418-378b-4dbf-a8df-2cfa38170110", true, "AQAAAAEAACcQAAAAEJQ5B7Y3c35OFs+pfHkaEVUJpbr3hSiWBpDvzPXQDSKBAG9HRxuzKixw0E/l6+0K8g==", "bccac523-7c49-484c-a355-51d5fc956e51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "7093aebc-ea6e-42b9-91c5-b0a24c304d6b", false, "AQAAAAEAACcQAAAAEGvYBVuw5SVpaihXmcS0NHuAK6lrLr+uruJSZm7KNbTzAUPvwrqs0QjD33/9AkZ3jA==", "46649e26-3b82-4203-9828-2662f0e85f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "4801c531-ee92-4331-addb-6bad06a0e2c8", "AQAAAAEAACcQAAAAEPvS2Y/+/eaHOVlJeT5D+HVbrmLa2tEq2rMQ3RCpm2TPTRwBfXZKCuvQREK2GsPxRA==", "4033fd37-f07b-4a0a-92d8-24cb5d35e1b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1983, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "7d4d36ea-95ef-4854-b4a8-31ef997ccde3", "AQAAAAEAACcQAAAAELxPwZDdWF5A+MVM3r63nBDe1SRJZWFmOAjq/6GkQeHRiWJ7xoSgVB1au3pOZ6Vf+Q==", "a77d761f-d667-4244-868c-52afef7a8580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "13d15a3c-7271-4e69-9deb-2104dfe70e12", "AQAAAAEAACcQAAAAECzolgP3tttdKPV0VrfJHuqhbLA32/Gxh5j5Wwr3ufSwZpkCMBlR5oorXqkB/R/XBQ==", "5bf2c263-73c5-4541-bfbe-32df593958ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "52d0e997-cea3-406e-94f0-7762aff9b527", false, "AQAAAAEAACcQAAAAEFGib517e1kem7uwhEtev5ObVco/THy9tNWbgsTTUhRTA39PLu4HElPQxfhNhv/lHw==", "30ddc757-251a-4139-a577-d37da1b8d59e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1983, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "83a05d40-4c90-4ec2-817b-9e3ccc19c951", false, "AQAAAAEAACcQAAAAEB9tNl62i60DnpqZ9VE3/G+fgdpcXAEDXdFbE3BRJLLRjVXEBkg428CGMlQvrc1fHQ==", "171387c2-3705-437e-b08b-5896ad379ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "48ba0ce3-096d-433f-a408-d761278cad30", "AQAAAAEAACcQAAAAEFO91QaAhXAwv1znk6hybRbHLgh17G/Lal0+5hNpik7v2hCf5YoMDKBXS2oJmlaMlw==", "396b38a6-4775-43fa-8c4a-32774c4cfc23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "3a20f049-f92c-4369-890c-3863fcfdb407", false, "AQAAAAEAACcQAAAAEOZQcR0o5ylYihehank19mZ1sv+bYpowoPvNwaJB4zFBv97+V0xVCfeim7FsN7lKPg==", "88c184fa-5b5f-4664-9572-7a8f17357af0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "16a227b2-53d6-4fdc-bb38-94903eb9c991", "AQAAAAEAACcQAAAAELqJc5c52hgxlytOEkPiWKYtbJXQqmql0EG2ThtIwrv6BgWR4A8D3HF10DyZU51S2A==", "f6a1fb5f-6696-4ad2-b943-bf99bd1bc1b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a686d52-88cd-4fd7-9eed-c3d9c159ddbd", "AQAAAAEAACcQAAAAEPgGUZQ8hFeI2b6h5aTmv241eWahylHkz+poN+N58lqsOAc3/zfOEmjyZRlsNSaq5w==", "27d20369-f8bf-4599-bfd2-f39b16228f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "c86d07c7-d467-4724-9e82-4392a78452f1", false, "AQAAAAEAACcQAAAAEGRvULJdaL6/fNZJ7e/oCaDL+Yy1OWr7NHvVDSNrVcrY8ZFNNoobpiScdJ4Yamfi5Q==", "1bf644be-4aae-4beb-ba62-d55aa719f2a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "23b84916-a98c-4efc-b9ee-948ccf8fc473", "AQAAAAEAACcQAAAAEONS1CXFNVRRZioCscaVU3B2EnRFaLpl97jxltQW6BkCAOPjeev6l9xxfXc/RnJHbA==", "e12bbf70-1bac-4f6d-b22a-72dad3c93951" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "e582763a-253c-4f13-8ff0-e5b345bfd39e", true, "AQAAAAEAACcQAAAAEKyx0PEE4bwzq452oVAjTekJYBhCieQTQs3QJwC6fs47gVIBsImfR/ZhukMFxkY5FA==", "6ddb3edd-92d8-4daf-927b-20bed168fca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "299baf67-adc4-43e1-9f30-63a8fb02c18d", false, "AQAAAAEAACcQAAAAEI28tHueqcMhCHJqDNHk/7s4F7iDRRST8SHUuGwkyxu5aVYcSSPvBOdzfKCZJ5o4bA==", "c2ca59ac-ddd2-497d-9da3-866e9675199a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "eae7e707-1862-49f5-ae93-b846739cc062", "AQAAAAEAACcQAAAAEAXSHgTAUa26hgn4Vlr2B2+hGUK/y4YmZnz2lY3b9LWiy3UjoA/AZ4Y98KwNpNiQNg==", "8ef27e36-1977-49ec-8724-8b1a00641555" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "dbce28dd-56a6-435d-9145-db8f26f04864", false, "AQAAAAEAACcQAAAAEBk3TxjuGaEI5x2ycK/plmhvPshD1CYbsif2gT8f6ynF8UIz7UMdj10CBm1KQWGNPA==", "605c64a0-e11c-432d-8953-4b06e9e6c3f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1983, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "45320396-d4ad-4d09-9224-27a74c693917", false, "AQAAAAEAACcQAAAAEE+igw7/hUIE2PEOxqN6TLQiXtZwbGKRFRLuLh2LP/721oJ2PStCP+f/Ieep2QUy/g==", "a982cb6d-59f3-4501-96d3-00ced4ee2700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec9d63f4-c4e3-4c6c-96fd-16eceb4d422f", "AQAAAAEAACcQAAAAED/tQMlQmuP7OitpOpGKDRmFFhfDZbQr1ugzI3Qyb3Quva9k9v0pAAF/OFxgrGQoug==", "58ec559f-482c-4acd-8e10-fa1a6723ac03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004",
                column: "ConcurrencyStamp",
                value: "75d719c3-9aa8-4ba6-91d1-1fee4682fc0b");

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
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d901c01-b72f-4587-b95c-f098a262e61b", false, "AQAAAAEAACcQAAAAEBOhG7527X71op+MehQTURiOi42my0n4WJ2Syy1p7wDgaeoTq/c4WQz1MxOewwSKMg==", "34aeb52e-3232-4a0c-8ea7-6bb28d1744dd" });

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
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0f16894d-8e30-4aaa-a8d1-a6cc21f4bd6b", "AQAAAAEAACcQAAAAEPvHPMLvLrL4rZAJrO6C3XagglaDBKbm64JDe9B0sPxhmQVXZZ2x8VvAyzkYyS5s/A==", "9983770f-ba2c-45b7-8fa8-ec811b20fc1e" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "48aa25ee-9a48-4378-a539-f29469792dfb", "AQAAAAEAACcQAAAAEJ4hQRhpzrmOhF+cO7Vkb+LOk06v2NkRF8G8jF5u7WVnNVVipTW0XqPqyck3TQC5ww==", "6fdd2d9c-9cd5-4442-b426-e7d363636585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "096c0b33-653a-4ceb-bc70-c804cc29c235", "AQAAAAEAACcQAAAAEACxItEHvvyxDHbrIAO6xrcxlOT66hERrCvWI80BJPYZ0DPuD5f/K/249ftWOBxsJA==", "ac5c3a09-df5e-432d-a4cf-ec43e200c88c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d78360b-cd7a-4ad0-941d-cf7570f08602", false, "AQAAAAEAACcQAAAAEI7f2YI30gSOTLtdx2oHWLzk5sBW137c1teXQJ9/avCbCCKV3yRPR8gyRImiq9WVgg==", "9eb63640-41d1-438c-b60a-c7b55e60771e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "8fcdba20-cc36-4c5b-bd0c-3846da41e98c", "AQAAAAEAACcQAAAAEAtZEVhKsQkWdCKgwD7AFYDjPBrfa86yZaIzazA2UAf+qxawfrNTTuzji2PrTCtkxQ==", "b7eb3579-0ec4-484a-a8ed-09cc0665b98b" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "8ccc687b-a1c9-45b9-bc8c-abbc0796b0a5", true, "AQAAAAEAACcQAAAAELuQ181FUpQRHDw0Z7P8Ex5rSi+m7zjGYFGubGYCeNBRzYvatGA8rEEIqD3HTUn+Pw==", "3d940b65-b826-499b-a2cb-69a7ebd07e0b" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "10c26f50-749f-4597-b27c-861099f604fa", "AQAAAAEAACcQAAAAED1GxlQhWSe96pQE9cTrt0L3ShOotHu349tEPFBXtm7vCA/hWYbayWkXZrImK3Tmig==", "72da2dee-59c8-48bd-aa51-fcef0dead618" });

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
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "50d5e469-a8ec-425a-a12e-67e705d3adb0", true, "AQAAAAEAACcQAAAAEIc9IPdwe5zpaG7FqQWO6APYaHqojgxwDHzQuD5Y9+1uYkOrwyFYo8nIvR/7srlmrw==", "60829b7c-ec9d-40a8-aa22-05103b4261f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "edafb93b-fb57-498c-8e16-7bed2b364247", "AQAAAAEAACcQAAAAEEhg+BRzyJ/Do4Oy4h8cIHmBkmOUxLdMFA5bO6IEoGc12aALPYwmCBHQQKzcOGTtvw==", "ace8155e-19ca-4915-ab72-9c299508befa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "5823715a-48a6-4e01-8e7f-66edc384a70b", true, "AQAAAAEAACcQAAAAEMdd8JJi7+dW1MDG+zEhoTAa4HxRQXrOAfY7l24x6+PR3DycrS/NUQwZmb1WZ/Kf/w==", "97d1ebf6-0f18-412b-b8df-2d48cb96c4d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "93f9bc8c-e4ad-4d67-a15a-7dbb57522bbe", "AQAAAAEAACcQAAAAEAIjejEELryk3H/nCFRu6PyRjSqas96xyB9G3FEqQzEAsqxDtRovm5a2CF3Vn9rh0A==", "d6a87cd5-2fbf-4eb7-a04b-b86e895ea379" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c5eb749-8c02-4654-aeac-d9ecd58b59a5", "AQAAAAEAACcQAAAAEHis0KbT2Qn7zCr1eRGoTaSXSyxUwp+9TF911WAqpqHCSdGuU4CCqODaXIBg4ScCAA==", "d25bb90a-5f08-4979-b6e9-605483d37360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "b94366f0-9111-498f-b11c-11e31dbcd3d7", true, "AQAAAAEAACcQAAAAEHw9vrxhnpjWsKZNgcrflgQkB8n6CsWzsnrPntoF/rchbMQnYC8DIQPjPOrxMV+NXw==", "93dbd751-35e7-4de7-8d11-024b5e7f71f8" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1976, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "9ce420a3-a73e-450f-96ea-7c2793ce4930", false, "AQAAAAEAACcQAAAAELnWJnvzKP0/NPc6uy1WRrH1XAR9vJtoI7AdVGXjka0uN40bMDmwiZ4eY15rXiVCcQ==", "6a99f8cc-ce7e-4c49-a45a-7ca9a29fa8cf" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "ff08983a-de43-4c1d-9bf6-fad69b25f7fa", "AQAAAAEAACcQAAAAEAkJxjFK9LPVFEXQpKzpeSxJAkVIC8CeekPJP8UgluCGXTWbFfEI+fzkjLotx+Whow==", "4becb962-1064-493c-9f12-bf842bc76075" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "ca284ca5-c7f3-4678-a775-7c74048a564b", true, "AQAAAAEAACcQAAAAEAtgFf/9KzrMg6djVtC29Frzr0G7wHMhj0JNk92rJDO7doXn7HZ2e7p32URc29oxxg==", "2abfbc73-e85e-4147-8a5d-304d9a7b9b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "391fb449-1d7e-4d94-a4fe-2cb0727a0355", "AQAAAAEAACcQAAAAEB97Z8ULQT7kI4AhkfwmN63XjtUHnT7dDobEB38GLOwZfNI8NPORetKEbDr77BdO5w==", "fbd7761b-f790-46f4-ba6f-2520cd81330c" });
        }
    }
}
