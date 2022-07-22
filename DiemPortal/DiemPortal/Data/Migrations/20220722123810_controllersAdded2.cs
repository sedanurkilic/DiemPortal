using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class controllersAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Address_SevkAdresiAddressId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_SevkAdresiAddressId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "SevkAdresiAddressId",
                table: "Request");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SevkAdresiAddressId",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Request_SevkAdresiAddressId",
                table: "Request",
                column: "SevkAdresiAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Address_SevkAdresiAddressId",
                table: "Request",
                column: "SevkAdresiAddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
