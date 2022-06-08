using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto_Nel.Migrations
{
    public partial class Pedido_e_ItemPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "propiedades",
                newName: "DescripcionPropiedad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescripcionPropiedad",
                table: "propiedades",
                newName: "Descripcion");
        }
    }
}
