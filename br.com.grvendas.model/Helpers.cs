using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRVendas.br.com.grvendas.model
{
    // MÉTODO LIMPAR CAMPOS, MÉTODOS AUXILARIARES ESTARÃO NESTA CLASSE
    public class Helpers
    {
        public void limparTela(Form Tela)
        {
            // 1- Percorrer todos os controles dentro da Tela
            // Cada controle encontrado será chamado de ctrPai
            // Percorre todo o formulario e irá verificar todos os meus controles
            // Ex: Buttons, labels, textboxes.

            foreach (Control ctrPai in Tela.Controls)
            {
                // 2 - Dentro destes controles, irá verificar se existe um controle chamado tabPage
                // Se existir um tabPage, irá percorrer todos os controles dentro do tabPage
                // Ex: Dentro de um tabPage, temos um textbox, label, button.
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    // Verifica se é um tabPage se for, aplica a linha de código
                    // Verifica se existe um tabPage dentro do meus controles.
                    if (ctr1 is TabPage)
                    {   
                        // Percorrer todos os controles dentro do tabPage
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            // Verifica se é um textBox se for, aplica a linha de código
                            if (ctr2 is TextBox)
                            {   
                                // Limpar o campo de texto
                                (ctr2 as TextBox).Text = string.Empty;

                            }

                            // Verifica se é um MaskedTextBox se for, aplica a linha de código
                            if (ctr2 is MaskedTextBox)
                            {
                                // Limpar o campo de texto
                                (ctr2 as MaskedTextBox).Text = string.Empty;

                            }

                            if(ctr2 is ComboBox)
                            {
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
