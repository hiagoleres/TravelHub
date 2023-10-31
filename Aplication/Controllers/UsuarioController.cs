using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using TravelHub.BLL.AutenticacaoBLL;
using TravelHub.BLL.Conta;
using TravelHub.BLL.ContaBLL;
using TravelHub.Models.VOs;
using TravelHub.Validation;

namespace TravelHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        public IContaBLL _contaBLL { get; set; }
        public UsuarioController(IContaBLL contaBLL) {
            _contaBLL = contaBLL; 
        }
        [HttpPost]
        public ActionResult CriarContaController(string nome, string sobrenome, string email, string senha, DateTime dataNasc)
        {
            try
            {
                var usuario = _contaBLL.CriarConta(nome, sobrenome, email, senha, dataNasc);
                return Ok(usuario);
            }catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }catch (Exception ex)
            {
                return StatusCode(500, "Erro interno");
            }
        }

    }
}
