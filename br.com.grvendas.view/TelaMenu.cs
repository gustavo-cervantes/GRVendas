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
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {
            // Pegando a Data atual
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Programando dentro do timer
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuCadastroC_Click(object sender, EventArgs e)
        {
            // 1 - Abrir a tela de clientes
            // 2 - Instanciar a tela de clientes
            CadastroClientes tela = new CadastroClientes();
            tela.ShowDialog();

        }

        private void menuConsultaC_Click(object sender, EventArgs e)
        {
            // Abrir a tela de clientes com a aba de consulta aberta
            CadastroClientes tela = new CadastroClientes();
            tela.tbClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroFc_Click(object sender, EventArgs e)
        {
            // Abrir a tela de cadastro de funcionários
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            cadastroFuncionarios.ShowDialog();
        }

        private void menuConsultaFc_Click(object sender, EventArgs e)
        {
            // Abrir a tela de consulta de funcionarios
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            cadastroFuncionarios.tbFuncionario.SelectedTab = cadastroFuncionarios.tabPage2;
            cadastroFuncionarios.ShowDialog();
        }

        private void menuCadastroF_Click(object sender, EventArgs e)
        {
            // Abrir tela de cadastro de fornecedor
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
            cadastroFornecedor.ShowDialog();
        }

        private void menuConsultaF_Click(object sender, EventArgs e)
        {
            // Abrir tela de cadastro de fornecedor
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
            cadastroFornecedor.tbFornecedor.SelectedTab = cadastroFornecedor.tabPage2;
            cadastroFornecedor.ShowDialog();
        }

        private void menuCadastroP_Click(object sender, EventArgs e)
        {
            // Abrir a tela de cadastro de produto
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.ShowDialog();
        }

        private void menuConsultaP_Click(object sender, EventArgs e)
        {
            // Abrir a tela de consulta de produto
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.tbProdutos.SelectedTab = cadastroProdutos.tabPage2;
            cadastroProdutos.ShowDialog();
        }

        private void menuNovaV_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.ShowDialog();
        }

        private void menuHistoricoV_Click(object sender, EventArgs e)
        {
            TelaHistorico telaHistorico = new TelaHistorico();
            telaHistorico.ShowDialog();

        }
    }
}
