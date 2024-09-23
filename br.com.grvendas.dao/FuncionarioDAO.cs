using Google.Protobuf;
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
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;


        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection(); // Instanciando a conexão com o banco de dados
        }

        #region Cadastrar Funcionário
        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 - Comando SQL

                string sql = "INSERT into tb_funcionarios (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado, senha, cargo, nivel_acesso) values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @senha, @cargo, @nivel_acesso)";

                // 2 - Organizar e executar o comando SQL

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                executaCmd.Parameters.AddWithValue("@rg", obj.Rg);
                executaCmd.Parameters.AddWithValue("@cpf", obj.Cpf);
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
                executaCmd.Parameters.AddWithValue("@senha", obj.senha);
                executaCmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);


                // 3 - Abrir a conexão com o banco de dados e executar o comando SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso!");

                // 4 - Fechar a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + erro);
                throw;
            }
        }
        #endregion

        #region listarFuncionarios
        public DataTable listarFuncionarios() // Retorna uma data table, que retornará no meu DATA GRID VIEW!!!!
        {
            try
            {
                // 1- Criar o datatable e o comando SQL

                DataTable tabelaFuncionario = new DataTable();
                string sql = @"SELECT * from tb_funcionarios";

                // 2 - Organizar o comando SQL e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3 - Criar o MySqlDataAdapter ( adaptador ) e preencher os dados no datatable
                // passando como parâmetro o comando SQL executaCmd

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(executaCmd);
                dataadapter.Fill(tabelaFuncionario); // Preencher o datatable com os dados do banco de dados 

                // 4 - Fechar a conexão
                conexao.Close();

                return tabelaFuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
                return null;
            }

        }

        #endregion

        #region alterarFuncionario
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios SET nome = @nome, rg = @rg, cpf = @cpf, email = @email, "
                             + "telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, "
                             + "numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, "
                             + "estado = @estado, senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso "
                             + "WHERE codigo = @codigo";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                executaCmd.Parameters.AddWithValue("@rg", obj.Rg);
                executaCmd.Parameters.AddWithValue("@cpf", obj.Cpf);
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
                executaCmd.Parameters.AddWithValue("@senha", obj.senha);
                executaCmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executaCmd.Parameters.AddWithValue("@codigo", obj.Codigo);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                throw;
            }
        }
        #endregion

        #region excluirFuncionario
        public void deletarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 - Organizar e executar o comando SQL
                string sql = "DELETE from tb_funcionarios WHERE id = @codigo";
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);


                // 2 - Abrir conexão com o bd
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso!");

                // 3 - Fechar conexão com o bd
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao deletar funcionario" + erro);
                throw;
            }
        }
        #endregion


    }
}
