using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Underwriting.Migrations
{
    /// <inheritdoc />
    public partial class MappingSysAdminUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75ec5316-72b5-42b1-8ed4-40cfa1f62d13", "AQAAAAIAAYagAAAAEHXOp00+DT+jAp9pf8ld85H79I0579UqVJzxWauLChjglHGPfRxrQwhZl+6yr1jlcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5936ee9a-d40a-43dd-9ccb-722683281a63", "AQAAAAIAAYagAAAAEMERHSZOACss5mMylKDmswRlnkimi7Hs9/1VAgp4jhRgHf/zp7Xx/OlUUTNW8dsx+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b671d-865e-4c6a-b283-1c5d214c5939",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8da2a52f-ce4c-4280-8ad0-da56f32237b6", "AQAAAAIAAYagAAAAELpGIwAMDkt/SoSYgBaPpol37pN8l2RcOBHZ3YyRVZC7DEB5FKHnBnO8tOZRIsLB9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32af9380-fd08-4a51-90a6-0edc6c91f53c", "AQAAAAIAAYagAAAAEOacXvKdv/3YsXf0xkSganbdrM0E7RFuVGgHDwRlrMbzGYeAqmmcc03lQXjwMtlCpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5cb3d14-d748-4e31-b3cc-d95a0f60d75e", "AQAAAAIAAYagAAAAEATny0J9En9YNWqhdd6luMZrIrvJQOjWgR88v+ie7FkV9sahhyw86JpSI1rNYbw0Lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87ad364d-53c9-4698-b0a1-c01f91c6f4b0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f86388b-60af-4700-97fd-03066e5dc50b", "AQAAAAIAAYagAAAAEKmB6eJZAFHPi6o94mVXha3guLfR5Jf8fn8G0CmMDAeJ+7W0M2LgcqW/QJbSbsDZMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ef4ed2f-4b0a-4e27-817c-9079088c9e34", "AQAAAAIAAYagAAAAEN7cP3Hd1n0X6LvazKcDDw8KyFrWDz41BvMPiiulAMb/2JeVd8MID8gSdDuUZpWutQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0145c62-e346-4ea8-ace2-6d82f84c9e2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69933d0a-9a52-41ce-9ab3-76245d8eabaa", "AQAAAAIAAYagAAAAEJTUQERdOB7O5aHM6wNEB14+JwJl6xnWgGaV9XSCSMFQclYy7OMgNg1wlcq4SR5pjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c83b57ef-024b-48d9-939d-5b8d8e0b7d23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff6774a9-34c0-4ce9-92e6-5f2889a0abde", "AQAAAAIAAYagAAAAENGXfT80YGPx3nC4Hlpi+BmwHr3htgFefQBlpfSg26egc354Mrp1dCOcrZ4Y5Z/XCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df9f1ac6-616b-44b0-a1de-85a56c7d4a58",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfe486ad-59a3-4563-b80c-ca4e9027642b", "AQAAAAIAAYagAAAAEO8FSJw+AlEfvaPE1zycaaEfT9cWuVVzXRP7gg6uFp8g8OfdfojkquJeHbJUwFCVhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e207c07e-32d2-45b8-a0a2-ef2ca333f2c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fd75cc1-40b8-4773-ae49-fe84c5b658f9", "AQAAAAIAAYagAAAAEH7M6tIrj1U/WlMU7pk/DqKbSQYgc4ZBZTSf+BCWr6jvnO0msDnouivasL/wprG1Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6e134e9-402b-4782-bca6-7e1f9a5d6c1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19e69c5a-8cd4-466e-8fd0-3b696c5f07e8", "AQAAAAIAAYagAAAAEDCsZdDD9oVchfyuQmTaJXW9SRwqb39rJgLwdqf0cOpw3u7XNTWpe3BCiMNVrvGbXw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
