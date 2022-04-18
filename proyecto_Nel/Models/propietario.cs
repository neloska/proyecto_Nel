﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class propietario
    {
        [Key]
        public int IdPropietario { get; set; }

        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage = "Foto de perfil obligatoria")]
        public string FotoDePerfilURL { get; set; }

        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "Nombre Completo obligatorio")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Descripción obligatoria")]
        public string DescripcionPropietario { get; set; }

        //Relaciones entre tablas
        public List<propietarios_propiedad> propietarios_propiedad { get; set; }
    }
}

