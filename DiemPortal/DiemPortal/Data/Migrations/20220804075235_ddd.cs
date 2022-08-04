using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Supplier",
                newName: "SupplierName");

            migrationBuilder.AddColumn<int>(
                name: "IbanEur",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IbanTr",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IbanUsd",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuplierAddress",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TaxAdministration",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxNo",
                table: "Supplier",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IbanEur",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IbanTr",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IbanUsd",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "SuplierAddress",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "TaxAdministration",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "TaxNo",
                table: "Supplier");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "Supplier",
                newName: "Name");
        }
    }
}
