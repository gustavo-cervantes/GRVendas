using GRVendas.br.com.grvendas.dao;
using GRVendas.br.com.grvendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            try
            {
                // * Botão finalizar venda

                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                v_dinheiro = decimal.Parse(txtDinheiro.Text);
                v_cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                // * Calcular o total pago
                totalpago = v_dinheiro + v_cartao;

                if (totalpago <= total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda! ");
                }
                else
                {
                    // * Calcular o troco
                    troco = totalpago - total;

                    // * Criando um objeto da classe Venda

                    Venda vendas = new Venda();

                    // * Pegando o ID do cliente
                    vendas.Cliente_id = cliente.Codigo;
                    vendas.Data_venda = dataAtual;
                    vendas.Total_venda = total;
                    vendas.Obs = txtObs.Text;

                    VendaDAO vdao = new VendaDAO();
                    txtTroco.Text = troco.ToString();
                    vdao.CadastrarVenda(vendas);


                    // ! Cadastrar os itens da venda
                    
                    // 1 - Para cada linha, capture os dados e salva no objeto linha
                    foreach (DataRow linha in carrinho.Rows)
                    {

                        // 2 - instanciar a classe VendaItem

                        ItemVenda item = new ItemVenda();

                        // 3 - Guardar o ID da venda que acabou de ser cadastrada
                        item.Venda_id = vdao.RetornaIdUltimaVenda();
                        item.Produto_id = int.Parse(linha["Código"].ToString());
                        item.Qtd = int.Parse(linha["Quantidade"].ToString());
                        item.SubTotal = decimal.Parse(linha["Subtotal"].ToString());
                        

                        // 4 - Criar o OBJ item venda dao

                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.CadastrarItemVenda(item);
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Close();

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro ao finalizar o pagamento: " + erro);
                throw;
            }
        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaPagamentos_Load(object sender, EventArgs e)
        {
            // * Carrega a tela
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
            txtPix.Text = "0,00";

        }
    }
}
