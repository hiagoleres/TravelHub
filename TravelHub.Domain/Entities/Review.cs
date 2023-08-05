namespace TravelHub.TravelHub.Domain.Entities
{
    public class Review
    {
        public string Avaliacao { get; set; }

        public string Comentario { get; set; }

        public Usuario Usuario { get; private set; }

        public Destino Destino { get; set; }
    }
}
