using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consultacadastrada);

        void Deletar(Guid id);

        List<Consulta> Listar();

        Consulta BuscarPorId(Guid id);

        void Atualizar(Guid id, Consulta consultaAtualizada);
    }
}
