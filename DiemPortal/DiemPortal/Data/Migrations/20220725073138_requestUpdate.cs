using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class requestUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TerminTarihi",
                table: "Request",
                newName: "DeadLine");

            migrationBuilder.RenameColumn(
                name: "Miktar",
                table: "Request",
                newName: "CoNo");

            migrationBuilder.RenameColumn(
                name: "Marka",
                table: "Request",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "CoPozu",
                table: "Request",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Birim",
                table: "Request",
                newName: "SubContractor");

            migrationBuilder.RenameColumn(
                name: "AltYuklenici",
                table: "Request",
                newName: "RequestInfo");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Request",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Request",
                newName: "Marka");

            migrationBuilder.RenameColumn(
                name: "SubContractor",
                table: "Request",
                newName: "Birim");

            migrationBuilder.RenameColumn(
                name: "RequestInfo",
                table: "Request",
                newName: "AltYuklenici");

            migrationBuilder.RenameColumn(
                name: "DeadLine",
                table: "Request",
                newName: "TerminTarihi");

            migrationBuilder.RenameColumn(
                name: "CoNo",
                table: "Request",
                newName: "Miktar");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Request",
                newName: "CoPozu");
        }
    }
}
