using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(CRM), IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do médico é obrigatório!")]
        public string? NomeMedico { get; set; }


        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O CRM do médico é obrigatório!")]
        public string? CRM { get; set; }



        // Ref. Tabela Usuario = FK.
        [Required(ErrorMessage = "O usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }


        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }


        // Ref. Tabela Clinica = FK.
        [Required(ErrorMessage = "A clínica é obrigatória!")]
        public Guid IdClinica { get; set; }


        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }


        // Ref. Tabela Especialidade = FK.
        [Required(ErrorMessage = "A especialidade do médico é obrigatória!")]
        public Guid IdEspecialidade { get; set; }


        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? Especialidade { get; set; }
    }
}
