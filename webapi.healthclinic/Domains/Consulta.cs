using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();


        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do agendamento é obrigatória!")]
        public DateTime DataAgendamento { get; set; }


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição para prontuário da consulta é obrigatória!")]
        public string? DescricaoConsulta { get; set; }



        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horário do agendamento é obrigatório!")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan? HorarioAgendamento { get; set; }


        //Ref. Tabela Paciente = FKN

        [Required(ErrorMessage = "O paciente é obrigatório!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }


        //Ref. Tabela Medico = FK

        [Required(ErrorMessage = "O médico é obrigatório!")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }
    }
}
