using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addEventMigration24354Z : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e6a3456-09d8-4ca6-84db-df44dcfd94c8", "AQAAAAEAACcQAAAAEDCd0UnI1E7Kxkc0EtC3Cb0paWXvHoAtSHaLIvO11m7SESk23c56jzCcTDYkCydz0Q==", "03845598-3703-4c93-bfab-0e9a086c1b79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f47650c2-bf74-4bc1-b5a4-3113bb97264c", "AQAAAAEAACcQAAAAEHCp9evN5KDIy0+IGujR+3juCK0tx+JQvCFOalNdDFnpSc/k1m1PvQX1GNLoN6LYPA==", "546f0273-7162-4135-a7bc-0b191273bf2c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 19, 32, 725, DateTimeKind.Local).AddTicks(3304));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
