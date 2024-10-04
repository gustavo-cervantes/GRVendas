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
    public partial class TelaPagamentos : Form
    {
        // Instanciando um objeto da classe Cliente
        Cliente cliente = new Cliente();

        // Instanciando um objeto da classe DataTable
        DataTable carrinho = new DataTable();

        // Data

        DateTime dataAtual;


        // Construtor da classe TelaPagamentos
        // Quando o objeto TelaPagamentos for instanciado, ele receberá um objeto da classe Cliente e um objeto da classe DataTable
        public TelaPagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            // Atribuindo o objeto cliente recebido pelo construtor ao objeto cliente da classe TelaPagamentos
            // this = definindo que quero usar os atributos acima, atributos da minha classe
            this.cliente = cliente;
            this.carrinho = carrinho;
            InitializeComponent();
            this.dataAtual = dataAtual;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReceber_Click(object sender, EventArgs e)
        {

        }
    }
}
