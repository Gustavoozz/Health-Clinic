using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinicaCadastrada);

        void Deletar(Guid id);

        List<Clinica> Listar();

        Clinica BuscarPorId(Guid id);

        void Atualizar(Guid id, Clinica clinicaAtualizada);
    }
}
