using Microsoft.EntityFrameworkCore.Migrations;

namespace users_groups.data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[,]
                {
                    { 1, "Hosts" },
                    { 2, "Replicants" },
                    { 3, "Humans" },
                    { 4, "Cyborgs" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "GroupId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Dolores Abernathy" },
                    { 2, 1, "Bernard Lowe" },
                    { 3, 1, "Maeve Millay" },
                    { 4, 2, "Rick Deckard" },
                    { 5, 2, "Rachel" },
                    { 6, 3, "Robert Ford" },
                    { 7, 3, "William" },
                    { 8, 4, "T1000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
