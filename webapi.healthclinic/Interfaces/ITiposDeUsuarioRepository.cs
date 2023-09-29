using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface ITiposDeUsuarioRepository
    {
        void Cadastrar(TiposDeUsuario usuarioCadastrado);

        void Deletar(Guid id);

        List<TiposDeUsuario> Listar();

        TiposDeUsuario BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposDeUsuario usuarioAtualizado);
    }
}
