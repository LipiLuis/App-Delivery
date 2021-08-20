using System;
using System.Collections.Generic;
using System.Text;

namespace AppFooD.Models.FormasPagamentos
{
   public class FormaPagamento
    {
        public int FormaPagamentoID { get; set; }
        public int EstabelecimentoID { get; set; }
        public Dinheiro Dinheiro { get; set; }
        public Cartao Cartao { get; set; }

    }
}
