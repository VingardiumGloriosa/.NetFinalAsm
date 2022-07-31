using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addEventMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a4c1d32-4f89-4fa8-bfc7-332bdacc9d34", "AQAAAAEAACcQAAAAEHKZxKkjJcHlZQq0PccG/cOyC3XaOyOhldq9VRFR/pUwP0Hmb9HudsCUo4r5hhKQSQ==", "ac07aba1-311a-4da0-ad10-ebf2c30ca459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3897f6dd-4032-430b-911e-6bd10c08ec54", "AQAAAAEAACcQAAAAEDkIqXxCSoqieiiwGLjOx0rUeBC/tLkKWmnDWd+OVHTnevvq0R4ZPLAzWVLo6YLuCg==", "bf62af52-48c9-4d83-8019-afddca151c08" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 16, 54, 854, DateTimeKind.Local).AddTicks(8457));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b37873a-a027-45ac-a94f-c1cdbe6ee34c", "AQAAAAEAACcQAAAAEMRoNEa6oCLXWjAAtSa2WbdyI+rq7PeZw3CUo4olIOIMDTQmjNJLc5DyE6+7HxvkWg==", "157c7355-d000-4f25-a042-27a449227bee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c6a77d-53e8-47c0-ac41-637814f93d10", "AQAAAAEAACcQAAAAEJDM7LGDfC3WxoUfmD5tqzB+oBYlSjCkZXzL2gnymwozKi+hIS9PgXIRCHz+6Kqj7Q==", "1ef3c77e-2aa7-4e33-b8f0-eb50d380fd48" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 14, 51, 855, DateTimeKind.Local).AddTicks(5246));
        }
    }
}
