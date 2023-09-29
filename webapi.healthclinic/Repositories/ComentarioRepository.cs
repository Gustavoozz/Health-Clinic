using webapi.healthclinic.codefirst.Contexts;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthClinicContext c;
        public ComentarioRepository()
        {
            c = new HealthClinicContext();
        }
        public void Atualizar(Guid id, Comentario comentarioAtualizado)
        {
            try
            {
                Comentario comentarioBuscado = c.Comentario!.Find(id)!;

                if (comentarioBuscado != null)
                {
                    comentarioBuscado.Descricao = comentarioAtualizado.Descricao;
                }

                c.Comentario.Update(comentarioBuscado!);

                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Comentario BuscarPorId(Guid id)
        {
            return c.Comentario!.FirstOrDefault(f => f.IdComentario == id)!;
        }

        public void Cadastrar(Comentario comentarioCadastrado)
        {
            try
            {
                c.Comentario!.Add(comentarioCadastrado);
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
                Comentario comentarioBuscado = c.Comentario!.Find(id)!;
                c.Comentario.Remove(comentarioBuscado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Comentario> Listar()
        {
            return c.Comentario!.ToList();
        }
    }
}
