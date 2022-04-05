using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto_Nel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ciudades",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logolURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudades", x => x.IdCiudad);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoDePerfilURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.IdEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "propietario",
                columns: table => new
                {
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoDePerfilURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionPropietario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propietario", x => x.IdPropietario);
                });

            migrationBuilder.CreateTable(
                name: "propiedades",
                columns: table => new
                {
                    IdPropiedad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePropiedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precioPropiedad = table.Column<double>(type: "float", nullable: false),
                    FotoPropiedadURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropiedadCiudad = table.Column<int>(type: "int", nullable: false),
                    DescripcionPropiedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCiudad = table.Column<int>(type: "int", nullable: false),
                    IdEmpelado = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propiedades", x => x.IdPropiedad);
                    table.ForeignKey(
                        name: "FK_propiedades_ciudades_IdCiudad",
                        column: x => x.IdCiudad,
                        principalTable: "ciudades",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propiedades_empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "propietarios_propiedad",
                columns: table => new
                {
                    IdPropiedad = table.Column<int>(type: "int", nullable: false),
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propietarios_propiedad", x => new { x.IdPropietario, x.IdPropiedad });
                    table.ForeignKey(
                        name: "FK_propietarios_propiedad_propiedades_IdPropiedad",
                        column: x => x.IdPropiedad,
                        principalTable: "propiedades",
                        principalColumn: "IdPropiedad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propietarios_propiedad_propietario_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "propietario",
                        principalColumn: "IdPropietario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_propiedades_IdCiudad",
                table: "propiedades",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_propiedades_IdEmpleado",
                table: "propiedades",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_propietarios_propiedad_IdPropiedad",
                table: "propietarios_propiedad",
                column: "IdPropiedad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propietarios_propiedad");

            migrationBuilder.DropTable(
                name: "propiedades");

            migrationBuilder.DropTable(
                name: "propietario");

            migrationBuilder.DropTable(
                name: "ciudades");

            migrationBuilder.DropTable(
                name: "empleados");
        }
    }
}
