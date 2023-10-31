using Microsoft.AspNetCore.Mvc;
using NPOI.SS.Formula.Functions;
using System.Web.Mvc;
using TravelHub.Auth;
using TravelHub.BLL.Seguranca;
using TravelHub.Dtos.Usuario;
using TravelHub.Models.Usuario;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TravelHub.Controllers
{
    
    [Route("v1/account")]
    public class HomeController : ControllerBase
    {
        public ISegurancaBLL _segurancaBLL;
        public HomeController(ISegurancaBLL segurancaBLL)
        {
            _segurancaBLL = segurancaBLL;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous] 
        public async Task<ActionResult<dynamic>> Authenticate(UsuarioLoginDTO usuario)
        {
            var user = _segurancaBLL.Get(usuario.Email, usuario.Senha);

            var token = TokenService.GenerateToken(user);
            user.Senha = "";
            return new
            {
                user = user,
                token = token
            };
        } 
    }
}
