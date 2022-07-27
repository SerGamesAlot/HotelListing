using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d8733a3-72a4-4601-9a23-3e9fa917793d", "8f39e92b-94d5-4775-883b-ff27d6a36e5e", "User", "USER" },
                    { "87f00b44-d4f8-4a7c-9762-c281b21efa80", "1718ead5-e772-47f0-9a7a-f1302381d235", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Rating" },
                values: new object[] { "George Town", "ComfortSuites", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Rating" },
                values: new object[] { "Nassau", "Grand Palladium", 4.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d8733a3-72a4-4601-9a23-3e9fa917793d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87f00b44-d4f8-4a7c-9762-c281b21efa80");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Rating" },
                values: new object[] { "Nassau", "Grand Palladium", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Rating" },
                values: new object[] { "George Town", "Comfort Suites", 4.2999999999999998 });
        }
    }
}
