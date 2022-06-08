using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Models
{
    public class usuarioApp:IdentityUser
    {
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
    }
}
