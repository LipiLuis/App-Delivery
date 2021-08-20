using System;
using AppFooD.Helps.Enum;
using AppFooD.Models.FormasPagamentos;
using AppFooD.Services;
using System.Collections.Generic;
using System.Linq;

namespace AppFooD.Models
{
    public class Estabelecimento
    {
        public int EstabelecimentoID { get; set; }
        public string Nome { get; set; }
        public ProdutoEnum ProdutoEnums { get; set; }
        public string Logo { get; set; }
        public  DateTime DataEntrega {  get;  set; }
        public decimal Star { get; set; }
        public FormPagamentoGroup FormPagamento { get; set; }
        public decimal PrecoDelivery { get; set; }
        public string IconLocation { get; set; }
        public Endereco endereco { get; set; }
        public string AbertoFechado { get; set; }
    }
}
