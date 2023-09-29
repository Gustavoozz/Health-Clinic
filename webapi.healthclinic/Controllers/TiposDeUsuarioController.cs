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
    public class TiposDeUsuarioController : ControllerBase
    {
        private readonly ITiposDeUsuarioRepository _tipoUsuarioRepository;

        public TiposDeUsuarioController()
        {
            _tipoUsuarioRepository = new TiposDeUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TiposDeUsuario> listaTipoUsuario = _tipoUsuarioRepository.Listar();
                return Ok(listaTipoUsuario);
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
                TiposDeUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);
                return Ok(tipoUsuarioBuscado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(TiposDeUsuario usuarioCadastrado)
        {
            try
            {
                _tipoUsuarioRepository.Cadastrar(usuarioCadastrado);
                return StatusCode(201, usuarioCadastrado);
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
                _tipoUsuarioRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(TiposDeUsuario usuarioCadastrado, Guid id)
        {
            try
            {
                _tipoUsuarioRepository.Atualizar(id, usuarioCadastrado);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
