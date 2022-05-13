using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryApp.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "StudentDetail",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "FirstName", "LastName", "MofidiedDate", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 13, 11, 1, 31, 489, DateTimeKind.Local).AddTicks(8815), null, "Serhan", "Kılıç", null, "5555555", 1 },
                    { 2, new DateTime(2022, 5, 13, 11, 1, 31, 489, DateTimeKind.Local).AddTicks(9994), null, "Kaan", "Kutucu", null, "33333", 1 },
                    { 3, new DateTime(2022, 5, 13, 11, 1, 31, 490, DateTimeKind.Local).AddTicks(11), null, "Özgür", "Cansız", null, "123456", 1 },
                    { 4, new DateTime(2022, 5, 13, 11, 1, 31, 490, DateTimeKind.Local).AddTicks(15), null, "Zeynep", "Kurt", null, "4444444", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "MofidiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 13, 11, 1, 31, 484, DateTimeKind.Local).AddTicks(1102), null, null, "$2a$11$32Ci7fsUEYq8fT0/jlPmmennqRPu/d35fN15BVvoMMq3CfWBYhpny", 1, 1, "admin" },
                    { 2, new DateTime(2022, 5, 13, 11, 1, 31, 488, DateTimeKind.Local).AddTicks(3687), null, null, "$2a$11$XYqH84sfCb09wEwDdIoNzO/fokpaLKQlc74U.syizRdbyfjgpyNYa", 2, 1, "oguz" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "DeletedDate", "Gender", "MofidiedDate", "SchoolNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 5, 13, 11, 1, 31, 490, DateTimeKind.Local).AddTicks(769), null, 1, null, (short)244, 1, 1 },
                    { 2, null, new DateTime(2022, 5, 13, 11, 1, 31, 490, DateTimeKind.Local).AddTicks(2037), null, 1, null, (short)123, 1, 2 },
                    { 3, null, new DateTime(2022, 5, 13, 11, 1, 31, 490, DateTimeKind.Local).AddTicks(2055), null, 1, null, (short)444, 1, 3 },
                    { 4, null, new DateTime(2022, 5, 13, 11, 1, 31, 490, DateTimeKind.Local).AddTicks(2059), null, 2, null, (short)122, 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "StudentDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
