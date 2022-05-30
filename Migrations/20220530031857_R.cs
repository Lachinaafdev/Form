using Microsoft.EntityFrameworkCore.Migrations;

namespace FormRegistro.Migrations
{
    public partial class R : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoR",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoR",
                table: "Usuarios");
        }
    }
}
