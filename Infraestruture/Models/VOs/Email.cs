using System.Text.RegularExpressions;

namespace TravelHub.Models.VOs
{
    public class Email
    {
        public Email(string adress)
        {
            Adress = adress.Trim().ToLower();
            var reg = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (reg.Match(Adress).Success == false)
                throw new Exception("Email inválido!");
        }
        public string Adress { get; }
    }
}
