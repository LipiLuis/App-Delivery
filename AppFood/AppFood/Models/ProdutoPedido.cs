using AppFood.Models;
using System.Collections.Generic;

namespace AppFooD.Models
{
    public class ProdutoPedido
    {
        public int ProdutoPedidoID { get; set; }
        public int Qtde { get; set; }
        public bool Promocao { get; set; }
        public List<SaboresPizza> saboresPizzas { get; set; }

        public decimal ValorTamanhoPizza { get; set; }
    }
}
