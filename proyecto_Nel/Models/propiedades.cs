using proyecto_Nel.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto_Nel.Models
{
    public class propiedades
    {
        //propietarios y empleados son foreing keys en esta tabla

        [Key]
        public int IdPropiedad { get; set; }


        public string Nombre { get; set; }
        public double precioPropiedad { get; set; }
        public string FotoPropiedadURL { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaFinal { get; set; }
        public PropiedadCiudad PropiedadCiudad { get; set; } //enum que irá dentro de la carpeta Data


        //Relaciones entre tablas
        public List<propietarios_propiedad> propietarios_propiedad { get; set; }


        //ciudad
        public int IdCiudad { get; set; }
        [ForeignKey("IdCiudad")]

        public ciudades ciudades { get; set; }


        //empleados
        public int IdEmpelado { get; set; }
        [ForeignKey("IdEmpleado")]

        public empleados empleados { get; set; }
    }
}
