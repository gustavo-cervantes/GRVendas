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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Botão entrar

            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if (dao.EfetuarLogin(email, senha))
            {
               TelaMenu telaMenu = new TelaMenu();
                telaMenu.Show();

                // Fecha a tela de login
                // Dispose fecha a tela de login com CRASH!!!!                                              
                this.Hide();
            }
            

        }
    }
}
