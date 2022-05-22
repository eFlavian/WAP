using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT___WAP.Migrations
{
    public partial class RouteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Destination = table.Column<string>(type: "TEXT", nullable: false),
                    StartingPoint = table.Column<string>(type: "TEXT", nullable: false),
                    Length = table.Column<float>(type: "REAL", nullable: false),
                    CostPerKM = table.Column<int>(type: "INTEGER", nullable: false),
                    Payment = table.Column<float>(type: "REAL", nullable: false),
                    TotalWeight = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
