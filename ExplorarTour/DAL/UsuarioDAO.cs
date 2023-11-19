using Dapper;
using ExplorarTour.Models;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace ExplorarTour.DAL
{
    public class UsuarioDAO
    {
        private SqlConnection _conexao;
        public UsuarioDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Usuario> getTodosAluno()
        {
            string sql = "select * from Usuario";
            var dados = (List<Usuario>)_conexao.Query<Usuario>(sql);
            return dados;
        }

        public void insertAluno(Usuario BUsuario)
        {
            string sql = "insert into Usuario (Nome,Senha,Email,LOGIN_,Perfil,DataCadastro) values (@Nome,@Senha,@Email,@LOGIN_,@Perfil,@DataCadastro)";
            int qtdInserida = _conexao.Execute(sql, BUsuario);
        }
    }
}
