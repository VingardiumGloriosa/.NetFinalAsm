using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addEventMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 12, 28, 619, DateTimeKind.Local).AddTicks(5903));

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
    }
}
