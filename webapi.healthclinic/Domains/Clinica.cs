using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    [Index(nameof(Endereco), IsUnique = true)]
    [Index(nameof(RazaoSocial), IsUnique = true)]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia da clínica é obrigatório!")]
        public string? NomeFantasia { get; set; }


        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O CNPJ da clínica é obrigatório!")]
        public string? CNPJ { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O endereço da clínica é obrigatório!")]
        public string? Endereco { get; set; }


        [Column(TypeName = "VARCHAR(15)")]
        [Required(ErrorMessage = "O horário de funcionamento da clínica é obrigatório!")]
        public string? HorarioFuncionamento { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A razão social da clínica é obrigatória!")]
        public string? RazaoSocial { get; set; }
    }
}
