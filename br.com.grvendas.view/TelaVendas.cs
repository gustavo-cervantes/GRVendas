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
    }
}
