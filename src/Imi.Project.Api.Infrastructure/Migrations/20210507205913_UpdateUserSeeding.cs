using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateUserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "5ed68bc7-990f-4fbe-9f98-c977f9b2e81f", true, "AQAAAAEAACcQAAAAEGCaV1a/pt/VmjwetJl8PE6a4VT0Nda52XW6qNni6Dz3rIeDDCqfpX6X5/tpM+H9sA==", "2670dd13-1514-45ed-bdff-72e1ecae6848" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "c911ed88-c01d-40e3-8d99-dbbb6145a187", "AQAAAAEAACcQAAAAEA8B+HBPnzb3Be5pBFmeUJ0IUtJ73oWEoIJ7NKJH2lvLXU4PSMAmUKXz151V6e6bGw==", "906b596f-1049-4e35-a32d-b6d45d6da2ce" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "0d589640-ec9c-4b5b-a13d-9fff3e2321c1", "AQAAAAEAACcQAAAAEDXLRLlWbecTzeG14CLLJwIwGGGk6RCWdtfoKrqGaLbvegR/bFEJO4HP8AVmXVNjVg==", "d404f991-232a-45ce-aad0-ea61defed10b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "63287954-7065-4374-849d-d1e310c0200b", true, "AQAAAAEAACcQAAAAEENvvmZlIUEhdd4+cG1aMig8Iu23qKYECLTRp0n+IzlShGqqShLZicB/6eR4A22hRQ==", "19a5a86b-e5c6-445b-8613-ced9632f6091" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "0cb0be54-e581-4a90-9944-0dc15558ff9e", true, "AQAAAAEAACcQAAAAEB6n0LCDcfWFYzIVVhlYyO60NyiXMcLmmBhLTNOmsy1oeaZ/iH1Ic5dSuwYd+7fi0Q==", "d0ef17ee-aa93-4af4-8d34-2a588ff2b09c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "36147dbb-7244-49fb-af3a-08620e166605", true, "AQAAAAEAACcQAAAAEC7FNQiDkNe5ThOkW161mk22NS1I6ZoEJHaL7+w8qmAoRHLca80TmZeAzQnsnj03Fw==", "d8dbec6a-509e-4d00-a29a-3fdf0d8078ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d163184c-ce29-4015-ad02-23bddf511b94", true, "AQAAAAEAACcQAAAAEEklSoX+r8ZOgvVqt2GyYQsq4L0sbsvLGP/4bH18MaPoVq3nrrnKoOjzE+Z2MSQGJQ==", "873f8bcb-3d38-4eb2-8a3e-951039e75bd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "d7251231-0bf9-48b1-8c18-aed90a198140", true, "AQAAAAEAACcQAAAAEML8KnWW4EhlflyTxN+OoyFOKB0MNdSA1TrurwsTx4W7WniAUweATVtBu3BCnvGgKw==", "a4fe4ef0-6e8f-47cb-8b72-a602bba8ce10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "818c5f11-4b07-4739-bd64-96669c88b02c", "AQAAAAEAACcQAAAAEELID0WuB2VlKJqYbcj4hbZDWYA3/PuYkRsPP/XD0dnsgvQlth7gPHYR3pg9syzmCQ==", "15c3c68d-ae13-4ca7-86bf-e975ba6e1982" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "d0d35676-1696-4d64-85d2-4215d2855442", true, "AQAAAAEAACcQAAAAEBfFDpvocomMS6TQFv+27Vg30O0QlfG+X7+TlBZhTVJ42XZKskvoZvWYtdZEThgmxA==", "0f5dd142-205f-4c20-af17-08765c615957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "2879d350-b849-47a7-a83e-1d9f3f448373", "AQAAAAEAACcQAAAAEHDW2DXmbjTxT3V1c5BPzENygghK6uMSAqcZcIMwCWHy9u9hMXWEMGMumx1nark70Q==", "e1886ad2-51a0-406d-a25f-f541ae6592ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "536bf459-be86-4a09-8637-3c91e0db2d77", true, "AQAAAAEAACcQAAAAEFnyJ9nyioeAzr/LaOUIv7E42F4AyhucW0hlzMOtrOb94Bknmqvi5DSm0LdvPxhlYA==", "1c4b0996-566f-45ce-b915-117aafbc2c35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "756e563f-1fb6-40f8-b6dd-88b41c1cef86", true, "AQAAAAEAACcQAAAAENGanqdWpReRgIFNxn/BvWESzRBvQleLxjnLRXfaVCB5Z1qdoQXhQ5SZzTsgubsErA==", "d4a6c226-6286-417b-93ac-818851c50109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "00d7bd3a-d200-4b80-9ec2-f80521b31a14", "AQAAAAEAACcQAAAAEIFBrTwLMqJsdcJob265DO8vEv2YlgOla2ciIm+Ed7wXD3qSUAilOLUQxAaKjUCqpQ==", "815fe8b2-c099-45e6-b492-aca8d79942a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1993, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "ee4f24eb-b37b-439c-9cce-d3656aaf92f4", "AQAAAAEAACcQAAAAEAatX1KQJDeyP9p7eIR1RzTZypB/nltApTG7G8kHdPzCZwSoknCvsSBhBgen9yQ2ag==", "d05929e2-4ce6-4eb4-8f6c-c8a0ae5c6092" });

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
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "85fc2c23-ae60-4658-b2db-ece7321c0c29", "AQAAAAEAACcQAAAAEJU8hNE/AUSwvKLdsWqZpM+RxdWvycTGGuJir5WWpDTkMno5l30jsMFTf/RiwaNIAg==", "c268bf28-04eb-4442-8a3a-8d12590145c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "a09a2201-e276-448b-87d6-a247fa045c4b", true, "AQAAAAEAACcQAAAAEGkeaBBC+uSGgranQZGssKFTLTH+O/qIChnSwBXcaiFAh2XXpRPWU/bmDl0XQeZ/kg==", "5f77fd15-e677-4651-948e-2673ad0ad87e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "de2bd8cb-e86a-4128-876c-b99916d921b8", "AQAAAAEAACcQAAAAEEKgLOBP/fvjlYnFxL8Xm5VWb5Y0geemuz30sXPRUXQSxRS76ZMaRl8w38LlFmNwSQ==", "a9064620-8b7f-48f2-8fe7-57963b3f9a7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d9afed0c-1b03-4593-ae4e-32c92401d8dd", true, "AQAAAAEAACcQAAAAEBrL1yX2H6qZe/HLTBUuqIDrI70KX1WJjeKWgD9J+Hu47Ck1PsXt7HuWeoPsXkQomw==", "41fdf888-1eb5-4c26-9af6-fbb1296afc4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "cab1c41a-f412-48c2-858c-3ff4f93eaa53", "AQAAAAEAACcQAAAAEIKSfpyJ+t6h43CXbzeTJxUmIiIAeOpc+kEBOSEyZ3/QHW5BZCOUIDrSPv0LqeUF7w==", "c34c15f1-c3f9-4026-af03-da0f669afdba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "a6647d5a-f94f-4a51-92e9-cb1039712997");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "4cd130f4-da9d-46e2-8bc7-328b2c23a9ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "25a6a6cd-9c94-4072-89d2-6c100a9ed177");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "8d6038b8-5b01-4745-83a2-0987199a63bc", false, "AQAAAAEAACcQAAAAEFhH2jwVweft48KWO3pzUQaMI2due+wZfxsssn07DQuCgeIw5r/ZzUoLQBe/2Vdj9Q==", "b7a92e23-799d-4b5b-b527-a7693c5d407d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "520eb1b6-4df2-4a41-ba19-0db9a912c669", false, "AQAAAAEAACcQAAAAELgvYQaADGQwnS39z3QpiD0FKw5lRO/mbLU+kxSynwNSQzqg7sHVpbLnk/CX4j0ZmA==", "c3051453-e555-4a65-93dd-d092f7ab1bac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "9277489b-9f20-4c7c-8ac5-9ec08293095d", "AQAAAAEAACcQAAAAEGJfVJwup1C5lou3fJC0LYgYBa8FFJFkIuHTaaof1sE9D46zZ3oayPuftSwxWSI/ng==", "a1e8e490-c3eb-4da4-92a3-28366eead054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "bdae7749-17c6-4969-af47-3e6cfe6190a7", "AQAAAAEAACcQAAAAECMNakVW7zRwISlXqhHTsZnTV2Uiggh7uMhWKtDIxyiUZgvGGmB2IPFhgyNaCVEJ5g==", "09e2091b-c06b-4842-ad8c-672d3d06330d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "e7112b84-4bfc-4b7a-b2cf-804c6102c8af", false, "AQAAAAEAACcQAAAAEDVjIOSw3i+4YC6vJawG/FU6D79aa+FlRlzmm+c2Ybo9ls6yrl4k4mO5k5fuTwwHoQ==", "965a49b8-e766-4633-8eeb-b2463ed880de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "4888192f-e8fb-4883-9832-985ba6fadbcb", false, "AQAAAAEAACcQAAAAECOOEe07qKiiGjDO+VezBXrCAPObqfb8T8TP7LSC79cdQ4ZC+0XMNlXaNB561Pjy1A==", "b4bc3e4d-5db6-43d3-b097-6b66126d8eef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "ba08ade0-0cb3-4414-af00-bb2b4eac377b", "AQAAAAEAACcQAAAAENV0UUuYG4sUPq76DAzJ16n7VrABFlPCPQcuJjy/IgU0FN8T5x3aStkvfokrjmbupg==", "17ba8d41-18cc-4cf6-abda-64f8b19785fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "7e6c08d5-a552-4008-b19d-16b96f55a009", "AQAAAAEAACcQAAAAEJnuYqGeFAHgUv6dJKiY5DOuTinrW+1yASrGTGsIwXDzXQquIST2AfcJ0EBx0dM12w==", "ba30a5b0-1332-4c48-9684-65c79e4db08d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "7726f7f0-f739-48dd-80a9-2d01dacae299", "AQAAAAEAACcQAAAAEHxISH7aTwA0oBMns64pw3BKWx7vslVvuhZ32fHc9inp0t+VWsbV9DmkouYudokQQw==", "339942a2-a4ff-4cdd-855e-f7c9a10d69f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "fab6f603-7cb7-4627-85c1-d82395ff7ed4", false, "AQAAAAEAACcQAAAAEDIwYmUrrQ1gHfEEZOlJNohoIcgOxyERTYdYVRJYWfOyBta7JfFudvzGeSguqIBOjA==", "f02d8ce1-c5ec-423f-8232-228f5de135da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1991, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "28479fe0-9023-4a97-a625-5afd12fe3784", false, "AQAAAAEAACcQAAAAEBxfrlfa0/LIhffN4UK/SMCzPdhlwySDKoX2QNdnd+tlLZ3iZS74JR/MyPkknMIiew==", "81a130e3-45d2-47d1-b809-71ea5e07deeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "bceae312-9486-41ce-8b6c-73d90a8bb38b", false, "AQAAAAEAACcQAAAAELqvbH63pSAO4w0OSWQlqZN04p1CHPqIhRVh+JS8qhOwST74fS22fk0yEgY30On7jg==", "779d7332-6c2a-4777-a310-7766369a6924" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1976, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "7f00f996-0ba1-4d4e-ac04-fc207f28a8c0", false, "AQAAAAEAACcQAAAAEPERc4mwTsfHoy+y9OVM39OdNJer7FepuH9Tp4kK+ata27Wrm0SRnTleey0p1FgKng==", "8d242498-2891-4cb4-9ce5-e1b9cc2a2041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "b67aeb02-47f2-4ed3-bfa0-40d5189ab717", false, "AQAAAAEAACcQAAAAEBo4P+YrdTtiEuROIeOgXs/VQ8k99BdLgZfL3KLHrHoN4CrImCRGV0+vXw7LYXe+IA==", "a33ff1ee-bc88-4da2-806b-019569d22d9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1986, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "6c9dba9d-4c33-4a61-adfa-efaea9d98805", false, "AQAAAAEAACcQAAAAEGuHQH9WT5/3+OxneRlk1OSMFYz2BWqlC+/thg909XpqoQOQx9ytjObeMC+7FJmP9g==", "fb02d9c1-bf1a-461d-8bdf-31c4f9d0dc00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "ff9fc0ab-8ecd-4021-9124-0c42bc65c80e", false, "AQAAAAEAACcQAAAAEK7PQS/Co9YpvtwmNoVgWbXTllJdLYgPsMThbSHf4TEk0RhzYQift8BX0Z3rp6Sr5A==", "352053cd-faf1-42c7-a5b2-0fa86b520af5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1980, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "6674d3ce-b03f-4853-907c-ab3d77a1fc55", "AQAAAAEAACcQAAAAEI/2aGjluKhMkZ0nhjVoHSXPi+4sLbJiTkYMSnmAWaWA3r65grKdGhYOiszMUx65Iw==", "af46c128-8ea8-4be2-824d-43633c9f699d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "a41bffbe-da14-4ac2-b7dd-dfa24b73018c", false, "AQAAAAEAACcQAAAAEN5cGjj+2OoZuhjReNBVqG3fLU56fiEJvF3CHumJct2WwFczdczkUU3L34NNb2ptMg==", "03080d6c-b46b-4c05-b5d0-09e53c74c4c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "2fba7415-b3c5-4990-940c-d0c0ed3c2857", "AQAAAAEAACcQAAAAEOwpZThiZLhkZqDDdVL03aLjry6TNngjJG5W8kHb6owX8ZjwZuu4UhBb5iHjZRnQzA==", "0e97f521-cbd2-4824-b963-91727a981968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "d8525d64-e56c-4bcc-9ab5-38e73149fe32", false, "AQAAAAEAACcQAAAAEND9/pTYebq6sqmo7cklPtr3YxBWAmpbkedvxZ5CqwnBpdsMrKrBCxNu6ACs046VOg==", "e086d1d7-dd0f-40d8-bd05-8fbe100ba311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "0618415d-70e1-4d8e-bc58-98c23ca5abe6", false, "AQAAAAEAACcQAAAAEPdrN4lG6PxWMVabZu2rboq5LaCDbaMFDi73iV6m1AtJv1+UpQWkms7nJtDMjx7iZw==", "f1035c1f-4f68-40d6-ae19-039d4d8a9d5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "3f37e979-bd73-49a5-9d05-43627aa62ac2", "AQAAAAEAACcQAAAAEFxVpl7qIhMhuwqXndY1YwvHTPinVnjB401lTyW+TkDPlkr28lZ6A4ycxGvpJz9axw==", "3a1a4e12-fc91-4261-bc2c-10fd5f809080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "60ae8191-b556-471a-8a47-fc26659c2432", "AQAAAAEAACcQAAAAEL55nrlAiYrdrMF5aHhTg/i2aKiftQfpsSeQSG8L44xYbHakfLWtSQCvzTXXmMh0Ug==", "084fb45d-c4a9-46a9-b302-e3061f301fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1973, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "67a51cd4-c63d-4af8-8e39-a6e9a1159d41", "AQAAAAEAACcQAAAAEOf8Af59pEoMtgcuCV0k54UVRkOtbiL5xHLMVjGmEgMRKIIwoKXeid0ONUJvKHWyYg==", "b7a63d26-c6d2-45c5-a02a-a4536850820b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1970, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "08f74458-9b97-44c7-b0e7-29842af3a286", "AQAAAAEAACcQAAAAEHyjHkSOqdxFouVWJD0wgUJlZiPwjVzykmUBUZ1qOqPi7XbrX442Zove1iqT2ihZaw==", "aefb778c-65cb-40ff-95fd-2692bc6243cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1989, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "4e693233-9077-4606-a83e-f33f5e5c150a", "AQAAAAEAACcQAAAAEAepZQAyJV5w+pAUBJYnRKlAXtTZRXsR/vXbP0cQH+sw1jPo7RTg11zRLL0jNKejSQ==", "99e8d0af-2e71-4a1c-ade8-da2e4fe1a1cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "83fbf683-c3a9-4522-8e3e-daa28196245d", false, "AQAAAAEAACcQAAAAEIFd5vVzgjkstep95feUJ3KQqlxayuFpiZ9yib8DkNqZxyHJUteKj/Tq3SGonZRXHQ==", "d4dd8f7c-3bb3-4547-922c-b3f6da2daeb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "d2396d92-a73e-47ae-853a-cc1177398cc8", "AQAAAAEAACcQAAAAEOfzPQsrc6oMRFX+QJqROdq5MH9hjIZRpLi8OcCNh1Pq4BBxUcGIKjMTqu796AxnlQ==", "e58db83b-e5a9-4f9d-a797-21e9f14d1737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "fa43882d-41a6-4fdb-b88b-d784aace799c", false, "AQAAAAEAACcQAAAAEAplJo1Olp+OPS74wvVANxw/Z5lXEBNqqIR21UluaSzMlQ9KjK6GqvKjDTcR63Ragw==", "005e2222-407c-41a9-9c02-86af8e6043cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "77af4d3f-5d27-4a3e-a852-ed2bac9a331f", "AQAAAAEAACcQAAAAENCfpMvCQlp0/NP8r9xlXvF2ak4bexraX4wpUPchTdtSuCM50MNo++xsg8BfeO9Wgw==", "0944d6b0-5ff0-4bb9-8b1f-3e0ff9325bec" });
        }
    }
}
