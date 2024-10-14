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

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
