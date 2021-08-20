using AppFooD.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class CarrinhoComprasViewModel : BaseViewModel
    {

        private ObservableCollection<ItemPedido> _ProdutosCarrinhoCompra;
        public ObservableCollection<ItemPedido> ProdutosCarrinhoCompra
        {
            get { return _ProdutosCarrinhoCompra; }
            set { SetProperty(ref _ProdutosCarrinhoCompra, value); }
        }

        public ICommand LimpaItensCarrinhoCommand { get; set; }
        public ICommand CadastrarPedidosCommmand { get; set; }
        //public ICommand VoltarCommand { get; set; }
        public ICommand ExcluirProdutoCarrinhoCommand { get; set; }

        private decimal _ValorTotal;
        public decimal ValorTotal
        {
            get { return _ValorTotal; }
            set { SetProperty(ref _ValorTotal, value);
            }
        }

        public CarrinhoComprasViewModel()
        {

        }

        public void LimprarCarrinhoDeCompras()
        {
            ProdutosCarrinhoCompra.Clear();
        }

        

        public void ExcluirProdutoCarrinho(ItemPedido obj)
        {
            var ProdutoSelecionado = ProdutosCarrinhoCompra.FirstOrDefault(p => p.Produto.ProdutoID == obj.Produto.ProdutoID);

            if (ProdutoSelecionado != null)
            {
                ProdutosCarrinhoCompra.Remove(ProdutoSelecionado);
            }
        }



    }
}
