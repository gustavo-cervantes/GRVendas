using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRVendas.br.com.grvendas.model
{
    public class Funcionario : Cliente
    {
        // 1 - Atributos e os getters e setters
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivel_acesso { get; set; }
    }
}
