
using AppFood.Models;
using AppFooD.Helps.Enum;
using System.Collections.Generic;

namespace AppFooD.Models
{
    public class Produto : ProdutoPedido
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }
        public string Descricao { get; set; }
        public ProdutoEnum TipoProduto { get; set; }
        public TamanhoPizzaEnum tamanhoProduto { get; set; }
        public decimal Preco { get; set; }
        public string Observacao { get; set; }
        public int CategoriaProdutoId { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Preco * Qtde;
            }

        }

        public Produto()
        {
            Promocao = false;
        }

    }
}
