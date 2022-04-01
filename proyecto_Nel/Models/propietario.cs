using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class propietario
    {
        [Key]
        public int IdPropietario { get; set; }

        public string FotoDePerfilURL { get; set; }
        public string NombreCompleto { get; set; }
        public string DescripcionPropietario { get; set; }

        //Relaciones entre tablas
        public List<propietarios_propiedad> propietarios_propiedad { get; set; }
    }
}

