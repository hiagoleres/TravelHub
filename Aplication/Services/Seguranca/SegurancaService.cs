using NPOI.SS.Formula.Functions;
using TravelHub.Data;
using TravelHub.Dtos.Usuario;
using TravelHub.Models.Usuario;
using TravelHub.Models.VOs;

namespace TravelHub.Services.Seguranca
{
    public class SegurancaService
    {
        public DataContext _context;

        public SegurancaService(DataContext context)
        {
            _context = context;
        }

        public bool ValidarUsuario(string email, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(t=> t.Email == email && t.Senha == senha);

            return usuario != null;
        }

        public UsuarioLoginDTO GetUsuario(string email, string senha) 
        {
            var usuario = _context.Usuarios.FirstOrDefault(t => t.Email == email && t.Senha == senha);

            return new UsuarioLoginDTO { Email = usuario.Email, Senha = usuario.Senha, Role = usuario.Role};
        }
    }
}
