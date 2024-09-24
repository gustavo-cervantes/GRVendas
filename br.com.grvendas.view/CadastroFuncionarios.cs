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
    public partial class CadastroFuncionarios : Form
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 - Instanciar a classe Funcionario

            Funcionario obj = new Funcionario();

            // 2 - Receber os dados da tela e armazenar no objeto

            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCep.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = Convert.ToInt32(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;
            obj.Senha = txtSenha.Text;
            obj.Cargo = cbCargo.Text;
            obj.NivelAcesso = cbNivelAcesso.SelectedItem.ToString(); // Converte o item selecionado para string

            // 3 - Instanciar a classe FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(obj); // PS: Obj tem os dados do funcionário.

            // Recarrega a dgv
            dgvColab.DataSource = dao.ListarFuncionarios();

        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            // Recarrega o data grid view
            dgvColab.DataSource = dao.ListarFuncionarios();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1 - Instanciar a classe Funcionario
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.DeletarFuncionario(obj);

            // Recarrega o data grid view
            dgvColab.DataSource = dao.ListarFuncionarios();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 - Instanciar a classe Funcionario

            Funcionario obj = new Funcionario();

            // 2 - Receber os dados da tela e armazenar no objeto

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
            obj.Senha = txtSenha.Text;
            obj.Cargo = cbCargo.Text;
            obj.Codigo = int.Parse(txtCodigo.Text); // Para fazer alteração é necessario o código

            // 3 - Instanciar a classe FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(obj); // PS: Obj tem os dados do funcionário.
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Nome = txtPesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO(); // Instanciar a classe DAO 

            dgvColab.DataSource = dao.BuscarFuncionariosPorNome(Nome);

            if (dgvColab.Rows.Count == 0 || txtPesquisa.Text == string.Empty) // Se a busca for vazia, recarregar o grid
            {
                MessageBox.Show("Funcionário não encontrado!");
                dgvColab.DataSource = dao.ListarFuncionarios();
            }
        }

        private void dgvColab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvColab.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvColab.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvColab.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvColab.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvColab.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvColab.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = dgvColab.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = dgvColab.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgvColab.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgvColab.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgvColab.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgvColab.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgvColab.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = dgvColab.CurrentRow.Cells[16].Value.ToString();
            txtSenha.Text = dgvColab.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dgvColab.CurrentRow.Cells[6].Value.ToString();
            cbNivelAcesso.Text = dgvColab.CurrentRow.Cells[7].Value.ToString();

            tbFuncionario.SelectedTab = tabPage1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string Nome = "%" + txtPesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO(); // Instanciar a classe DAO
            {
                dgvColab.DataSource = dao.ListarFuncionariosPorNome(Nome);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // 1 - Botão consultar/pesquisar CEP
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
    }
}
