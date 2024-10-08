namespace GRVendas.br.com.grvendas.view
{
    partial class TelaPagamentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReceber = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 92);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dinheiro (R$):";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Location = new System.Drawing.Point(201, 131);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(134, 29);
            this.txtDinheiro.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cartão:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCartao
            // 
            this.txtCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartao.Location = new System.Drawing.Point(201, 191);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(134, 29);
            this.txtCartao.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pix:";
            // 
            // txtPix
            // 
            this.txtPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPix.Location = new System.Drawing.Point(201, 244);
            this.txtPix.Name = "txtPix";
            this.txtPix.Size = new System.Drawing.Size(134, 29);
            this.txtPix.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Troco:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(201, 350);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 29);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total:";
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.White;
            this.btnReceber.Image = global::GRVendas.Properties.Resources._66684_basket_accept_icon;
            this.btnReceber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceber.Location = new System.Drawing.Point(34, 609);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.btnReceber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReceber.Size = new System.Drawing.Size(372, 43);
            this.btnReceber.TabIndex = 26;
            this.btnReceber.Text = "Receber e finalizar";
            this.btnReceber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(201, 296);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(134, 29);
            this.txtTroco.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Observações:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(29, 437);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(377, 151);
            this.txtObs.TabIndex = 29;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // TelaPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.TextBox txtTroco;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObs;
    }
}