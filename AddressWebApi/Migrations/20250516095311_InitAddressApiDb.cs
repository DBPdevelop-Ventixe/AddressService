using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitAddressApiDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[] { "1", "Miami", "USA", "FL", "123 Sunset St", "4153" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
