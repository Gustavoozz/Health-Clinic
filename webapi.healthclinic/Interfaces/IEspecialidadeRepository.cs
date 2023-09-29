using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidadeCadastrada);

        void Deletar(Guid id);

        List<Especialidade> Listar();

        Especialidade BuscarPorId(Guid id);

        void Atualizar(Guid id, Especialidade especialidadeAtualizada);
    }
}
