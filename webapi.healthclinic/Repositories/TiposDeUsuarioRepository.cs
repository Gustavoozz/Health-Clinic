using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class TiposDeUsuarioRepository : ITiposDeUsuarioRepository
    {
        private readonly HealthClinicContext c;
        public TiposDeUsuarioRepository()
        {
            c = new HealthClinicContext();
        }
        public void Atualizar(Guid id, TiposDeUsuario usuarioAtualizado)
        {
            try
            {
                TiposDeUsuario tipoBuscado = c.TipoUsuario!.Find(id)!;

                if (tipoBuscado != null)
                {
                    tipoBuscado.TituloTiposUsuario = usuarioAtualizado.TituloTiposUsuario;
                }

                c.TipoUsuario.Update(tipoBuscado!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TiposDeUsuario BuscarPorId(Guid id)
        {
            return c.TipoUsuario!.FirstOrDefault(t => t.IdTiposUsuario == id)!;
        }

        public void Cadastrar(TiposDeUsuario usuarioCadastrado)
        {
            try
            {
                c.TipoUsuario!.Add(usuarioCadastrado);
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
                TiposDeUsuario tipoBuscado = c.TipoUsuario!.Find(id)!;
                c.TipoUsuario.Remove(tipoBuscado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TiposDeUsuario> Listar()
        {
            return c.TipoUsuario!.ToList();
        }
    }
}
