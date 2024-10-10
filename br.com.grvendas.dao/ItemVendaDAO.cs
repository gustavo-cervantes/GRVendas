using GRVendas.br.com.grvendas.model;
using GRVendas.br.com.vendas.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        #region Método ListarItensPorVenda
        public DataTable ListarItensPorVenda(int venda_id)
        {
            try
            {
                // 1 - Passo Criar o DataTable e o comando SQL
                DataTable tabelaItens = new DataTable();

                string sql = @"SELECT i.id as 'Código',
                             p.descricao as 'Descricao',
                             i.qtd as 'Quantidade',
                             p.preco as 'Preço',
                             i.subtotal as 'Subtotal' 
 
                             FROM tb_itensvendas as  i join
                             tb_produtos as p on (i.produto_id = p.id) WHERE venda_id = @venda_id";



                // 2 - Passo organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", venda_id);

                // 3 - Abrir a conexao
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 4 - Criar o MySqlDataAdapter para preenchimento dos dados no data grid view
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaItens);

                return tabelaItens;



            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar vendas: " + erro);
                return null;
            }
        }
        #endregion
    }
}
