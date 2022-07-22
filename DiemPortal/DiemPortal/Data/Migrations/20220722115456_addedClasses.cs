using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiemPortal.Data.Migrations
{
    public partial class addedClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectManager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoPozu = table.Column<int>(type: "int", nullable: false),
                    TerminTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AltYuklenici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SevkAdresiAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Request_Address_SevkAdresiAddressId",
                        column: x => x.SevkAdresiAddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_SevkAdresiAddressId",
                table: "Request",
                column: "SevkAdresiAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
