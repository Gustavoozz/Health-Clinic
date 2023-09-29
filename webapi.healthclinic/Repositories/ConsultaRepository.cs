using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthClinicContext c;
        public ConsultaRepository()
        {
            c = new HealthClinicContext();
        }
        public void Atualizar(Guid id, Consulta consultaAtualizada)
        {
            try
            {
                Consulta consultaBuscada = c.Consulta!.Find(id)!;

                if (consultaBuscada != null)
                {
                    consultaBuscada.DataAgendamento = consultaAtualizada.DataAgendamento;
                    consultaBuscada.DescricaoConsulta = consultaAtualizada.DescricaoConsulta;
                }

                c.Consulta.Update(consultaBuscada!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Consulta BuscarPorId(Guid id)
        {
            return c.Consulta!.FirstOrDefault(co => co.IdConsulta == id)!;
        }

        public void Cadastrar(Consulta consultaCadastrada)
        {
            try
            {
                c.Consulta!.Add(consultaCadastrada);
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
                Consulta consultaBuscada = c.Consulta!.Find(id)!;
                c.Consulta.Remove(consultaBuscada);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Consulta> Listar()
        {
            return c.Consulta!.ToList();
        }
    }
}
