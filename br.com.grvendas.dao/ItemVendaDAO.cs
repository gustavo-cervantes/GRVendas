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
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;


        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método CadastrarItemVenda
        public void CadastrarItemVenda(ItemVenda obj)
        {
            try
            {
                // 1 - Criar o comando SQL
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal) 
                                values (@venda_id, @produto_id, @qtd, @subtotal)";

                // 2 - Organizar e executar CMD
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.Venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.Produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.SubTotal);

                // 3 - Abrir a conexao e depois executar o comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
                throw;
            }
        }
        #endregion
    }
}
