using Dapper;
using ExplorarTour.Models;
using System.Data.SqlClient;

namespace ExplorarTour.DAL
{
    public class CardDAO
    {
        private SqlConnection _conexao;
        public CardDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Card> getTodosCards()
        {
            string sql = "select * from Card";
            var dados = (List<Card>)_conexao.Query<Card>(sql);
            return dados;
        }
        public void favoritarCard(Card pcard)
        {
            string query = "update Card set favorito=@favorito where CAID=@CAID";

            int qtdAtualizada = _conexao.Execute(query, pcard);

        }

        public List<Card> getTodosCardsFavoritos()
        {
            string sql = "select * from Card where favorito = 0";
            var dados = (List<Card>)_conexao.Query<Card>(sql);
            return dados;
        }

        public void insertCard(Card BCard)
        {
            string sql = "insert into Card (CANome,CADescricaoP,CADescricaoG,CAData) values (@CANome,@CADescricaoP,@CADescricaoG,@CAData)";
            int qtdInserida = _conexao.Execute(sql, BCard);
        }
    }
}
