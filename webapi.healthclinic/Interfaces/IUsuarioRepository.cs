using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuarioCadastrado);

        void Deletar(Guid id);

        List<Usuario> Listar();

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(string Email, string Senha);

        void Atualizar(Guid id, Usuario usuarioAtualizado);
    }
}
