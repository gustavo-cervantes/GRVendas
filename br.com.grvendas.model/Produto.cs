using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRVendas.br.com.grvendas.model
{
    public class Produto
    {
        // Atributos e getters e setter
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QtdEstoque { get; set; }

        // Associação produto e fornecedor, todas as chaves estrangeiras no C# são do tipo int
        public int for_id { get; set; } 
    }
}
