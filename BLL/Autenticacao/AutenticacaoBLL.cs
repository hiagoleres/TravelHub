using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Web.WebPages;
using TravelHub.Models.Usuario; // Certifique-se de que este namespace esteja correto para o seu projeto
using TravelHub.Services.UsuarioService;
using TravelHub.Validation;

namespace TravelHub.BLL.AutenticacaoBLL
{
    public class AutenticacaoBLL : IAutenticacaoBLL
    {
        public UsuarioService _service;

        public AutenticacaoBLL(UsuarioService service)
        {
            _service = service;
        }

        public void Logar(string password, string senha)
        {
            
        }

        public void Deslogar()
        {
            // Implemente a lógica de logout
        }
    }
}
