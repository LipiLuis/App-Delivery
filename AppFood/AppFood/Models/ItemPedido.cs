namespace AppFooD.Models
{
    public class ItemPedido
    {
        public int ItemPedidoID { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal {
            get
            {
                return Produto.ValorTotal * Quantidade;
            }
        }

    }
}
