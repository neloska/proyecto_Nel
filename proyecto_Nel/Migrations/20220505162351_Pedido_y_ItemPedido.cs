using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto_Nel.Migrations
{
    public partial class Pedido_y_ItemPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombrePropiedad",
                table: "propiedades",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "DescripcionPropiedad",
                table: "propiedades",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "NombreCiudad",
                table: "ciudades",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "DescripcionCiudad",
                table: "ciudades",
                newName: "Descripcion");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "propietario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FotoDePerfilURL",
                table: "propietario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionPropietario",
                table: "propietario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    IdPropiedad = table.Column<int>(type: "int", nullable: false),
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsPedidos_pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsPedidos_propiedades_IdPropiedad",
                        column: x => x.IdPropiedad,
                        principalTable: "propiedades",
                        principalColumn: "IdPropiedad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPedidos_IdPedido",
                table: "ItemsPedidos",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPedidos_IdPropiedad",
                table: "ItemsPedidos",
                column: "IdPropiedad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsPedidos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "propiedades",
                newName: "NombrePropiedad");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "propiedades",
                newName: "DescripcionPropiedad");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "ciudades",
                newName: "NombreCiudad");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "ciudades",
                newName: "DescripcionCiudad");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "propietario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FotoDePerfilURL",
                table: "propietario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionPropietario",
                table: "propietario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
