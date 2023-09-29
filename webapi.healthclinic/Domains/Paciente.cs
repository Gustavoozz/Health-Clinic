using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Paciente))]

    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do paciente é obrigatório!")]
        public string? NomePaciente { get; set; }


        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "O CPF do paciente é obrigatório!")]
        public string? DataNascimento { get; set; }


        // Ref. Tabela Usuario = FK.
        [Required(ErrorMessage = "O usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }


        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
