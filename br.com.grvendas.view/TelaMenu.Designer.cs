namespace GRVendas.br.com.grvendas.view
{
    partial class TelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroF = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaF = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoricoV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocaU = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNome = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVendas,
            this.menuConfiguracoes});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(677, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroC,
            this.menuConsultaC});
            this.menuCliente.Image = global::GRVendas.Properties.Resources._66919_user_icon;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(93, 36);
            this.menuCliente.Text = "Clientes";
            // 
            // menuCadastroC
            // 
            this.menuCadastroC.Name = "menuCadastroC";
            this.menuCadastroC.Size = new System.Drawing.Size(182, 22);
            this.menuCadastroC.Text = "Cadastro de Clientes";
            this.menuCadastroC.Click += new System.EventHandler(this.menuCadastroC_Click);
            // 
            // menuConsultaC
            // 
            this.menuConsultaC.Name = "menuConsultaC";
            this.menuConsultaC.Size = new System.Drawing.Size(182, 22);
            this.menuConsultaC.Text = "Consulta de Clientes";
            this.menuConsultaC.Click += new System.EventHandler(this.menuConsultaC_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFc,
            this.menuConsultaFc});
            this.menuFuncionarios.Image = global::GRVendas.Properties.Resources._66914_user_search_icon;
            this.menuFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(119, 36);
            this.menuFuncionarios.Text = "Funcionários";
            this.menuFuncionarios.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // menuCadastroFc
            // 
            this.menuCadastroFc.Name = "menuCadastroFc";
            this.menuCadastroFc.Size = new System.Drawing.Size(208, 22);
            this.menuCadastroFc.Text = "Cadastro de Funcionários";
            this.menuCadastroFc.Click += new System.EventHandler(this.menuCadastroFc_Click);
            // 
            // menuConsultaFc
            // 
            this.menuConsultaFc.Name = "menuConsultaFc";
            this.menuConsultaFc.Size = new System.Drawing.Size(208, 22);
            this.menuConsultaFc.Text = "Consulta de Funcionários";
            this.menuConsultaFc.Click += new System.EventHandler(this.menuConsultaFc_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroF,
            this.menuConsultaF});
            this.menuFornecedores.Image = global::GRVendas.Properties.Resources._66793_folder_edit_icon;
            this.menuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(122, 36);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCadastroF
            // 
            this.menuCadastroF.Name = "menuCadastroF";
            this.menuCadastroF.Size = new System.Drawing.Size(211, 22);
            this.menuCadastroF.Text = "Cadastro de Fornecedores";
            this.menuCadastroF.Click += new System.EventHandler(this.menuCadastroF_Click);
            // 
            // menuConsultaF
            // 
            this.menuConsultaF.Name = "menuConsultaF";
            this.menuConsultaF.Size = new System.Drawing.Size(211, 22);
            this.menuConsultaF.Text = "Consulta de Fornecedores";
            this.menuConsultaF.Click += new System.EventHandler(this.menuConsultaF_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroP,
            this.menuConsultaP});
            this.menuProdutos.Image = global::GRVendas.Properties.Resources._66692_basket_full_icon;
            this.menuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(99, 36);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroP
            // 
            this.menuCadastroP.Name = "menuCadastroP";
            this.menuCadastroP.Size = new System.Drawing.Size(188, 22);
            this.menuCadastroP.Text = "Cadastro de Produtos";
            this.menuCadastroP.Click += new System.EventHandler(this.menuCadastroP_Click);
            // 
            // menuConsultaP
            // 
            this.menuConsultaP.Name = "menuConsultaP";
            this.menuConsultaP.Size = new System.Drawing.Size(188, 22);
            this.menuConsultaP.Text = "Consulta de Produtos";
            this.menuConsultaP.Click += new System.EventHandler(this.menuConsultaP_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaV,
            this.menuHistoricoV});
            this.menuVendas.Image = global::GRVendas.Properties.Resources._66684_basket_accept_icon;
            this.menuVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(88, 36);
            this.menuVendas.Text = "Vendas";
            // 
            // menuNovaV
            // 
            this.menuNovaV.Name = "menuNovaV";
            this.menuNovaV.Size = new System.Drawing.Size(180, 22);
            this.menuNovaV.Text = "Nova Venda";
            this.menuNovaV.Click += new System.EventHandler(this.menuNovaV_Click);
            // 
            // menuHistoricoV
            // 
            this.menuHistoricoV.Name = "menuHistoricoV";
            this.menuHistoricoV.Size = new System.Drawing.Size(180, 22);
            this.menuHistoricoV.Text = "Histórico de Vendas";
            this.menuHistoricoV.Click += new System.EventHandler(this.menuHistoricoV_Click);
            // 
            // menuConfiguracoes
            // 
            this.menuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocaU,
            this.menuSair});
            this.menuConfiguracoes.Image = global::GRVendas.Properties.Resources._66878_settings_icon;
            this.menuConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfiguracoes.Name = "menuConfiguracoes";
            this.menuConfiguracoes.Size = new System.Drawing.Size(128, 36);
            this.menuConfiguracoes.Text = "Configurações";
            // 
            // menuTrocaU
            // 
            this.menuTrocaU.Name = "menuTrocaU";
            this.menuTrocaU.Size = new System.Drawing.Size(180, 22);
            this.menuTrocaU.Text = "Trocar de Usuário";
            this.menuTrocaU.Click += new System.EventHandler(this.menuTrocaU_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(180, 22);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtNome});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(65, 17);
            this.txtData.Text = "29/05/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(34, 17);
            this.txtHora.Text = "16:39";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel5.Text = "Usuário Conectado:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(90, 17);
            this.txtNome.Text = "Gustavo Roldão";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GRVendas.Properties.Resources.ttt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenu";
            this.Text = "Menu Principal - Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroC;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaC;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFc;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFc;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroF;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaF;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroP;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaP;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuNovaV;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem menuTrocaU;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuHistoricoV;
        public System.Windows.Forms.ToolStripStatusLabel txtNome;
        public System.Windows.Forms.ToolStripStatusLabel txtData;
        public System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.Timer timer1;
    }
}