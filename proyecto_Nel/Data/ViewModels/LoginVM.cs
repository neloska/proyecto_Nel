using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Email obligatorio")]
        public string EmailAddress { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Contraseña obligatoria")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
