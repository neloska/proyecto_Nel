using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto_Nel.Migrations
{
    public partial class Pedido_y_ItemPedido2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "propiedades",
                newName: "NombrePropiedad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombrePropiedad",
                table: "propiedades",
                newName: "Nombre");
        }
    }
}
