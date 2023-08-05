namespace TravelHub.TravelHub.Domain.Entities
{
    public class Viagem
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public Usuario Usuario { get; private set; }

    }
}
