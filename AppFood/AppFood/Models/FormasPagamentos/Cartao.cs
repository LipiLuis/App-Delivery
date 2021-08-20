using AppFooD.Helps.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFooD.Models.FormasPagamentos
{
    public class Cartao : Models.FormaPagamento
    {
        public int CartaoID { get; set; }
        public int EstabelecimentoID { get; set; }

    }
}
