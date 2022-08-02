using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class addedForeginKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Request_ProjectId",
                table: "Request",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Project_ProjectId",
                table: "Request",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Project_ProjectId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_ProjectId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Request");
        }
    }
}
