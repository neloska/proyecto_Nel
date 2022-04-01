using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class empleados
    {
        [Key]
        public int IdEmpleado { get; set; }

        public string FotoDePerfilURL { get; set; }
        public string NombreCompleto { get; set; }
        public string DescripcionEmpleado { get; set; }

        //Relaciones entre tablas
        public List<propiedades> propiedades { get; set; }
    }
}
