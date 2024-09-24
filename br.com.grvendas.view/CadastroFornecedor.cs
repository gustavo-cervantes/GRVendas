using GRVendas.br.com.grvendas.dao;
using GRVendas.br.com.grvendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRVendas.br.com.grvendas.view
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";


                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao consultar CEP: " + erro.Message);
                throw;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 - Criar um objeto para receber todos os valores

            Fornecedor obj = new Fornecedor();

            obj.Nome = txtNome.Text;
            obj.Cnpj = txtCnpj.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCep.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text); // Convertido pois é um inteiro
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            // Criar o objeto da classe FornecedorDAO
            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(obj);

            // Carregar o datagrid view dos fornecedores



        }
    }
}
