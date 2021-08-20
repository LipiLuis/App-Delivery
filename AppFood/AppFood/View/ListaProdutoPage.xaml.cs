using AppFooD.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaProdutoPage : ContentPage
    {

        public ListaProdutoPage(ListaProdutoViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
            //itensDoPedido = new ObservableCollection<ItemPedido>();

            //vmDp = new DetalhePedidoViewModel();
            //vmLP = new ListaProdutoViewModel();
            //vmCC = new CarrinhoComprasViewModel();

            //vmLP.ExibirProdutoCommand = new Command<Produto>(ChamarDetalheProduto);
            //vmLP.ExibirCarrinhoProdutosCommand = new Command(ChamarCarrinhoProduto);

            //BindingContext = vm;

            //itensDoPedido.CollectionChanged += ItensDoPedido_CollectionChanged;
        }


        //private void ChamarCarrinhoProduto()
        //{
        //    vmCC.ProdutosCarrinhoCompra = itensDoPedido;
        //    var frmCC = new CarrinhoCompraPage(vmCC);

        //    Navigation.PushAsync(frmCC);
        //}

        //private void ItensDoPedido_CollectionChanged(object sender,NotifyCollectionChangedEventArgs e)
        //{
        //    vmLP.QtdItensPedido = itensDoPedido.Count;
        //}

        //private void ChamarDetalheProduto(Produto produtoSel)
        //{
        //    vmDp.ProdutoSelect = produtoSel;

        //    vmDp.AdicionarProdutoCommand = new Command(() =>
        //    {
        //        Navigation.PopAsync();
        //        if (vmDp.QtdeSelecionada > 0)
        //        {
        //            itensDoPedido.Add(new ItemPedido()
        //            {
        //                Produto = vmDp.ProdutoSelect,
        //                Quantidade = vmDp.QtdeSelecionada
        //            });
        //          DisplayAlert("Alert", $"Sucesso ", "Ok");
        //        }
        //    });

        //    var frmDPP = new DetalhePedidoPage(vmDp);

        //    //Navega 
        //    Navigation.PushAsync(frmDPP);


        //}
    }
}