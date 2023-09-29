using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email obrigatório!")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Senha obrigatória!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 á 20 caracteres")]
        public string? Senha { get; set; }
    }
}
