using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medicoCadastrado);

        void Deletar(Guid id);

        List<Medico> Listar();

        Medico BuscarPorId(Guid id);

        void Atualizar(Guid id, Medico medicoAtualizado);
    }
}
