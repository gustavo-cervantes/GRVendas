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
                txtNome.Text = cliente.Nome; // Nome fica dentro do cliente
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1 - botão adicionar item

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
    }
}
