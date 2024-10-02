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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO F_dao = new FornecedorDAO(); 

            cbFornecedor.DataSource = F_dao.listarFornecedores();
            cbFornecedor.DisplayMember = "nome"; // Passará o nome do fornecedor para o combobox
            cbFornecedor.ValueMember = "id"; // Passará o código do fornecedor para o combobox

            ProdutosDAO dao = new ProdutosDAO();
            dgvProduto.DataSource = dao.ListarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 - Passo, receber todos os dados da tela

            Produto obj = new Produto();

            obj.Descricao = txtDesc.Text;
            obj.Preco = Convert.ToDecimal(txtPreco.Text);
            obj.QtdEstoque = Convert.ToInt32(txtEstoque.Text);
            obj.for_id = Convert.ToInt32(cbFornecedor.SelectedValue);

            // 2 - Criar o objeto Dao

            ProdutosDAO dao = new ProdutosDAO();
            dao.CadastrarProduto(obj);

            new Helpers().limparTela(this);

            // 3 - Recarregar o DGV Com os dados dos produtos
            dgvProduto.DataSource = dao.ListarProdutos();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1 - Pegando os dados do produto selecionado
            txtCodigo.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = dgvProduto.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 - Passo, receber todos os dados da tela

            Produto obj = new Produto();

            obj.Descricao = txtDesc.Text;
            obj.Preco = Convert.ToDecimal(txtPreco.Text);
            obj.QtdEstoque = Convert.ToInt32(txtEstoque.Text);
            obj.for_id = Convert.ToInt32(cbFornecedor.SelectedValue);
            obj.Id = int.Parse(txtCodigo.Text);

            // 2 - Criar o objeto Dao

            ProdutosDAO dao = new ProdutosDAO();
            dao.AlterarProduto(obj);

            new Helpers().limparTela(this);

            // 3 - Recarregar o DGV
            dgvProduto.DataSource = dao.ListarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1 - Passo, receber todos os dados da tela

            Produto obj = new Produto();
            obj.Id = int.Parse(txtCodigo.Text); // OBS: Para excluir, somente o ID é necessário

            // 2 - Criar o objeto Dao

            ProdutosDAO dao = new ProdutosDAO();
            dao.ExcluirProduto(obj);

            new Helpers().limparTela(this);

            // 3 - Recarregar o DGV
            dgvProduto.DataSource = dao.ListarProdutos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutosDAO dao = new ProdutosDAO();
            dgvProduto.DataSource = dao.ListarProdutosPorNome(nome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;                                                                          
            ProdutosDAO dao = new ProdutosDAO();
            dgvProduto.DataSource = dao.ListarProdutosPorNome(nome);

            if (dgvProduto.Rows.Count == 0 )
            {
                MessageBox.Show("Nenhum produto foi encontrado");

                // Recarregar o DGV
                dgvProduto.DataSource = dao.ListarProdutos();
            }
        }
    }
}
