using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TusaBulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompanyRecords1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "6669990001");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "6669990000");
        }
    }
}
