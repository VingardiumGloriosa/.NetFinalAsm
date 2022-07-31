using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d742a341-1359-4b8f-b412-08c19823ffe1", "AQAAAAEAACcQAAAAEO2lsRCO23wUtsKAnlVtW8P9xPIa6i2lFtRiVlcGq6yBZnshj9vgH5/+gJVWz4aN+w==", "32cb83a7-570e-4267-96d4-f04f3fb155db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cdf26b4-c4f4-423b-969e-20847eb63716", "AQAAAAEAACcQAAAAEJ0RYVSFxBGUwOW6XS9UqMcX3mNAz0Iq/33QyXnNciqWTn0IaDXVUiSyDpOxU6uiGQ==", "6a14c1a5-c780-4724-aa19-38f5266e5cda" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 7, 5, 546, DateTimeKind.Local).AddTicks(6227));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6e0e8b-5c42-49dd-81a4-4e2d51402328", "AQAAAAEAACcQAAAAEAtw7H60mzjhPwaZ+NqRkAjZ4aeSde5fu3YGLSI94/mU/6WuVkBLkykIKECj4a1BxQ==", "3022a109-4222-44bc-a24c-7af9e69df2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc398c9-9202-49b1-b82a-b5e1efd6838b", "AQAAAAEAACcQAAAAEJJ6LmqTnZ+ADQg+V3hgbbOL7y45YvStRo+ySZYGZIEFjHcV0qG8c3I5x06VKudZ1Q==", "26034978-c05a-40e5-92d2-3a5262682eb6" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 739, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));
        }
    }
}
