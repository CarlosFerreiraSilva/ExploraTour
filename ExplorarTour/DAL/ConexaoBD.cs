using System.Data.SqlClient;

namespace ExplorarTour.DAL
{
        public class ConexaoBD
        {
            private static SqlConnection Banco;
            public static SqlConnection getConexao()
            {
                if (Banco == null)
                {
                    Banco = new SqlConnection(@"Server=GINELMA\SQLEXPRESS; Database=DBExploraTour;");
                }

                return Banco;
            }
        }
    
}
