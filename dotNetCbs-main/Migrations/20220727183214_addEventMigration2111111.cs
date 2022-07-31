using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addEventMigration2111111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7e2c61b-b527-4980-907d-770eab45d08e", "AQAAAAEAACcQAAAAEHzXsIfJjT+yqvRMMntNpxTeKxVBo1rtVchcLl90k8RThgYrtv7wuJRvcRBjU3+DWA==", "69f33c49-ecfd-4d01-9a75-eb6e55dc4e01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e96ca18-c0d0-4748-95d1-ebe7cba406a2", "AQAAAAEAACcQAAAAED1Ia4Ss0agCPjhOp9hdvE4SFrui4v1OKXyj2c1QdRJnAPDH/VxzoLmMzi6SRIKIOA==", "d6cf12b1-ab32-441c-878c-b6969c9cffea" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Title" },
                values: new object[] { 4, new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7938), "fuck me sideways", "No" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Title" },
                values: new object[] { 5, new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7940), "here is an orgy", "No again" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Title" },
                values: new object[] { 6, new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7942), "woow. sex.", "Noo once more" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 27, 19, 32, 13, 789, DateTimeKind.Local).AddTicks(7838));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 6);

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
    }
}
