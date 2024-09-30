using GRVendas.br.com.grvendas.dao;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor do combobox: " + cbFornecedor.SelectedValue);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
