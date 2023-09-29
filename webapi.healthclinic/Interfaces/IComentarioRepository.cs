using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentarioCadastrado);

        void Deletar(Guid id);

        List<Comentario> Listar();

        Comentario BuscarPorId(Guid id);

        void Atualizar(Guid id, Comentario comentarioAtualizado);
    }
}
