using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addEventMigration24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2b3f272-2087-4bbb-a528-b508557ec0f9", "AQAAAAEAACcQAAAAEAtf4M49cC9zTMsEKzoJ6IizuDSQbGvA+DBKhtDrAGziZw6YkBR6PjEndQ1cjmeEdg==", "d5844b7b-c4a6-4c35-b914-6438141fbfa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82c61ae9-e816-4abf-ae24-58842f55337a", "AQAAAAEAACcQAAAAEABIJLC/VtVKLXXA8HphmvkOM4f5lfREgYMI+xRUv8CjKnk98z6yWg3JBwrZXbubGg==", "ce3dba34-be15-4ac4-b3fe-0fb9ce0898f5" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 28, 19, 817, DateTimeKind.Local).AddTicks(4714));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
