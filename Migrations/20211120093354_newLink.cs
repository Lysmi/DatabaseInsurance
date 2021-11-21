using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class newLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Offices",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "SocialID",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Branches",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "AmountWorkers",
                table: "Branches",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CityID",
                table: "Clients",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SocialID",
                table: "Clients",
                column: "SocialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Cities_CityID",
                table: "Clients",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Socials_SocialID",
                table: "Clients",
                column: "SocialID",
                principalTable: "Socials",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Clients_CityID",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_SocialID",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SocialID",
                table: "Clients");

            migrationBuilder.AlterColumn<long>(
                name: "Year",
                table: "Offices",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PositionID",
                table: "Clients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "Year",
                table: "Branches",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "AmountWorkers",
                table: "Branches",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
