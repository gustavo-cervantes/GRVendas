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
    public class FornecedorDAO
    {
        private MySqlConnection conexao; // Atributo de conexão
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection(); // Instanciando a conexão com o banco de dados
        }

        #region CadastrarFornecedor
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

        #region ListarFornecedores
        public DataTable listarFornecedores()
        {
            try
            {
                // 1- Criar o datatable e o comando SQL

                DataTable tabelafornecedores = new DataTable(); // Criação do datatable
                string sql = @"select * from tb_fornecedores";

                // 2 - Organizar o comando SQL e executar
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                // 3 - Criar o MySqlDataAdapter ( adaptador ) e preencher os dados no datatable
                // passando como parâmetro o comando SQL executaCmd

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(executaCmd);
                dataadapter.Fill(tabelafornecedores); // Preencher o datatable com os dados do banco de dados 

                // 4 - Fechar a conexão
                conexao.Close();

                return tabelafornecedores;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
                return null;
            }
        }
        #endregion

        #region EditarFornecedor
        public void EditarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedor SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                where id=@id";

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
                executaCmd.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar dados do fornecedor:" + erro);
                throw;
            }
        }
        #endregion 

        #region DeletarFornecedor
        public void DeletarFornecedor(Fornecedor obj)
        {

            try
            {
                // 1 - Organizar o comando SQL
                string sql = @"delete from tb_fornecedores where id=@id";
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                // 2 - Adiciona o parametro @id
                executaCmd.Parameters.AddWithValue("@id", obj.Codigo);

                // 3 - Abrir conexão com o banco de dados
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!");

                // 4 - Fechar conexão com o bd
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir fornecedor:" + erro); 
                throw;
            }
           

        }
        #endregion
    }
}
