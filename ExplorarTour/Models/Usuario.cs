using ExplorarTour.Enums;

namespace ExplorarTour.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string LOGIN_ { get; set; }   
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
