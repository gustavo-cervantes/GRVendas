using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRVendas.br.com.grvendas.model
{
    public class Venda
    {
        // Atributos e propiedades de acessos (getters e setters)]
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public DateTime Data_venda { get; set; }
        public Decimal Total_venda { get; set; }
        public string Obs { get; set; }
    }
}
