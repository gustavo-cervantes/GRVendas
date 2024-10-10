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
    public partial class TelaDetalhes : Form
    {
        int venda_id;
        public TelaDetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDetalhes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalhes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaDetalhes_Load(object sender, EventArgs e)
        {
            // 1 - Carrega tela de Detalhes
            ItemVendaDAO dao = new ItemVendaDAO();
            dgvDetalhes.DataSource = dao.ListarItensPorVenda(venda_id);
        }
    }
}
