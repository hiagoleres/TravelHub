using TravelHub.Dtos.Usuario;
using TravelHub.Models.Usuario;
using TravelHub.Models.VOs;

namespace TravelHub.BLL.Seguranca
{
    public interface ISegurancaBLL
    {
        string EncriptarSenha(string senha);

        bool ValidarUsuario(string usuario, string senha);

        UsuarioLoginDTO Get(string email, string senha);
    }
}
