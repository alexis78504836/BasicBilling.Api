using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicBilling.API.Migrations
{
    public partial class UpdateBills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Services_servicesID",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "servicesID",
                table: "Bills",
                newName: "ServicesID");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_servicesID",
                table: "Bills",
                newName: "IX_Bills_ServicesID");

            migrationBuilder.AlterColumn<int>(
                name: "ServicesID",
                table: "Bills",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Monto",
                table: "Bills",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ClienteID",
                table: "Bills",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Services_ServicesID",
                table: "Bills",
                column: "ServicesID",
                principalTable: "Services",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Services_ServicesID",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "ServicesID",
                table: "Bills",
                newName: "servicesID");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ServicesID",
                table: "Bills",
                newName: "IX_Bills_servicesID");

            migrationBuilder.AlterColumn<int>(
                name: "servicesID",
                table: "Bills",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Bills",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Services_servicesID",
                table: "Bills",
                column: "servicesID",
                principalTable: "Services",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
