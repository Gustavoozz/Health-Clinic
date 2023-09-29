using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthClinicContext c;
        public PacienteRepository()
        {
            c = new HealthClinicContext();
        }
        public void Atualizar(Guid id, Paciente pacienteAtualizado)
        {
            try
            {
                Paciente pacienteBuscado = c.Paciente!.Find(id)!;

                if (pacienteBuscado != null)
                {
                    pacienteBuscado.DataNascimento = pacienteAtualizado.DataNascimento;
                }

                c.Paciente.Update(pacienteBuscado!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Paciente BuscarPorId(Guid id)
        {
            return c.Paciente!.FirstOrDefault(p => p.IdPaciente == id)!;
        }

        public void Cadastrar(Paciente pacienteCadastrado)
        {
            try
            {
                c.Paciente!.Add(pacienteCadastrado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Paciente pacienteBuscado = c.Paciente!.Find(id)!;
                c.Paciente.Remove(pacienteBuscado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Paciente> Listar()
        {
            return c.Paciente!.ToList();
        }
    }
}
