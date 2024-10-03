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


        public TelaVendas()
        {
            InitializeComponent();
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
            }
        }
    }
}
