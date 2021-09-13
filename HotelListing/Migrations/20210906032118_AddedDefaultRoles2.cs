using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52e74881-7e52-4a0e-a3af-3931e8413da6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5cc8b15-4429-45f9-af1b-55710036cf0a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "baa56620-895a-430d-8ca7-857bcbbc3834", "84c2d705-2c56-4e09-b8e8-efdc392ca1ed", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5736b7f1-1a55-4f6f-b3cf-edf41a88eb9b", "ba9545bf-69b3-497c-ad2d-47e871a06e17", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5736b7f1-1a55-4f6f-b3cf-edf41a88eb9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa56620-895a-430d-8ca7-857bcbbc3834");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5cc8b15-4429-45f9-af1b-55710036cf0a", "888a12cb-b569-4872-9101-a20aaf397326", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52e74881-7e52-4a0e-a3af-3931e8413da6", "e9d55fae-6ba9-427c-be11-6e0953fbd120", "Administrator", "ADMINISTRATOR" });
        }
    }
}
