using Microsoft.EntityFrameworkCore.Migrations;

namespace MiPrimerWebApi.Migrations
{
    public partial class Tiitulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tiitulo",
                table: "Libros",
                newName: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Libros",
                newName: "Tiitulo");
        }
    }
}
