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
    public partial class TelaVendas : Form
    {

        // 1 - Objetos cliente e clientedao

        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();


        // 2 - Objetos de produto
        
        Produto p = new Produto();
        ProdutosDAO pdao = new ProdutosDAO();

        // 3 - Variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        // 4 - Carrinho
        DataTable Carrinho = new DataTable(); // DataTable é uma tabela de dados em memória

        public TelaVendas()
        {
            InitializeComponent();
            Carrinho.Columns.Add("Código", typeof(int)); // tipo de codigo da coluna é int TYPEOF = tipo
            Carrinho.Columns.Add("Descrição", typeof(string)); // tipo de descricao da coluna é string TYPEOF = tipo
            Carrinho.Columns.Add("Quantidade", typeof(int)); // tipo de quantidade da coluna é int TYPEOF = tipo
            Carrinho.Columns.Add("Preço", typeof(decimal)); // tipo de preço da coluna é decimal TYPEOF = tipo
            Carrinho.Columns.Add("Subtotal", typeof(decimal)); // tipo de subtotal da coluna é decimal TYPEOF = tipo

            tabelaProdutos.DataSource = Carrinho;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.RetornaClientePorCpf(txtCpf.Text);

                if (cliente != null)
                {
                    txtNome.Text = cliente.Nome; // Nome fica dentro do cliente
                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
                
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.RetornaProdutoPorCodigo(int.Parse(txtCodigo.Text));
                txtDesc.Text = p.Descricao; 
                txtPreco.Text = p.Preco.ToString(); 

                // fechar conexao e limpar campos
            }
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            // 1 - Pegando a data atual do Usuário
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // 1 - Botão remover item

            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString()); // Pega o valor da coluna 4 e guarda na variavel subproduto

            int indice = tabelaProdutos.CurrentRow.Index; // Pega o indice da linha selecionada

            DataRow linha = Carrinho.Rows[indice]; // Pega a linha selecionada

            Carrinho.Rows.Remove(linha); // Remove a linha selecionada

            Carrinho.AcceptChanges();

            total -= subproduto; // Diminui o valor do subproduto do total 

            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso! ");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            // 1 - Botão de pagamento
            // Instanciando a classe TelaPagamentos para abrir a tela de pagamentos quando o botão de pagamento for clicado

            // Capturei a data e já passei para outro form ( pagamento )
            DateTime dataAtual = DateTime.Parse(txtData.Text);


            TelaPagamentos tela = new TelaPagamentos(cliente,Carrinho, dataAtual);

            // Passando o valor total para a tela de pagamentos
            tela.txtTotal.Text = txtTotal.Text;
            tela.ShowDialog();
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // 1 - botão adicionar item
            try
            {
                qtd = int.Parse(txtQtd.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                // += representa ao c#, sempre pegar o que tem dentro da variavel total e somar com o subtotal.
                total += subtotal;

                // Adicionar o produto no carrinho

                // Carrinho é ninguém mais ninguém menos que a DataTable que foi criada la em cima.
                // Rows = Linhas, Add = Adicionar dados/linhas...
                // Apenas o codigo/id foi convertido pois é int

                Carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDesc.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();

                // Limpar os campos
                txtCodigo.Clear();
                txtDesc.Clear();
                txtPreco.Clear();
                txtQtd.Clear();

                txtCodigo.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite o código do produto");
                throw;
            }

            // Regra de negócio para registrar uma venda, adicionada ao README
            // Esta regra é aplicada no nosso banco de dados MYSQL
        }
    }

}
