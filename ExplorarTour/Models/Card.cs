namespace ExplorarTour.Models
{
    public class Card
    {
        public int CAID { get; set; }
        public string CANome { get; set; }
        public string CADescricaoP { get; set; }
        public string CADescricaoG { get; set; }
        public DateTime CAData { get; set; }
        public string? CAImagem { get; set; }
        public int favorito { get; set; }
    }
}
