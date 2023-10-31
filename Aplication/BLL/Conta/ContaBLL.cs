using Microsoft.AspNetCore.Mvc;
using TravelHub.BLL.Conta;
using TravelHub.BLL.Seguranca;
using TravelHub.Models.VOs;
using TravelHub.Services.UsuarioService;

namespace TravelHub.BLL.ContaBLL;

public class ContaBLL : IContaBLL
{
    public readonly ISegurancaBLL _segurancaBLL;
    public UsuarioService _service;
    public ContaBLL(ISegurancaBLL segurancaBLL, UsuarioService service)
    {
       _segurancaBLL = segurancaBLL;
        _service = service;
    }

    public IActionResult CriarConta(string nome, string sobrenome, string email, string senha, DateTime dataNasc)
    {
        var senhaEncriptada = _segurancaBLL.EncriptarSenha(senha);

        _service.CriarConta(nome, sobrenome, email, senhaEncriptada, dataNasc);

        return new OkResult();
    }

}
