using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FleetApi.Migrations
{
    public partial class FleetApiModelsFleetContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fleets",
                columns: table => new
                {
                    FleetID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FleetRCNo = table.Column<long>(maxLength: 17, nullable: false),
                    FleetType = table.Column<string>(maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    OwnerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fleets", x => x.FleetID);
                });

            migrationBuilder.InsertData(
                table: "Fleets",
                columns: new[] { "FleetID", "CompanyName", "FleetRCNo", "FleetType", "OwnerId" },
                values: new object[] { 1L, "ssjfksef", 43823462L, "Car", 102L });

            migrationBuilder.InsertData(
                table: "Fleets",
                columns: new[] { "FleetID", "CompanyName", "FleetRCNo", "FleetType", "OwnerId" },
                values: new object[] { 2L, "sfhjhsfr", 11478545L, "Truck", 102L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fleets");
        }
    }
}
