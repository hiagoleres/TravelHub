using NPOI.SS.Formula.Functions;
using System.Security.Cryptography;
using System.Text;
using TravelHub.Dtos.Usuario;
using TravelHub.Models.Usuario;
using TravelHub.Models.VOs;
using TravelHub.Services.Seguranca;

namespace TravelHub.BLL.Seguranca;

public class SegurancaBLL : ISegurancaBLL
{
    public SegurancaService _segurancaService;

    public SegurancaBLL(SegurancaService segurancaService)
    {
        _segurancaService = segurancaService;
    }

    public string EncriptarSenha(string senha)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            byte[] hashBytes = sha256.ComputeHash(bytes);

            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }

    public bool ValidarUsuario(string usuario, string senha)
    {
        if (usuario == null || senha == null)
            throw new ArgumentException("Usuário ou senha está nulo!");

        var senhaEncriptada = this.EncriptarSenha(senha);
        
        return _segurancaService.ValidarUsuario(usuario, senhaEncriptada);
    }

    public UsuarioLoginDTO Get(string email, string senha)
    {
        var senhaEncriptada = this.EncriptarSenha(senha);
        return _segurancaService.GetUsuario(email, senhaEncriptada);
    }
}
