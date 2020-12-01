using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotasApp.Migrations
{
    public partial class ActualizacionColumnas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuidadosEspeciales",
                table: "TipoMascotas");

            migrationBuilder.AddColumn<decimal>(
                name: "TiempoVidaPromedio",
                table: "TipoMascotas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionPersonalidad",
                table: "Mascotas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TiempoVidaPromedio",
                table: "TipoMascotas");

            migrationBuilder.DropColumn(
                name: "DescripcionPersonalidad",
                table: "Mascotas");

            migrationBuilder.AddColumn<string>(
                name: "CuidadosEspeciales",
                table: "TipoMascotas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
