using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Underwriting.Migrations
{
    /// <inheritdoc />
    public partial class RolesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "4e9b671d-865e-4c6a-b283-1c5d214c5939" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "87ad364d-53c9-4698-b0a1-c01f91c6f4b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "b0145c62-e346-4ea8-ace2-6d82f84c9e2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "c83b57ef-024b-48d9-939d-5b8d8e0b7d23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "df9f1ac6-616b-44b0-a1de-85a56c7d4a58" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "f6e134e9-402b-4782-bca6-7e1f9a5d6c1f" });

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

            migrationBuilder.DropColumn(
                name: "UAPIUserId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "58574197aa45842a20007798", 0, "f3621f3b-4828-4064-b3ae-647229de90c4", "Lisa Reedy", "lreedy@gmail.com", true, false, null, "LREEDY@GMAIL.COM", "lreedy@gmail.com", "AQAAAAIAAYagAAAAEL9FmvySfip/77gSByaGZpGtkdGh3qYUzIx6vzo4dqjph/ET0Y1jJJJrvUQPMTfbCg==", null, false, "", false, "lreedy@gmail.com" },
                    { "58574246aa45842a200103db", 0, "8126d374-9942-4ac5-a628-2dbe4edb35ff", "Daniel Fonseca", "dfonseca@i3verticals.com", true, false, null, "DFONSECA@I3VERTICALS.COM", "dfonseca@i3verticals.com", "AQAAAAIAAYagAAAAEMBDoSgYgDV2ibykPWa0hI4m+LTVB42m//5K/8GWDDJtt8oCIY8adCKVHlkHGY1uew==", null, false, "", false, "dfonseca@i3verticals.com" },
                    { "585742f4aa45842a200193b2", 0, "c9ac3274-68ab-4f09-9997-5f93fa3b0bec", "Justin Esber", "justin.esber@payschools.com", true, false, null, "JUSTIN.ESBER@PAYSCHOOLS.COM", "justin.esber@payschools.com", "AQAAAAIAAYagAAAAEIxBLgK9rmInQLH11C4xrygmOJVkjdXrz1kF6zsJt40BaXs3o2q9AOYjcC1XHlEwuQ==", null, false, "", false, "justin.esber@payschools.com" },
                    { "59691d964b9cfc16a848e768", 0, "f6907389-dd3d-489f-9a1c-1dd9fda3f6ca", "David Sowiak", "dsowiak@i3verticals.com", true, false, null, "DSOWIAK@I3VERTICALS.COM", "DSOWIAK@I3VERTICALS.COM", "AQAAAAIAAYagAAAAEFuMXfe17S2VKFydSYc1LR/IEs4bOvMLYXDPf5LNBDPzZucvYuSlO+OgTeCTUVpYUA==", null, false, "", false, "dsowiak@i3verticals.com" },
                    { "597b2d274b9cfc2e6c819088", 0, "a06ec454-01cf-4a91-9565-96c864be18ab", "Tee Locke", "tee.locke@neo.rr.com", true, false, null, "TEE.LOCKE@NEO.RR.COM", "tee.locke@neo.rr.com", "AQAAAAIAAYagAAAAEBU1ftWq45XENEPU+hxZULphze1t35F8bY4fZJhs46Op4B1YpTfd75F4QIhfwzIDtw==", null, false, "", false, "tee.locke@neo.rr.com" },
                    { "5d4a2dfdcd49961c2cd5729f", 0, "bf03e21a-b15c-4fe9-a68a-30d85b875d20", "Benji Lamfers", "benji.lamfers@i3verticals.com", true, false, null, "BENJI.LAMFERS@I3VERTICALS.com", "benji.lamfers@i3verticals.com", "AQAAAAIAAYagAAAAEM8+wXDt/kHpY25hAPOBXSJtQQMeiUY1vSkV49rxCj5qAQnECl9QJcEcFdRC+Grarw==", null, false, "", false, "benji.lamfers@i3verticals.com" },
                    { "61d470129b42b0f4965aad74", 0, "880ec31a-137b-438c-8ab0-479452fcfb96", "Alyssa Smith", "asmith@i3verticals.com", true, false, null, "ASMITH@I3VERTICALS.COM", "asmith@i3verticals.com", "AQAAAAIAAYagAAAAEDoag9DwY5rAfgBsRPShcZkYyzCipXLq8Ytniibi8SYLomRzqgpji4xMSaWWeweRZg==", null, false, "", false, "asmith@i3verticals.com" },
                    { "620bd70caf64c4562d58b84c", 0, "f47aedc4-48a8-4a5a-838f-616104c5f9fe", "Christian Zarnke", "czarnke@i3verticals.com", true, false, null, "CZARNKE@I3VERTICALS.COM", "czarnke@i3verticals.com", "AQAAAAIAAYagAAAAEDNoIE4zpZ2dhLLmGZaIfS6JK86hNbcIgED1zctg3BmBONEcyIwgguLaz3bUAR0LcA==", null, false, "", false, "czarnke@i3verticals.com" },
                    { "62420940457e21a2ca768c79", 0, "05a7a116-e654-4f6f-ae96-e8300a01984e", "Angela Hardy", "astovallhardy@i3verticals.com", true, false, null, "ASTOVALLHARDY@I3VERTICALS.COM", "astovallhardy@i3verticals.com", "AQAAAAIAAYagAAAAEIqup9KnjIVP3/a2V85Kbzqq0xGyFNxsaH3kC6dDyiaEDHYzVF4PR9LyqhZj+Y5GDQ==", null, false, "", false, "astovallhardy@i3verticals.com" },
                    { "636c2737b81806331e91f99e", 0, "341b66dc-0e65-4088-a6ec-1ad15cb24563", "Vadeene Sisk", "vsisk@i3verticals.com", true, false, null, "VSISK@I3VERTICALS.COM", "vsisk@i3verticals.com", "AQAAAAIAAYagAAAAEDpQI89YMkUYKw3oiYChWUyuT+W2mUntVMdDgAmU3OOE12CEoruXqjZT5wu113r0uw==", null, false, "", false, "vsisk@i3verticals.com" },
                    { "63740329467a12cd1cf74e41", 0, "d762746f-c28f-4d7b-b392-b21e1ac8c466", "Sonya Ridinger", "sridinger@i3verticals.com", true, false, null, "SRIDINGER@I3VERTICALS.COM", "sridinger@i3verticals.com", "AQAAAAIAAYagAAAAEJ8aVCjTb2YQ8WrO7Z9RIyRmEevv9OtdvQvlnTfa7l3qNCNUnKXFtREQ68yPNnsctg==", null, false, "", false, "sridinger@i3verticals.com" },
                    { "63a249ee424c29d968059d8d", 0, "4e158007-8d6c-401c-ac68-8119ace3bacc", "Sys Admin", "Sysadmin@i3Verticals.com", true, false, null, "SYSADMIN@I3VERTICALS.COM", "Sysadmin@i3Verticals.com", "AQAAAAIAAYagAAAAEOZmD29p6PFnpzGwB3vIlS9Q6YRXg8tf13RBJeB77sWfqu0FwGgtNbKhDz/N8nnx7w==", null, false, "", false, "Sysadmin@i3Verticals.com" },
                    { "63b6ec7733247bfd8698d629", 0, "578b5c2c-aa4b-466a-82e9-89d12aa361a9", "Colleen Rumsey", "crumsey@i3verticals.com", true, false, null, "CRUMSEY@I3VERTICALS.COM", "crumsey@i3verticals.com", "AQAAAAIAAYagAAAAEBsmaeCgaPyxgmzz+YmQ1ubJ3RyJHURix8dXM2iJaqV64vf84Q1f2AeVBCCqkdRrJA==", null, false, "", false, "crumsey@i3verticals.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "58574197aa45842a20007798" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "58574246aa45842a200103db" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "585742f4aa45842a200193b2" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "59691d964b9cfc16a848e768" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "597b2d274b9cfc2e6c819088" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "5d4a2dfdcd49961c2cd5729f" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "61d470129b42b0f4965aad74" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "620bd70caf64c4562d58b84c" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "62420940457e21a2ca768c79" },
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "636c2737b81806331e91f99e" },
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "63740329467a12cd1cf74e41" },
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "63a249ee424c29d968059d8d" },
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "63b6ec7733247bfd8698d629" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "58574197aa45842a20007798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "58574246aa45842a200103db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "585742f4aa45842a200193b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "59691d964b9cfc16a848e768" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "597b2d274b9cfc2e6c819088" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "5d4a2dfdcd49961c2cd5729f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "61d470129b42b0f4965aad74" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "620bd70caf64c4562d58b84c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "62420940457e21a2ca768c79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "636c2737b81806331e91f99e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "63740329467a12cd1cf74e41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "63a249ee424c29d968059d8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "63b6ec7733247bfd8698d629" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58574197aa45842a20007798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58574246aa45842a200103db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "585742f4aa45842a200193b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59691d964b9cfc16a848e768");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "597b2d274b9cfc2e6c819088");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d4a2dfdcd49961c2cd5729f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d470129b42b0f4965aad74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "620bd70caf64c4562d58b84c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62420940457e21a2ca768c79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "636c2737b81806331e91f99e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63740329467a12cd1cf74e41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63a249ee424c29d968059d8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63b6ec7733247bfd8698d629");

            migrationBuilder.AddColumn<string>(
                name: "UAPIUserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UAPIUserId", "UserName" },
                values: new object[,]
                {
                    { "1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71", 0, "75ec5316-72b5-42b1-8ed4-40cfa1f62d13", "Angela Hardy", "astovallhardy@i3verticals.com", true, false, null, "ASTOVALLHARDY@I3VERTICALS.COM", "astovallhardy@i3verticals.com", "AQAAAAIAAYagAAAAEHXOp00+DT+jAp9pf8ld85H79I0579UqVJzxWauLChjglHGPfRxrQwhZl+6yr1jlcg==", null, false, "", false, "62420940457e21a2ca768c79", "astovallhardy@i3verticals.com" },
                    { "2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62", 0, "5936ee9a-d40a-43dd-9ccb-722683281a63", "Benji Lamfers", "benji.lamfers@i3verticals.com", true, false, null, "BENJI.LAMFERS@I3VERTICALS.com", "benji.lamfers@i3verticals.com", "AQAAAAIAAYagAAAAEMERHSZOACss5mMylKDmswRlnkimi7Hs9/1VAgp4jhRgHf/zp7Xx/OlUUTNW8dsx+w==", null, false, "", false, "5d4a2dfdcd49961c2cd5729f", "benji.lamfers@i3verticals.com" },
                    { "4e9b671d-865e-4c6a-b283-1c5d214c5939", 0, "8da2a52f-ce4c-4280-8ad0-da56f32237b6", "Daniel Fonseca", "dfonseca@i3verticals.com", true, false, null, "DFONSECA@I3VERTICALS.COM", "dfonseca@i3verticals.com", "AQAAAAIAAYagAAAAELpGIwAMDkt/SoSYgBaPpol37pN8l2RcOBHZ3YyRVZC7DEB5FKHnBnO8tOZRIsLB9g==", null, false, "", false, "58574246aa45842a200103db", "dfonseca@i3verticals.com" },
                    { "58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7", 0, "32af9380-fd08-4a51-90a6-0edc6c91f53c", "Alyssa Smith", "asmith@i3verticals.com", true, false, null, "ASMITH@I3VERTICALS.COM", "asmith@i3verticals.com", "AQAAAAIAAYagAAAAEOacXvKdv/3YsXf0xkSganbdrM0E7RFuVGgHDwRlrMbzGYeAqmmcc03lQXjwMtlCpQ==", null, false, "", false, "61d470129b42b0f4965aad74", "asmith@i3verticals.com" },
                    { "73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34", 0, "d5cb3d14-d748-4e31-b3cc-d95a0f60d75e", "Justin Esber", "justin.esber@payschools.com", true, false, null, "JUSTIN.ESBER@PAYSCHOOLS.COM", "justin.esber@payschools.com", "AQAAAAIAAYagAAAAEATny0J9En9YNWqhdd6luMZrIrvJQOjWgR88v+ie7FkV9sahhyw86JpSI1rNYbw0Lw==", null, false, "", false, "585742f4aa45842a200193b2", "justin.esber@payschools.com" },
                    { "87ad364d-53c9-4698-b0a1-c01f91c6f4b0", 0, "4f86388b-60af-4700-97fd-03066e5dc50b", "Lisa Reedy", "lreedy@gmail.com", true, false, null, "LREEDY@GMAIL.COM", "lreedy@gmail.com", "AQAAAAIAAYagAAAAEKmB6eJZAFHPi6o94mVXha3guLfR5Jf8fn8G0CmMDAeJ+7W0M2LgcqW/QJbSbsDZMw==", null, false, "", false, "58574197aa45842a20007798", "lreedy@gmail.com" },
                    { "9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49", 0, "0ef4ed2f-4b0a-4e27-817c-9079088c9e34", "Tee Locke", "tee.locke@neo.rr.com", true, false, null, "TEE.LOCKE@NEO.RR.COM", "tee.locke@neo.rr.com", "AQAAAAIAAYagAAAAEN7cP3Hd1n0X6LvazKcDDw8KyFrWDz41BvMPiiulAMb/2JeVd8MID8gSdDuUZpWutQ==", null, false, "", false, "597b2d274b9cfc2e6c819088", "tee.locke@neo.rr.com" },
                    { "b0145c62-e346-4ea8-ace2-6d82f84c9e2c", 0, "69933d0a-9a52-41ce-9ab3-76245d8eabaa", "Christian Zarnke", "czarnke@i3verticals.com", true, false, null, "CZARNKE@I3VERTICALS.COM", "czarnke@i3verticals.com", "AQAAAAIAAYagAAAAEJTUQERdOB7O5aHM6wNEB14+JwJl6xnWgGaV9XSCSMFQclYy7OMgNg1wlcq4SR5pjw==", null, false, "", false, "620bd70caf64c4562d58b84c", "czarnke@i3verticals.com" },
                    { "c83b57ef-024b-48d9-939d-5b8d8e0b7d23", 0, "ff6774a9-34c0-4ce9-92e6-5f2889a0abde", "Sys Admin", "Sysadmin@i3Verticals.com", true, false, null, "SYSADMIN@I3VERTICALS.COM", "Sysadmin@i3Verticals.com", "AQAAAAIAAYagAAAAENGXfT80YGPx3nC4Hlpi+BmwHr3htgFefQBlpfSg26egc354Mrp1dCOcrZ4Y5Z/XCw==", null, false, "", false, "63a249ee424c29d968059d8d", "Sysadmin@i3Verticals.com" },
                    { "df9f1ac6-616b-44b0-a1de-85a56c7d4a58", 0, "cfe486ad-59a3-4563-b80c-ca4e9027642b", "Vadeene Sisk", "vsisk@i3verticals.com", true, false, null, "VSISK@I3VERTICALS.COM", "vsisk@i3verticals.com", "AQAAAAIAAYagAAAAEO8FSJw+AlEfvaPE1zycaaEfT9cWuVVzXRP7gg6uFp8g8OfdfojkquJeHbJUwFCVhg==", null, false, "", false, "636c2737b81806331e91f99e", "vsisk@i3verticals.com" },
                    { "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2", 0, "2fd75cc1-40b8-4773-ae49-fe84c5b658f9", "Sonya Ridinger", "sridinger@i3verticals.com", true, false, null, "SRIDINGER@I3VERTICALS.COM", "sridinger@i3verticals.com", "AQAAAAIAAYagAAAAEH7M6tIrj1U/WlMU7pk/DqKbSQYgc4ZBZTSf+BCWr6jvnO0msDnouivasL/wprG1Cw==", null, false, "", false, "61d470129b42b0f4965aad74", "sridinger@i3verticals.com" },
                    { "f6e134e9-402b-4782-bca6-7e1f9a5d6c1f", 0, "19e69c5a-8cd4-466e-8fd0-3b696c5f07e8", "Colleen Rumsey", "crumsey@i3verticals.com", true, false, null, "CRUMSEY@I3VERTICALS.COM", "crumsey@i3verticals.com", "AQAAAAIAAYagAAAAEDCsZdDD9oVchfyuQmTaJXW9SRwqb39rJgLwdqf0cOpw3u7XNTWpe3BCiMNVrvGbXw==", null, false, "", false, "63b6ec7733247bfd8698d629", "crumsey@i3verticals.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "4e9b671d-865e-4c6a-b283-1c5d214c5939" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "87ad364d-53c9-4698-b0a1-c01f91c6f4b0" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "b0145c62-e346-4ea8-ace2-6d82f84c9e2c" },
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "c83b57ef-024b-48d9-939d-5b8d8e0b7d23" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "df9f1ac6-616b-44b0-a1de-85a56c7d4a58" },
                    { "39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a", "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2" },
                    { "7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f", "f6e134e9-402b-4782-bca6-7e1f9a5d6c1f" }
                });
        }
    }
}
