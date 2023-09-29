using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(CPF), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? NomeUsuario { get; set; }


        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O CPF é obrigatório!")]
        public string? CPF { get; set; }



        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email é obrigatório!")]
        public string? Email { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A senha é obrigatória!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 a 60 caractéres.")]
        public string? Senha { get; set; }



        // Ref. Tabela TiposDeUsuario = FK.
        [Required(ErrorMessage = "O tipo de usuário é obrigatório!")]
        public Guid IdTiposDeUsuario { get; set; }


        [ForeignKey(nameof(IdTiposDeUsuario))]
        public TiposDeUsuario? TiposUsuario { get; set; }

    }
}
