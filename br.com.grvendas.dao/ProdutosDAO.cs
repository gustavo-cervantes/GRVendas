using GRVendas.br.com.grvendas.model;
using GRVendas.br.com.vendas.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRVendas.br.com.grvendas.dao
{
    public class ProdutosDAO
    {
        private MySqlConnection conexao;
        public ProdutosDAO()
        {
            this.conexao = new ConnectionFactory().getconnection(); // Instancia a conexão
        }

        #region MetodoCadastarProduto

        public void CadastraProduto(Produto obj)
        {
            try
            {
                // 1 - Criar o comando SQL

                string sql = "insert into produtos (descricao, preco, qtd_estoque, for_id) values (@descricao, @preco, @qtd_estoque, @for_id)";

                // 2- Executa o comando SQL

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + erro);
                throw;
            }
        }
        #endregion
    }
}
