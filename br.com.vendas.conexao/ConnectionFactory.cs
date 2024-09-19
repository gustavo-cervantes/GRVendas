using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRVendas.br.com.vendas.conexao
{
    public class ConnectionFactory
    {
        // Método para abrir a conexão

        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }

        internal MySqlConnection getConnection()
        {
            throw new NotImplementedException();
        }
    }
}
