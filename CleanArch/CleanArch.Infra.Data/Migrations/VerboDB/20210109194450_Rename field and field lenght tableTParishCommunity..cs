using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Data.Migrations.VerboDB
{
    public partial class RenamefieldandfieldlenghttableTParishCommunity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "TParishCommunity");

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "TParishCommunity",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "TParishCommunity");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "TParishCommunity",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
