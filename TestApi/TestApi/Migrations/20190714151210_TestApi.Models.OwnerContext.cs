using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApi.Migrations
{
    public partial class TestApiModelsOwnerContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Owner",
                schema: "dbo",
                columns: table => new
                {
                    OwnerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerName = table.Column<string>(maxLength: 50, nullable: false),
                    OwnerContact = table.Column<long>(maxLength: 10, nullable: false),
                    OwnerEmail = table.Column<string>(maxLength: 50, nullable: false),
                    Ownerpass = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "Fleets",
                columns: table => new
                {
                    FleetRCNo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FleetType = table.Column<string>(maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    OwnerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fleets", x => x.FleetRCNo);
                    table.ForeignKey(
                        name: "FK_Fleets_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "dbo",
                        principalTable: "Owner",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Owner",
                columns: new[] { "OwnerId", "OwnerContact", "OwnerEmail", "OwnerName", "Ownerpass" },
                values: new object[] { 101L, 64737493L, "qnwqn2@feen", "Bob", "cbdcmbs" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Owner",
                columns: new[] { "OwnerId", "OwnerContact", "OwnerEmail", "OwnerName", "Ownerpass" },
                values: new object[] { 102L, 64737493L, "qnwcsmklcm@feen", "malkdm", "cbadjwu89bs" });

            migrationBuilder.CreateIndex(
                name: "IX_Fleets_OwnerId",
                table: "Fleets",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fleets");

            migrationBuilder.DropTable(
                name: "Owner",
                schema: "dbo");
        }
    }
}
