using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Underwriting.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleDataToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09c54e22-6016-4824-bd0c-2f96610aa75e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f97f5b62-007a-4e85-b2f8-13365d6e45c8", "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f97f5b62-007a-4e85-b2f8-13365d6e45c8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", null, "Manager", "MANAGER" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", null, "Underwriter", "UNDERWRITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UAPIUserId", "UserName" },
                values: new object[,]
                {
                    { "1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71", 0, "38dc1495-a935-4851-b25f-9fd9ccd7a991", "Angela Hardy", "astovallhardy@i3verticals.com", true, false, null, "ASTOVALLHARDY@I3VERTICALS.COM", "astovallhardy@i3verticals.com", "AQAAAAIAAYagAAAAEL3AFSYsXtl3nZIJgGFb/4flIfJoNGpf1OWamYVl4esOse1SwgfMQC/THG+YJPqltw==", null, false, "", false, "62420940457e21a2ca768c79", "astovallhardy@i3verticals.com" },
                    { "2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62", 0, "3cf6a825-5b75-444f-97e0-8955f0d19df9", "Benji Lamfers", "benji.lamfers@i3verticals.com", true, false, null, "BENJI.LAMFERS@I3VERTICALS.com", "benji.lamfers@i3verticals.com", "AQAAAAIAAYagAAAAENHrtA/RgtCxmpxWXh/W6b1q317o8DpVvwA1B8ypN4G1XT6l+Ci36yLuUWR3T6tFfQ==", null, false, "", false, "5d4a2dfdcd49961c2cd5729f", "benji.lamfers@i3verticals.com" },
                    { "4e9b671d-865e-4c6a-b283-1c5d214c5939", 0, "e74d2923-24e0-4bcb-9452-b5183dde164f", "Daniel Fonseca", "dfonseca@i3verticals.com", true, false, null, "DFONSECA@I3VERTICALS.COM", "dfonseca@i3verticals.com", "AQAAAAIAAYagAAAAEAg/v58IJrMFMvG5f/shhlxlNAKwrgmLgt/CdDWEV1OLe4L6W11eEuyIrSSgIVeoPg==", null, false, "", false, "58574246aa45842a200103db", "dfonseca@i3verticals.com" },
                    { "58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7", 0, "066c39ca-45e7-426e-bff2-bed250ec4b5f", "Alyssa Smith", "asmith@i3verticals.com", true, false, null, "ASMITH@I3VERTICALS.COM", "asmith@i3verticals.com", "AQAAAAIAAYagAAAAEO3jw10OWznYRRpJbw7O1c2yTT1ikL4pzDRQmmbafdAeDeW72BBpok9y1DQxNNaI8w==", null, false, "", false, "61d470129b42b0f4965aad74", "asmith@i3verticals.com" },
                    { "73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34", 0, "339085ea-1517-406e-87a9-c6a12c924cfd", "Justin Esber", "justin.esber@payschools.com", true, false, null, "JUSTIN.ESBER@PAYSCHOOLS.COM", "justin.esber@payschools.com", "AQAAAAIAAYagAAAAEIfSpUMmAHHyB+AHIKDx8qTV6ytWFkFHm1ChH8LQvTTXQRgkHOxFDwcpiUuaPsMpgg==", null, false, "", false, "585742f4aa45842a200193b2", "justin.esber@payschools.com" },
                    { "87ad364d-53c9-4698-b0a1-c01f91c6f4b0", 0, "a2a3c6d7-28ca-47e8-b1d5-9fe0fdad0a8d", "Lisa Reedy", "lreedy@gmail.com", true, false, null, "LREEDY@GMAIL.COM", "lreedy@gmail.com", "AQAAAAIAAYagAAAAEI5Jmsmftu3uvM31gmo5x+tMwZ5IjSNrnbmhFZmc0pShKaDAgJfMI9Oia2WI868toA==", null, false, "", false, "58574197aa45842a20007798", "lreedy@gmail.com" },
                    { "9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49", 0, "bd6ac6bc-61bd-49fd-b755-33c58774ee93", "Tee Locke", "tee.locke@neo.rr.com", true, false, null, "TEE.LOCKE@NEO.RR.COM", "tee.locke@neo.rr.com", "AQAAAAIAAYagAAAAEBFT4C9VjwRCYIBHT6n0dc7VLvY48ulxLbJLqySmaKFP6SBCUauQfhxFXv8dzyoC6A==", null, false, "", false, "597b2d274b9cfc2e6c819088", "tee.locke@neo.rr.com" },
                    { "b0145c62-e346-4ea8-ace2-6d82f84c9e2c", 0, "eddcac0f-2b24-4d98-9905-cc05500e9b0d", "Christian Zarnke", "czarnke@i3verticals.com", true, false, null, "CZARNKE@I3VERTICALS.COM", "czarnke@i3verticals.com", "AQAAAAIAAYagAAAAEN3i823WfoRE5mVLNjDxbJWyS/Ux+/NRt1mSQI2HrZZ3w5DCJK3WEmTSzORAQ07dSA==", null, false, "", false, "620bd70caf64c4562d58b84c", "czarnke@i3verticals.com" },
                    { "c83b57ef-024b-48d9-939d-5b8d8e0b7d23", 0, "a90a65fc-83f6-4642-80bf-a8b28d743a62", "Sys Admin", "Sysadmin@i3Verticals.com", true, false, null, "SYSADMIN@I3VERTICALS.COM", "Sysadmin@i3Verticals.com", "AQAAAAIAAYagAAAAEI0WEYYYoeravx81WPikJURjRysM+5TADBH/6LgvaG/T02gVgWjS6O1w2hwOaCwUgA==", null, false, "", false, "63a249ee424c29d968059d8d", "Sysadmin@i3Verticals.com" },
                    { "df9f1ac6-616b-44b0-a1de-85a56c7d4a58", 0, "65376c28-ac6e-48b3-8a32-d45168c0b96d", "Vadeene Sisk", "vsisk@i3verticals.com", true, false, null, "VSISK@I3VERTICALS.COM", "vsisk@i3verticals.com", "AQAAAAIAAYagAAAAECuePUD/XgqY67/v5JtckDUsRSqqytjeFBMvYMoyvG6vEItyXS2c/Q3QqzFju8yfPw==", null, false, "", false, "636c2737b81806331e91f99e", "vsisk@i3verticals.com" },
                    { "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2", 0, "bb3fff00-4ec9-46d1-a1f6-c7aca01c4a2d", "Sonya Ridinger", "sridinger@i3verticals.com", true, false, null, "SRIDINGER@I3VERTICALS.COM", "sridinger@i3verticals.com", "AQAAAAIAAYagAAAAEPqFmsiim3X3IzM0xQ+vbY+kwssVjCXTm/wfGb7GK4ulnOoWK/WNfQPfQLSxJ+es4g==", null, false, "", false, "61d470129b42b0f4965aad74", "sridinger@i3verticals.com" },
                    { "f6e134e9-402b-4782-bca6-7e1f9a5d6c1f", 0, "6d3d6f74-e217-488a-92eb-9e54c0bc9b11", "Colleen Rumsey", "crumsey@i3verticals.com", true, false, null, "CRUMSEY@I3VERTICALS.COM", "crumsey@i3verticals.com", "AQAAAAIAAYagAAAAEARqHlztABVNG0kGxUb/rHImmq1k3V1M/HlSvQ+ZSRm/Ncv9oguX5a+q5/BNQ06ARw==", null, false, "", false, "63b6ec7733247bfd8698d629", "crumsey@i3verticals.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b671d-865e-4c6a-b283-1c5d214c5939");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87ad364d-53c9-4698-b0a1-c01f91c6f4b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0145c62-e346-4ea8-ace2-6d82f84c9e2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c83b57ef-024b-48d9-939d-5b8d8e0b7d23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df9f1ac6-616b-44b0-a1de-85a56c7d4a58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6e134e9-402b-4782-bca6-7e1f9a5d6c1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09c54e22-6016-4824-bd0c-2f96610aa75e", null, "Underwriter", "UNDERWRITER" },
                    { "f97f5b62-007a-4e85-b2f8-13365d6e45c8", null, "Sysadmin", "SYSADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f97f5b62-007a-4e85-b2f8-13365d6e45c8", "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2" });
        }
    }
}
