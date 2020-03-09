using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentReportForm.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Principal",
                columns: table => new
                {
                    Pin = table.Column<string>(nullable: false),
                    SubjectType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Principal", x => x.Pin);
                });

            migrationBuilder.CreateTable(
                name: "Secondary",
                columns: table => new
                {
                    Pin = table.Column<string>(nullable: false),
                    SubjectType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secondary", x => x.Pin);
                });

            migrationBuilder.CreateTable(
                name: "Third",
                columns: table => new
                {
                    Pin = table.Column<string>(nullable: false),
                    SubjectType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Third", x => x.Pin);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentType = table.Column<string>(nullable: true),
                    PRNBool = table.Column<bool>(nullable: false),
                    PRN_Medication = table.Column<string>(nullable: true),
                    PrincipalPin = table.Column<string>(nullable: true),
                    SecondaryPin = table.Column<string>(nullable: true),
                    ThirdPin = table.Column<string>(nullable: true),
                    ManagementUnit = table.Column<string>(nullable: true),
                    CentreName = table.Column<string>(nullable: true),
                    CostCentre = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    IncidentDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Principal_PrincipalPin",
                        column: x => x.PrincipalPin,
                        principalTable: "Principal",
                        principalColumn: "Pin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Secondary_SecondaryPin",
                        column: x => x.SecondaryPin,
                        principalTable: "Secondary",
                        principalColumn: "Pin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Third_ThirdPin",
                        column: x => x.ThirdPin,
                        principalTable: "Third",
                        principalColumn: "Pin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PrincipalPin",
                table: "Orders",
                column: "PrincipalPin");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SecondaryPin",
                table: "Orders",
                column: "SecondaryPin");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ThirdPin",
                table: "Orders",
                column: "ThirdPin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Principal");

            migrationBuilder.DropTable(
                name: "Secondary");

            migrationBuilder.DropTable(
                name: "Third");
        }
    }
}
