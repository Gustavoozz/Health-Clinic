using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Repositories;

namespace webapi.healthclinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioRepository _ComentarioRepository;

        public ComentarioController()
        {
            _ComentarioRepository = new ComentarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Comentario> listaComentario = _ComentarioRepository.Listar();
                return Ok(listaComentario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                Comentario ComentarioBuscado = _ComentarioRepository.BuscarPorId(id);
                return Ok(ComentarioBuscado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Comentario ComentarioCadastrado)
        {
            try
            {
                _ComentarioRepository.Cadastrar(ComentarioCadastrado);
                return StatusCode(201, ComentarioCadastrado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _ComentarioRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Comentario ComentarioCadastrado, Guid id)
        {
            try
            {
                _ComentarioRepository.Atualizar(id, ComentarioCadastrado);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
