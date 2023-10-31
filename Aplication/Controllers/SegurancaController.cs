using Microsoft.AspNetCore.Mvc;
using TravelHub.BLL.Seguranca;
using TravelHub.Models.VOs;
using TravelHub.Validation;

namespace TravelHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SegurancaController : ControllerBase
    {
        public ISegurancaBLL _segurancaBLL;
        public SegurancaController(ISegurancaBLL segurancaBLL)
        {
            _segurancaBLL = segurancaBLL;
        }
        
        [HttpGet]
        public ActionResult Logar(string usuario, string senha)
        {
            try
            {
                var login = _segurancaBLL.ValidarUsuario(usuario, senha);
                return Ok(usuario);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno");
            }
        }
    }
}
