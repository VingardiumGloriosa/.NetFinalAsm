using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addEventMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b475806f-9ae7-44a2-a61b-5d9976db60cd", "AQAAAAEAACcQAAAAECqMHk+LyFcKrww2trt6P0jOW79DsteyWe3gvuonDwC1/rhNGv2yxnA2BxYPT9grng==", "f139cb15-1713-4ef2-94bd-27396cd202fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd382d0f-9f18-4db7-a7e5-d1e3a5aee93e", "AQAAAAEAACcQAAAAED/QHb7I3ptopXqWWxBtw8myMhE4RIoFF68OrgkPPAc9htl8YALaJisKsytAPaJO6Q==", "89301eb7-2cb4-47c8-b217-f01ba4283bbb" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Title" },
                values: new object[] { 1, new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5894), "", "Hello" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Title" },
                values: new object[] { 2, new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5900), "", "Hello again" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Title" },
                values: new object[] { 3, new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5903), "", "Hello once more" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5819));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3);

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
    }
}
