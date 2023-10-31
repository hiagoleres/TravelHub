using Microsoft.AspNetCore.Mvc;
using TravelHub.Models.VOs;

namespace TravelHub.BLL.Conta
{
    public interface IContaBLL
    {
        IActionResult CriarConta(string nome, string sobrenome, string email, string senha, DateTime dataNasc);
    }
}
