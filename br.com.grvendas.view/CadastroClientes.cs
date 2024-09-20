using GRVendas.br.com.grvendas.dao;
using GRVendas.br.com.grvendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRVendas.br.com.grvendas.view
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        public ClienteDAO ClienteDAO { get; private set; }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 - Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();
            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCep.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            // 2 - Criar um da classe DAO e chamar o método de cadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            // 3 - Atualizar o grid de clientes
            dgvCliente.DataSource = dao.listarClientes();

        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1 - Pegar os dados da linha selecionada
            txtCodigo.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();


            tbClientes.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1 - Botão excluir

            Cliente obj = new Cliente();

            // 2 - Receber o código do cliente
            obj.Codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            // 3 - Atualizar o grid de clientes
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 - Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();
            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCep.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            obj.Codigo = int.Parse(txtCodigo.Text);


            // 2 - Criar um da classe DAO e chamar o método de cadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.editarCliente(obj);

            // 3 - Atualizar o grid de clientes
            dgvCliente.DataSource = dao.listarClientes();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            string cidade = txtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO(); // Instanciar a classe DAO 

            dgvCliente.DataSource = dao.buscarClientePorNome(nome);
            dgvCliente.DataSource = dao.buscarClientePorCidade(cidade);

            if (dgvCliente.Rows.Count == 0) // Se a busca for vazia, recarregar o grid
            {
               dgvCliente.DataSource = dao.listarClientes();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            string cidade = "%" + txtPesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO(); // Instanciar a classe DAO 

            dgvCliente.DataSource = dao.listarClientesPorNome(nome);
            dgvCliente.DataSource = dao.listarClientesPorNome(cidade);

            if (dgvCliente.Rows.Count == 0) // Se a busca for vazia, recarregar o grid
            {
                dgvCliente.DataSource = dao.listarClientes();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // 1 - Botão consultar/pesquisar CEP

            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";


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
            new Helpers().limparTela(this); // Qual tela deverá ser limpa é definida pelo THIS!
        }
    }
}
