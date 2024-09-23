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
            obj.senha = txtSenha.Text;
            obj.cargo = cbCargo.Text;
            obj.nivel_acesso = cbNivelAcesso.SelectedItem.ToString(); // Converte o item selecionado para string

            // 3 - Instanciar a classe FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj); // PS: Obj tem os dados do funcionário.

            // Recarrega a dgv
            dgvFuncionario.DataSource = dao.listarFuncionarios();

        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            // Recarrega o data grid view
            dgvFuncionario.DataSource = dao.listarFuncionarios();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1 - Instanciar a classe Funcionario
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.deletarFuncionario(obj);

            // Recarrega o data grid view
            dgvFuncionario.DataSource = dao.listarFuncionarios();

        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgvFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgvFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgvFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = dgvFuncionario.CurrentRow.Cells[16].Value.ToString();
            txtSenha.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivelAcesso.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();

            tbFuncionario.SelectedTab = tabPage1;
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
            obj.senha = txtSenha.Text;
            obj.cargo = cbCargo.Text;
            obj.Codigo = int.Parse(txtCodigo.Text); // Para fazer alteração é necessario o código

            // 3 - Instanciar a classe FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj); // PS: Obj tem os dados do funcionário.
        }
    }
}
