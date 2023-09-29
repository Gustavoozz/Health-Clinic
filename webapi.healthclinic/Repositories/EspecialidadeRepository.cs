using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {

        private readonly HealthClinicContext c;
        public EspecialidadeRepository()
        {
            c = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Especialidade especialidadeAtualizada)
        {
            try
            {
                Especialidade especialidadeBuscada = c.Especialidade!.Find(id)!;

                if (especialidadeBuscada != null)
                {
                    especialidadeBuscada.TituloEspecialidade = especialidadeAtualizada.TituloEspecialidade;
                }

                c.Especialidade.Update(especialidadeBuscada!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Especialidade BuscarPorId(Guid id)
        {
            return c.Especialidade!.FirstOrDefault(e => e.IdEspecialidade == id)!;
        }

        public void Cadastrar(Especialidade especialidadeCadastrada)
        {
            try
            {
                c.Especialidade!.Add(especialidadeCadastrada);
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
                Especialidade especialidadeBuscada = c.Especialidade!.Find(id)!;
                c.Especialidade.Remove(especialidadeBuscada);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Especialidade> Listar()
        {
            return c.Especialidade!.ToList();
        }
    }
}
