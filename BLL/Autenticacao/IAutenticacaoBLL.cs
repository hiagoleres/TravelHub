using Microsoft.AspNetCore.Mvc;

namespace TravelHub.BLL.AutenticacaoBLL
{
    public interface IAutenticacaoBLL
    {
        public void Logar(string password, string senha);

        public void Deslogar();

    }
}
