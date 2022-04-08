using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class empleados
    {
        [Key]
        public int IdEmpleado { get; set; }

        [Display(Name = "Foto de perfil")]
        public string FotoDePerfilURL { get; set; }

        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Descripción")]
        public string DescripcionEmpleado { get; set; }

        //Relaciones entre tablas
        public List<propiedades> propiedades { get; set; }
    }
}
