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
    public class FornecedorDAO
    {
        private MySqlConnection conexao; // Atributo de conexão
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection(); // Instanciando a conexão com o banco de dados
        }

        #region Cadastrar Fornecedor
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 - Definir o comando SQL - insert into
                string sql = @"insert into tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                values (@nome, @Cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // 2 - Organizar o comando SQL

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                executaCmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                executaCmd.Parameters.AddWithValue("@email", obj.Email);
                executaCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executaCmd.Parameters.AddWithValue("@celular", obj.Celular);
                executaCmd.Parameters.AddWithValue("@cep", obj.Cep);
                executaCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executaCmd.Parameters.AddWithValue("@numero", obj.Numero);
                executaCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executaCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executaCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executaCmd.Parameters.AddWithValue("@estado", obj.Estado);


                // 3 - Abrir a conexão com o banco de dados e executar o comando SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");

                // 4 - Fechar a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
                throw;
            }
        }
        #endregion 
    }
}
