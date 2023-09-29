using Microsoft.EntityFrameworkCore;

using webapi.healthclinic.Domains;

namespace webapi.healthclinic.codefirst.Contexts
{
    public class HealthClinicContext : DbContext
    {
        public DbSet<TiposDeUsuario>? TipoUsuario { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Especialidade>? Especialidade { get; set; }
        public DbSet<Medico>? Medico { get; set; }
        public DbSet<Paciente>? Paciente { get; set; }
        public DbSet<Clinica>? Clinica { get; set; }
        public DbSet<Consulta>? Consulta { get; set; }
        public DbSet<Comentario>? Comentario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE18-S14; Database=event+_tarde; user id=sa; pwd=Senai@134; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}