using AppFooD.Helps.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFooD.Models.FormasPagamentos
{
    public class FormPagamentoGroup : List<Cartao>
    {
        public TipoFormaPagamenoEnum tipoFormaPagameno { get; set; }
        public FormPagamentoGroup(TipoFormaPagamenoEnum _tipoFormaPagameno, List<Cartao> cartaos) : base(cartaos)
        {
            tipoFormaPagameno = _tipoFormaPagameno;
        }


    }
}
 