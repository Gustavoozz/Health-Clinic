using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Utils;

namespace webapi.healthclinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthClinicContext c;
        public UsuarioRepository()
        {
            c = new HealthClinicContext();
        }
        public void Atualizar(Guid id, Usuario usuarioAtualizado)
        {
            try
            {
                Usuario usuarioBuscado = c.Usuario!.Find(id)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.NomeUsuario = usuarioAtualizado.NomeUsuario;
                    usuarioBuscado.CPF = usuarioAtualizado.CPF;
                    usuarioBuscado.Email = usuarioAtualizado.Email;
                    usuarioBuscado.Senha = usuarioAtualizado.Senha;
                }

                c.Usuario.Update(usuarioBuscado!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorEmailESenha(string Email, string Senha)
        {
            try
            {
                Usuario usuarioBuscado = c.Usuario!
                 .Select(u => new Usuario
                 {
                     IdUsuario = u.IdUsuario,
                     Email = u.Email,
                     Senha = u.Senha,
                     TiposUsuario = new TiposDeUsuario
                     {
                         IdTiposUsuario = u.IdTiposDeUsuario,
                         TituloTiposUsuario = u.TiposUsuario!.TituloTiposUsuario
                     }

                 }).FirstOrDefault(u => u.Email == Email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            return c.Usuario!.FirstOrDefault(t => t.IdUsuario == id)!;
        }

        public void Cadastrar(Usuario usuarioCadastrado)
        {
            try
            {
                usuarioCadastrado.Senha = Criptografia.GerarHash(usuarioCadastrado.Senha!);
                c.Usuario!.Add(usuarioCadastrado);
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
                Usuario usuarioBuscado = c.Usuario!.Find(id)!;
                c.Usuario.Remove(usuarioBuscado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> Listar()
        {
            return c.Usuario!.ToList();
        }
    }
}
