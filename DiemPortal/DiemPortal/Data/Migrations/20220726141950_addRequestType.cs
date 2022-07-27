using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class addRequestType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestType",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "Request");
        }
    }
}
