using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Data.Migrations
{
    public partial class SeedDataEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreateDate", "Date", "Image", "Name" },
                values: new object[] { 1, new DateTime(2021, 10, 17, 7, 4, 27, 592, DateTimeKind.Local).AddTicks(9582), new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://georgiantravelguide.com/storage/files/img-20200725-153140.jpg", "ჯაზზ საღამო მუშტაიდის ბაღში" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
