using System.ComponentModel.DataAnnotations;

namespace proyecto_Nel.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "Nombre obligatorio")]
        public string FullName { get; set; }


        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Email obligatorio")]
        public string EmailAddress { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Contraseña obligatoria")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [Required(ErrorMessage = "Confirmación de contraseña obligatoria")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Contraseñas coincidentes")]
        public string ConfirmPassword { get; set; }
    }
}
