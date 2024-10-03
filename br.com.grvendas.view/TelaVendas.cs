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
        decimal subtotal_total;

        // 4 - Carrinho
        DataTable Carrinho = new DataTable(); // DataTable é uma tabela de dados em memória

        public TelaVendas()
        {
            InitializeComponent();
            Carrinho.Columns.Add("Código", typeof(int));
            Carrinho.Columns.Add("Descrição", typeof(string));
            Carrinho.Columns.Add("Quantidade", typeof(int));
            Carrinho.Columns.Add("Preço", typeof(decimal));
            Carrinho.Columns.Add("Subtotal", typeof(decimal));

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
                txtDesc.Text = p.Descricao; // Fix: Assign to the Text property of the TextBox
                txtPreco.Text = p.Preco.ToString(); // Fix: Assign to the Text property of the TextBox and call ToString()

                // fechar conexao e limpar campos
            }
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
