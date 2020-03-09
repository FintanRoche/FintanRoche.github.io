using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentReportForm.Migrations
{
    public partial class reName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Principal_PrincipalPin",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Secondary_SecondaryPin",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Third_ThirdPin",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Reports");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ThirdPin",
                table: "Reports",
                newName: "IX_Reports_ThirdPin");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_SecondaryPin",
                table: "Reports",
                newName: "IX_Reports_SecondaryPin");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PrincipalPin",
                table: "Reports",
                newName: "IX_Reports_PrincipalPin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Principal_PrincipalPin",
                table: "Reports",
                column: "PrincipalPin",
                principalTable: "Principal",
                principalColumn: "Pin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Secondary_SecondaryPin",
                table: "Reports",
                column: "SecondaryPin",
                principalTable: "Secondary",
                principalColumn: "Pin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Third_ThirdPin",
                table: "Reports",
                column: "ThirdPin",
                principalTable: "Third",
                principalColumn: "Pin",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Principal_PrincipalPin",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Secondary_SecondaryPin",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Third_ThirdPin",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ThirdPin",
                table: "Orders",
                newName: "IX_Orders_ThirdPin");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_SecondaryPin",
                table: "Orders",
                newName: "IX_Orders_SecondaryPin");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_PrincipalPin",
                table: "Orders",
                newName: "IX_Orders_PrincipalPin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Principal_PrincipalPin",
                table: "Orders",
                column: "PrincipalPin",
                principalTable: "Principal",
                principalColumn: "Pin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Secondary_SecondaryPin",
                table: "Orders",
                column: "SecondaryPin",
                principalTable: "Secondary",
                principalColumn: "Pin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Third_ThirdPin",
                table: "Orders",
                column: "ThirdPin",
                principalTable: "Third",
                principalColumn: "Pin",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
