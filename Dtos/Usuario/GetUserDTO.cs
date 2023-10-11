namespace TravelHub.Dtos.Usuario;

public class GetUserDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public string Sobrenome { get; set; }

    public string Email { get; set; }

    public string Senha { get; set; }
}
