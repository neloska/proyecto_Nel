using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class ciudades
    {
        [Key]
        public int IdCiudad { get; set; }

        public string logolURL { get; set; }
        public string NombreCiudad { get; set; }
        public string DescripcionCiudad { get; set; }

        //Relaciones entre tablas
        public List<propiedades> propiedades { get; set; }
    }
}
