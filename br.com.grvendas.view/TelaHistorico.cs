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
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            dgHistorico.DataSource = dao.ListarVendasPorPeriodo(datainicio, datafim);

        }

        private void TelaHistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            dgHistorico.DataSource = dao.ListarVendas();
            dgHistorico.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void dgHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1 - Passo - Abrir o formulario de detalhes

            TelaDetalhes tela = new TelaDetalhes();

            // Formatando a data
            DateTime dataVenda = Convert.ToDateTime(dgHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtData.Text = dataVenda.ToString("dd/MM/yyyy");
            tela.txtCliente.Text = dgHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = dgHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = dgHistorico.CurrentRow.Cells[4].Value.ToString();

            // Ou tela.Show();
            tela.ShowDialog(); 
        }

        private void dgHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
