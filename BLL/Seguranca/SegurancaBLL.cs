using System.Security.Cryptography;

namespace TravelHub.BLL.Seguranca;

public class SegurancaBLL : ISegurancaBLL
{
    public SegurancaBLL()
    {
    }
    public string EncriptarSenha(string senha)
    {
        byte[] salt = GerarSaltAleatorio();
        int iterations = 10000; 
        int derivedKeyLength = 256; 

        using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(senha, salt, iterations))
        {
            byte[] hash = pbkdf2.GetBytes(derivedKeyLength / 8); 

            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
    private byte[] GerarSaltAleatorio()
    {
        byte[] salt = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt);
        }

        return salt;

    }
}
