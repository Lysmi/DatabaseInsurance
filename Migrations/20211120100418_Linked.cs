using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Linked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VarID",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "InsuranseID",
                table: "Contracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_BranchID",
                table: "Workers",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_CityID",
                table: "Offices",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_LicenseID",
                table: "Offices",
                column: "LicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_TypePropertyID",
                table: "Offices",
                column: "TypePropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ClientID",
                table: "Contracts",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_InsuranseID",
                table: "Contracts",
                column: "InsuranseID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_WorkerID",
                table: "Contracts",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CityID",
                table: "Branches",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_OfficeID",
                table: "Branches",
                column: "OfficeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Cities_CityID",
                table: "Branches",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Offices_OfficeID",
                table: "Branches",
                column: "OfficeID",
                principalTable: "Offices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Clients_ClientID",
                table: "Contracts",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_InsuranseVariants_InsuranseID",
                table: "Contracts",
                column: "InsuranseID",
                principalTable: "InsuranseVariants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Workers_WorkerID",
                table: "Contracts",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offices_Cities_CityID",
                table: "Offices",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offices_Licenses_LicenseID",
                table: "Offices",
                column: "LicenseID",
                principalTable: "Licenses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offices_TypeProperties_TypePropertyID",
                table: "Offices",
                column: "TypePropertyID",
                principalTable: "TypeProperties",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Branches_BranchID",
                table: "Workers",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Cities_CityID",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Offices_OfficeID",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Clients_ClientID",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_InsuranseVariants_InsuranseID",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Workers_WorkerID",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Offices_Cities_CityID",
                table: "Offices");

            migrationBuilder.DropForeignKey(
                name: "FK_Offices_Licenses_LicenseID",
                table: "Offices");

            migrationBuilder.DropForeignKey(
                name: "FK_Offices_TypeProperties_TypePropertyID",
                table: "Offices");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Branches_BranchID",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_BranchID",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Offices_CityID",
                table: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Offices_LicenseID",
                table: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Offices_TypePropertyID",
                table: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ClientID",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_InsuranseID",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_WorkerID",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Branches_CityID",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Branches_OfficeID",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "InsuranseID",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "VarID",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
