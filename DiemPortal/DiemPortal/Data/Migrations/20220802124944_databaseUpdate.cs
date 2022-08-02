using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class databaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubContractor",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CoNo",
                table: "Request",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DiscoveryNo",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Request",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IbanEur",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IbanTr",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IbanUsd",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxAdministration",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxNo",
                table: "Project",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscoveryNo",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CustomerAddress",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IbanEur",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IbanTr",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IbanUsd",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "TaxAdministration",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "TaxNo",
                table: "Project");

            migrationBuilder.AlterColumn<string>(
                name: "SubContractor",
                table: "Request",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoNo",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
