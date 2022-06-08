using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class ciudades
    {
        [Key]
        public int IdCiudad { get; set; }

        [Display(Name = "Foto de la Ciudad")]
        public string logolURL { get; set; }

        [Display(Name = "Nombre")]
        public string NombreCiudad { get; set; }

        [Display(Name = "Descripción")]
        public string DescripcionCiudad { get; set; }

        //Relaciones entre tablas
        public List<propiedades> propiedades { get; set; }
    }
}
