using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthClinicContext c;
        public MedicoRepository()
        {
            c = new HealthClinicContext();
        }
        public void Atualizar(Guid id, Medico medicoAtualizado)
        {
            try
            {
                Medico medicoBuscado = c.Medico!.Find(id)!;

                if (medicoBuscado != null)
                {
                    medicoBuscado.NomeMedico = medicoAtualizado.NomeMedico;
                    medicoBuscado.CRM = medicoAtualizado.CRM;
                }

                c.Medico.Update(medicoBuscado!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Medico BuscarPorId(Guid id)
        {
            return c.Medico!.FirstOrDefault(m => m.IdMedico == id)!;
        }

        public void Cadastrar(Medico medicoCadastrado)
        {
            try
            {
                c.Medico!.Add(medicoCadastrado);
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
                Medico medicoBuscado = c.Medico!.Find(id)!;
                c.Medico.Remove(medicoBuscado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Medico> Listar()
        {
            return c.Medico!.ToList();
        }
    }
}
