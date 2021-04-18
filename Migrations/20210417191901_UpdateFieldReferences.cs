using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicBilling.API.Migrations
{
    public partial class UpdateFieldReferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Clients_clientsID",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Services_ServicesID",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Services",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Clients",
                newName: "ClientsId");

            migrationBuilder.RenameColumn(
                name: "clientsID",
                table: "Bills",
                newName: "ClientsId");

            migrationBuilder.RenameColumn(
                name: "ServicesID",
                table: "Bills",
                newName: "ServicesId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ServicesID",
                table: "Bills",
                newName: "IX_Bills_ServicesId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_clientsID",
                table: "Bills",
                newName: "IX_Bills_ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Clients_ClientsId",
                table: "Bills",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "ClientsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Services_ServicesId",
                table: "Bills",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "ServicesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Clients_ClientsId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Services_ServicesId",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "Services",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Clients",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "Bills",
                newName: "ServicesID");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Bills",
                newName: "clientsID");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ServicesId",
                table: "Bills",
                newName: "IX_Bills_ServicesID");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ClientsId",
                table: "Bills",
                newName: "IX_Bills_clientsID");

            migrationBuilder.AddColumn<string>(
                name: "ClienteID",
                table: "Bills",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Clients_clientsID",
                table: "Bills",
                column: "clientsID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Services_ServicesID",
                table: "Bills",
                column: "ServicesID",
                principalTable: "Services",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
