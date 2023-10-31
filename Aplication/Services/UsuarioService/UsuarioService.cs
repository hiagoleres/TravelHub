using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using System.Web.WebPages;
using TravelHub.Data;
using TravelHub.Dtos.Usuario;
using TravelHub.Models.Usuario;
using TravelHub.Models.VOs;
using TravelHub.Validation;

namespace TravelHub.Services.UsuarioService
{
    public class UsuarioService
    {
        public DataContext _context;
        public UsuarioService(DataContext context)
        {
            _context = context;
        }
        public Usuario CriarConta(string nome, string sobrenome, string email, string senha, DateTime dataNasc)
        {
            var usuario = new Usuario
            {
                Nome = nome,
                Sobrenome = sobrenome,
                DataNascimento = dataNasc,
                Email = email,
                Senha = senha
            };

            _context.Add(usuario);

            _context.SaveChanges();
            
            return usuario;

        }
    }
}
