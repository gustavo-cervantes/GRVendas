using Google.Protobuf;
using GRVendas.br.com.grvendas.model;
using GRVendas.br.com.grvendas.view;
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
        private MySqlConnection Conexao;


        public FuncionarioDAO()
        {
            this.Conexao = new ConnectionFactory().getconnection(); // Instanciando a conexão com o banco de dados
        }

        #region Cadastrar Funcionário
        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 - Comando SQL

                string sql = "INSERT into tb_funcionarios (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado, senha, cargo, nivel_acesso) values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @senha, @cargo, @nivel_acesso)";

                // 2 - Organizar e executar o comando SQL

                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);
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
                executaCmd.Parameters.AddWithValue("@senha", obj.Senha);
                executaCmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);


                // 3 - Abrir a conexão com o banco de dados e executar o comando SQL
                Conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso!");

                // 4 - Fechar a conexão
                Conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + erro);
                throw;
            }
        }
        #endregion

        #region listarFuncionarios
        public DataTable ListarFuncionarios() // Retorna uma data table, que retornará no meu DATA GRID VIEW!!!!
        {
            try
            {
                // 1- Criar o datatable e o comando SQL

                DataTable tabelaFuncionario = new DataTable();
                string sql = @"SELECT * from tb_funcionarios";

                // 2 - Organizar o comando SQL e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3 - Criar o MySqlDataAdapter ( adaptador ) e preencher os dados no datatable
                // passando como parâmetro o comando SQL executaCmd

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(executaCmd);
                dataadapter.Fill(tabelaFuncionario); // Preencher o datatable com os dados do banco de dados 

                // 4 - Fechar a conexão
                Conexao.Close();

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
        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"UPDATE tb_funcionarios SET nome = @nome, rg = @rg, cpf = @cpf, email = @email, "
                             + "telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, "
                             + "numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, "
                             + "estado = @estado, senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso "
                             + "WHERE id = @codigo";

                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);
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
                executaCmd.Parameters.AddWithValue("@senha", obj.Senha);
                executaCmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
                executaCmd.Parameters.AddWithValue("@id", obj.Codigo);


                Conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso!");

                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                throw;
            }
        }
        #endregion

        #region deletarFuncionario
        public void DeletarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 - Organizar e executar o comando SQL
                string sql = @"DELETE from tb_funcionarios WHERE id=@id"; 
                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);

                // Adiciona o parâmetro @id
                executaCmd.Parameters.AddWithValue("@id", obj.Codigo);

                // 2 - Abrir conexão com o bd
                Conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário deletado com sucesso!");

                // 3 - Fechar conexão com o bd
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao deletar funcionario" + erro);
                throw;
            }
        }
        #endregion

        #region BuscarFuncionariosPorNome
        public DataTable BuscarFuncionariosPorNome(string Nome) // Retorna uma data table, que retornará no meu DATA GRID VIEW!!!!
        {
            try
            {
                // 1- Criar o datatable e o comando SQL

                DataTable tabelaFuncionario = new DataTable();
                string sql = @"SELECT * from tb_funcionarios where nome = @nome";

                // 2 - Organizar o comando SQL e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);
                executaCmd.Parameters.AddWithValue("@nome", Nome);

                Conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3 - Criar o MySqlDataAdapter ( adaptador ) e preencher os dados no datatable
                // passando como parâmetro o comando SQL executaCmd

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(executaCmd);
                dataadapter.Fill(tabelaFuncionario); // Preencher o datatable com os dados do banco de dados 

                // 4 - Fechar a conexão
                Conexao.Close();

                return tabelaFuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
                return null;
            }

        }
        #endregion

        #region ListarFuncionariosPorNome

        public DataTable ListarFuncionariosPorNome(string Nome) // Retorna uma data table, que retornará no meu DATA GRID VIEW!!!!
        {
            try
            {
                // 1- Criar o datatable e o comando SQL

                DataTable tabelaFuncionario = new DataTable();
                string sql = @"SELECT * from tb_funcionarios where nome like @nome";

                // 2 - Organizar o comando SQL e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);
                executaCmd.Parameters.AddWithValue("@nome", Nome);

                Conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3 - Criar o MySqlDataAdapter ( adaptador ) e preencher os dados no datatable
                // passando como parâmetro o comando SQL executaCmd

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(executaCmd);
                dataadapter.Fill(tabelaFuncionario); // Preencher o datatable com os dados do banco de dados 

                // 4 - Fechar a conexão
                Conexao.Close();

                return tabelaFuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
                return null;
            }

        }

        #endregion

        #region Método que efetua o login
        public bool EfetuarLogin(string Email, string Senha)
        {
            try
            {
                // 1 - Passo - Criar o Comando SQL
                string sql = @"SELECT * from tb_funcionarios where email = @email and senha = @senha";

                // 2 - Passo - Organizar o comando sql
                MySqlCommand executaCmd = new MySqlCommand(sql, Conexao);
                executaCmd.Parameters.AddWithValue("@email", Email);
                executaCmd.Parameters.AddWithValue("@senha", Senha);

                // 3 - Abrir conexao
                Conexao.Open();

                // leitor de dados, retorna quando uso o metodo ExecuteReader
                MySqlDataReader reader = executaCmd.ExecuteReader();

                if (reader.Read())
                {

                    // Realizando o login com nível de acesso
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                        
                    MessageBox.Show("Login realizado com sucesso, bem vindo! " + nome + ("."));

                    // Abrir a tela menu principal
                    TelaMenu telaMenu = new TelaMenu();

                    // Capturando o nome do funcionário
                    telaMenu.txtNome.Text = nome;

                    // Se o nível de acesso for admin
                    if (nivel.Equals("Administrador"))
                    {

                        telaMenu.Show();
                    }
                    else if(nivel.Equals("Vendedor"))
                    {
                        // Permissões de vendedores
                        telaMenu.menuProdutos.Visible = false;
                        telaMenu.menuHistoricoV.Enabled = false;
                        telaMenu.Show();

                    }

                    return true;
                }
                else
                {
                    // a senha ou o email estao incorretos 
                    MessageBox.Show("E-mail ou senha incorretos.");
                    return false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao realizar login: " + erro);
                return false;
            }
        }
        #endregion






    }
}
