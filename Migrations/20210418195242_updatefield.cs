using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicBilling.API.Migrations
{
    public partial class updatefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Clients_ClientsId",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Clients",
                newName: "clientId");

            migrationBuilder.RenameColumn(
                name: "Periodo",
                table: "Bills",
                newName: "period");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Bills",
                newName: "clientId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ClientsId",
                table: "Bills",
                newName: "IX_Bills_clientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Clients_clientId",
                table: "Bills",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Clients_clientId",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Clients",
                newName: "ClientsId");

            migrationBuilder.RenameColumn(
                name: "period",
                table: "Bills",
                newName: "Periodo");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Bills",
                newName: "ClientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_clientId",
                table: "Bills",
                newName: "IX_Bills_ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Clients_ClientsId",
                table: "Bills",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "ClientsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
