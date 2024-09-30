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

                // 2 - Organizar o comando SQL

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao",obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                // 3 - Executa o comando SQL

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
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
