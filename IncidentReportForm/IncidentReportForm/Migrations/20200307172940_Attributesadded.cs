using Microsoft.EntityFrameworkCore.Migrations;

namespace IncidentReportForm.Migrations
{
    public partial class Attributesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Abuse",
                table: "Reports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ConnectedIncidentDetails",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContributingFactors",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frequency",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncidentLocation",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncidentRoom",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manageabillity",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalIntervention",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonPresent",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Serverity",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Solutions",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "managerEmail",
                table: "Reports",
                nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetUserTokens",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserTokens",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "AspNetUserLogins",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserLogins",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abuse",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ConnectedIncidentDetails",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ContributingFactors",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "IncidentLocation",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "IncidentRoom",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Manageabillity",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "MedicalIntervention",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "PersonPresent",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Serverity",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Solutions",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "managerEmail",
                table: "Reports");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetUserTokens",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserTokens",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "AspNetUserLogins",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserLogins",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);
        }
    }
}
