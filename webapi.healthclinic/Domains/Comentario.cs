using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição do comentário é obrigatória!")]
        public string? Descricao { get; set; }


        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "O campo exibe é obrigatório!")]
        public bool Exibe { get; set; }


        //Referência tabela Consulta = FK
        [Required(ErrorMessage = "A consulta é obrigatória!")]
        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consulta? Consulta { get; set; }


        //Referência tabela Paciente = FK

        [Required(ErrorMessage = "O paciente é obrigatório!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }
    }
}
