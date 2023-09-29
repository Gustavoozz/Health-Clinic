using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthClinicContext c;
        public ClinicaRepository()
        {
            c = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Clinica clinicaAtualizada)
        {
            try
            {
                Clinica clinicaBuscada = c.Clinica!.Find(id)!;

                if (clinicaBuscada != null)
                {
                    clinicaBuscada.NomeFantasia = clinicaAtualizada.NomeFantasia;
                    clinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
                    clinicaBuscada.CNPJ = clinicaAtualizada.CNPJ;
                    clinicaBuscada.Endereco = clinicaAtualizada.Endereco;
                    clinicaBuscada.HorarioFuncionamento = clinicaAtualizada.HorarioFuncionamento;
                }

                c.Clinica.Update(clinicaBuscada!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Clinica BuscarPorId(Guid id)
        {
            return c.Clinica!.FirstOrDefault(t => t.IdClinica == id)!;
        }

        public void Cadastrar(Clinica clinicaCadastrada)
        {
            try
            {
                c.Clinica!.Add(clinicaCadastrada);
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
                Clinica clinicaBuscada = c.Clinica!.Find(id)!;
                c.Clinica.Remove(clinicaBuscada);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Clinica> Listar()
        {
            return c.Clinica!.ToList();
        }
    }
}
