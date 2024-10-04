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
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método CadastrarVenda

        public void CadastrarVenda(Venda obj)
        {
            try
            {
                // 1 - Criar o comando SQL
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, obs) 
                                values (@cliente_id, @data_venda, @total_venda, @obs)";

                // 2 - Organizar e executar CMD
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.Cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.Data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.Total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.Obs);

                // 3 - Abrir conexão e executar comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Venda cadastrada com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                throw;
            }
        }

        #endregion
    }
}
