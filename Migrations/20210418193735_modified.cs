using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicBilling.API.Migrations
{
    public partial class modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Services_ServicesId",
                table: "Bills");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Bills_ServicesId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "ServicesId",
                table: "Bills");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Bills",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Bills");

            migrationBuilder.AddColumn<int>(
                name: "ServicesId",
                table: "Bills",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServicesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServicesId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ServicesId",
                table: "Bills",
                column: "ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Services_ServicesId",
                table: "Bills",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "ServicesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
