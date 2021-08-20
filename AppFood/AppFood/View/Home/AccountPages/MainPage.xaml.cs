using AppFood.Helps.Interfaces;
using AppFood.Models;
using AppFood.ViewModel;
using AppFooD.Models;
using AppFooD.Models.FormasPagamentos;
using AppFooD.Services;
using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.View.Home.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private readonly EstabelecimentoViewModel VmES;
        private readonly CategoriaEstasbelecimentoViewModel VmCE;
        private readonly DetalheProdutoViewModel VmDProd;
        private readonly ListaProdutoViewModel VmP;
        private readonly PedidosViewModel VmLP;
        private readonly CarrinhoComprasViewModel VmCC;
        private readonly EnderecoViewModel VmAddress;
        private readonly CadastroPedidoViewModel VmCP;
        private readonly FormasPagamentosViewModel vmPGE;
        private readonly DetalhePedidoViewModel vmDPedid;
        private readonly ConfigUserViewModel vmConfUser;
        private readonly LoginViewModel vmLogin;
        private readonly RegisterViewModel vmRegister;

        private readonly CadastroEnderecoViewModel VmCED;

        private readonly ObservableCollection<ItemPedido> itensDoPedido;
        private readonly ObservableCollection<Endereco> ListEndereco;
        private List<AppFood.Models.AccountUser> Contas;


        private Estabelecimento estabelecimentoSelect;
        public MainPage()
        {

            itensDoPedido = new ObservableCollection<ItemPedido>();
            ListEndereco = new ObservableCollection<Endereco>();
            Contas = new List<Models.AccountUser>();
            estabelecimentoSelect = new Estabelecimento();

            VmES = new EstabelecimentoViewModel();
            VmCE = new CategoriaEstasbelecimentoViewModel();
            VmDProd = new DetalheProdutoViewModel();
            VmP = new ListaProdutoViewModel();
            VmCC = new CarrinhoComprasViewModel();
            VmLP = new PedidosViewModel();
            VmAddress = new EnderecoViewModel();
            VmCP = new CadastroPedidoViewModel();
            VmCED = new CadastroEnderecoViewModel();
            vmPGE = new FormasPagamentosViewModel();
            vmRegister = new RegisterViewModel();
            vmLogin = new LoginViewModel();
            vmConfUser = new ConfigUserViewModel();
            vmDPedid = new DetalhePedidoViewModel();

            InitializeComponent();
            Task.Run(async () =>
            {
                await DependencyService.Get<INavigationHelper>().GoEstabelecimento(VmES);

            });

            VmES.ExibirEstabelecimentoCommand = new Command<Estabelecimento>(ChamarTelaCategoriaProdutos);
            VmCE.ExibirProdutosCommand = new Command<CategoriaProduto>(ChamarTelaListaProduto);
            VmP.ExibirProdutoCommand = new Command<Produto>(ChamarTelaDetalheProduto);
            VmCE.ExibirDetalheProdutos = new Command<Produto>(ChamarTelaDetalheProduto);
            VmP.ExibirCarrinhoProdutosCommand = new Command(ChamarTelaCarrinhoProdutos);
            VmDProd.AbrirTelaCarrinhoCompraCommand = new Command(ChamarTelaCarrinhoProdutos);
            VmDProd.AddQtde = new Command(AdicionarQtde);
            VmDProd.DiminQtde = new Command(DiminuirQtde);

            VmCC.CadastrarPedidosCommmand = new Command<ObservableCollection<ItemPedido>>(ChamarTelaEscolherEndereco);
            VmES.ChamarTelaPedidosCommand = new Command(ChamarTelaPedidos);
            VmLP.VoltarTelaInicial = new Command(VoltarPagePrincipal);
            VmLP.ExibirDetalhePedidoCommand = new Command<Pedido>(ChamarTelaDetalhePedido);
            VmES.ChamarTelaPedidosCommand = new Command(ChamarTelaPedidos);
            VmAddress.CadastroNovoEnderecoCommand = new Command(ChamarTelaCadastroEndereco);
            VmCP.ConfirmarPedidoCommand = new Command<Pedido>(GravarPedidosLista);
            VmCC.ExcluirProdutoCarrinhoCommand = new Command<ItemPedido>((ObjSelect) =>
            {
                itensDoPedido.Remove(ObjSelect);
                VmCC.ExcluirProdutoCarrinho(ObjSelect);
            });

            vmPGE.FormaPagamentoSelecionadoCommand = new Command<Cartao>(PegarFormaPagamentoSelecionado);
            VmCP.PagamentoEntregaCommand = new Command(ChamarTelaPagamentoEntrega);
            VmCP.PagamentoAPPCommand = new Command(ChamarTelaPagamentoAPP);
            VmAddress.CadastroPedidoCommand = new Command<Endereco>(ChamarTelaCadastroPedidoEndereco);
            VmCED.VoltarPageCommand = new Command(() => Navigation.PopModalAsync());
            VmAddress.VoltarPageCommand = new Command(() => Navigation.PopModalAsync());
            VmES.ChamarTelaConfigUserCommand = new Command(ChamarTelaConfig);
            VmES.ChamarTelaHomeCommand = new Command(ChamarTelaHome);
            VmCC.LimpaItensCarrinhoCommand = new Command(LimprarCarrinhoDeCompras);
            VmCED.GravarEnderecoCommand = new Command(GravarEnderco);
            VmAddress.BuscarEstabelecimentoCommand = new Command(ChamarTelaCadastroPedidos);
            VmAddress.CadastroPedidoCommand = new Command<Endereco>(ChamarTelaCadastroPedidoEndereco);

            vmDPedid.RefazerPedidoCommand = new Command<Pedido>(RefazerPedido);

            VmAddress.BuscarEstabelecimentoCommand = new Command(ChamarTelaCadastroPedidos);
            VmCC.VoltarPageCommand = new Command(() => Navigation.PopAsync());
            VmCE.VoltarPageCommand = new Command(() => Navigation.PopAsync());
            vmPGE.VoltarPageCommand = new Command(() => Navigation.PopModalAsync());
            VmDProd.VoltarPageCommand = new Command(() => Navigation.PopAsync());
            VmP.VoltarPageCommand = new Command(() => Navigation.PopAsync());
            VmCP.VoltarPageCommand = new Command(() => Navigation.PopModalAsync());
            VmCED.VoltarPageCommand = new Command(() => Navigation.PopModalAsync());
            itensDoPedido.CollectionChanged += ItensDoPedido_CollectionChanged;

            VmAddress.VoltarPageCommand = new Command(() => Navigation.PopModalAsync());

            VmCC.LimpaItensCarrinhoCommand = new Command(LimprarCarrinhoDeCompras);
            VmCED.GravarEnderecoCommand = new Command(GravarEnderco);

            VmLP.ChamarTelaConfigUser = new Command(ChamarTelaConfig);
            VmLP.ChamarTelaEstabelecimento = new Command(ChamarTelaHome);
            vmConfUser.ChamarTelaEstabelecimento = new Command(ChamarTelaHome);
            vmConfUser.ChamarTelaPedidosCommand = new Command(ChamarTelaPedidos);
            vmConfUser.ChamarTelaCadastro = new Command(ChamarTelaCadastroAccount);
            vmConfUser.ChamarTelaLogin = new Command(ChamarTelaLoginAccount);
            vmLogin.LoginAccountCommand = new Command(FazerLogin);
            vmConfUser.SairContaCommand = new Command(SairConta);
            vmRegister.CriarContaCommand = new Command(CadastrarAccount);
            VmDProd.AdicionarProdutoCommand = new Command(AdicionarProdutoCarrinho);
        }

        private async void AdicionarProdutoCarrinho(object obj)
        {
            if (VmDProd.Quantidade > 0)
            {
                if (vmConfUser.Account.Logado)
                {
                    VmDProd.AdicionarProdutoCarrinhoPedido(itensDoPedido);
                    await Navigation.PopAsync();

                }
                else
                {
                    if (await DisplayAlert("Você ainda não esta logado!", "Desejá logar ou criar uma nova conta?", "Sim", "Não"))
                    {

                        await DependencyService.Get<INavigationHelper>().GoTelaConfig(vmConfUser);
                    }

                }
                //DisplayAlert("Alert", $"Sucesso ", "Ok");
                //Navigation.PopAsync();

            }
        }

        private async void CadastrarAccount()
        {
            if (vmRegister.CadastroAcoount(Contas))
            {
                await DependencyService.Get<INavigationHelper>().GoTelaLogin(vmLogin);
            }

        }

        private async void SairConta()
        {
            if (await DisplayAlert("", "Deseja Sair da conta?", "Sim", "Não"))
            {
                vmConfUser.Account = null;
                VmLP.ContaUser = null;
            }
        }

        private async void FazerLogin()
        {
            var Conta = vmLogin.VerificarLogin(Contas);
            if (Conta != null)
            {
                await DependencyService.Get<INavigationHelper>().GoTelaConfig(vmConfUser);
                vmConfUser.Account = Conta;
                VmLP.ContaUser = Conta;
            }


        }

        private async void ChamarTelaLoginAccount()
        {
            await DependencyService.Get<INavigationHelper>().GoTelaLogin(vmLogin);
        }

        private async void ChamarTelaCadastroAccount()
        {
            await DependencyService.Get<INavigationHelper>().GoRegister(vmRegister);

        }

        private async void ChamarTelaHome()
        {
            await DependencyService.Get<INavigationHelper>().GoEstabelecimento(VmES);
        }

        private async void ChamarTelaConfig()
        {
            await DependencyService.Get<INavigationHelper>().GoTelaConfig(vmConfUser);

        }

        private async void PegarFormaPagamentoSelecionado(Cartao cartaoselecionado)
        {
            if (cartaoselecionado.Nome == "Dinheiro")
            {
                var result = await DisplayPromptAsync("Deseja Troco?", " ", "Sim", "Não",
                    "Digite quanto você vai pagar", keyboard: Keyboard.Numeric);

                VmCP.VerificacaoTroco(cartaoselecionado, result);
            }

            VmCP.CartaoSelect = cartaoselecionado;
            //VmCP.CartaoSelect.Troco = sum;
            VmCP.Isbusy = true;

            await Navigation.PopModalAsync();
            cartaoselecionado = null;
        }

        private async void ChamarTelaPagamentoAPP()
        {
            var PagamentoApp = vmPGE.ListarFormasApp();

            vmPGE.ListarFormaPagamento(estabelecimentoSelect, PagamentoApp);
            await DependencyService.Get<INavigationHelper>().GoEListCartoes(vmPGE);
        }

        private async void ChamarTelaPagamentoEntrega()
        {
            var PagamentoEntrega = vmPGE.ListarFormasEntrega();
            vmPGE.ListarFormaPagamento(estabelecimentoSelect, PagamentoEntrega);
            await DependencyService.Get<INavigationHelper>().GoEListCartoes(vmPGE);
        }
        private void GravarEnderco()
        {
            if (VmCED.GravarEnderecoList(ListEndereco))
            {
                VmAddress.ListEndereco = this.ListEndereco;
                DisplayAlert("Sucesso", "Endereço cadastrado! ", "Ok");
                Navigation.PopModalAsync();
            }
        }

        private async void ChamarTelaEscolherEndereco(ObservableCollection<ItemPedido> ProdutosCarrinhoCompra)
        {
            VmCP.Isbusy = false;
            if (ProdutosCarrinhoCompra.Count > 0)
            {
                await DependencyService.Get<INavigationHelper>().GoEndereco(VmAddress);
                VmCP.Pedidos.itensPedido = ProdutosCarrinhoCompra;
                VmCP.ProdutoPedido = VmCP.Pedidos.itensPedido.Select(p => p.Produto).ToList();
            }
            else
            {
                if (await DisplayAlert("Warning!", "Seu carrinho está vazio! Vamos fazer algumas compras? ", "Sim", "Não"))
                {
                    await Navigation.PopAsync();
                }
            }
        }


        public async void LimprarCarrinhoDeCompras()
        {
            if (itensDoPedido.Count > 0)
            {
                if (await DisplayAlert("Alert!", "Desejá Excluir todos pedidos do carrinho? ", "Sim", "Não", FlowDirection.LeftToRight))
                {
                    VmCC.LimprarCarrinhoDeCompras();
                    itensDoPedido.Clear();
                }
            }
        }

        private void ItensDoPedido_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            VmP.QtdItensPedido = itensDoPedido.Count;
            VmDProd.QtdItensPedido = itensDoPedido.Count;
            VmCC.ValorTotal = itensDoPedido.Sum(p => p.Produto.ValorTotal);
        }
        private async void ChamarTelaCadastroPedidos()
        {
            await DependencyService.Get<INavigationHelper>().GoCadastroPedido(VmCP);
            VmCP.CalcularPrecoPedidos(VmCC.ValorTotal, 0);
            VmCP.PegarEndereco(estabelecimentoSelect.endereco);
        }
        private async void ChamarTelaCadastroPedidoEndereco(Endereco Endereco)
        {
            if (VmAddress.EnderecoSelecionado != null)
            {
                VmCP.CartaoSelect = null;
                VmCP.Isbusy = false;
                //VmAddress.IsVisibleAddress = true;
                VmCP.EnderecoSelect = Endereco;
                VmCP.CalcularPrecoPedidos(VmCC.ValorTotal, estabelecimentoSelect.PrecoDelivery);
                await DependencyService.Get<INavigationHelper>().GoCadastroPedido(VmCP);
            }
            else
            {
                await DisplayAlert("Warning!", "Endereço não selecionado", "ok");
            }
        }

        private void RefazerPedido(Pedido pedido)
        {
            AdicionarPedidoLista(pedido);
        }

        private async void GravarPedidosLista(Pedido Pedido)
        {
            AdicionarPedidoLista(Pedido);
            await Navigation.PopModalAsync();
            await Navigation.PopModalAsync();
            await DependencyService.Get<INavigationHelper>().GoPedidosN(VmLP);
            itensDoPedido.Clear();
            ListEndereco.Clear();
        }
        public async void AdicionarPedidoLista(Pedido Pedido)
        {
            if (vmConfUser.Account.Logado)
            {
                Pedido.CodigoPedido = VmCP.GerarCodigoPedido();

                VmLP.GravarPedido(VmCP.AdicionarPedido(estabelecimentoSelect, Pedido), estabelecimentoSelect);

                //var pedido = VmLP.ListPedidos.FirstOrDefault(p => p.CodigoPedido == Pedido.CodigoPedido);
                var pedido = vmConfUser.Account.Pedidos.FirstOrDefault(p => p.CodigoPedido == Pedido.CodigoPedido);

                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    pedido.Temporizador = pedido.Temporizador.AddSeconds(1);
                    return true;
                });
            }

        }

        private async void ChamarTelaCadastroEndereco()
        {
            await DependencyService.Get<INavigationHelper>().GoCadastroEndereco(VmCED);
        }
        private async void ChamarTelaDetalhePedido(Pedido pedido)
        {
            vmDPedid.pedido = pedido;
            vmDPedid.PegaEstabelecimentos();
            await DependencyService.Get<INavigationHelper>().GoDetalhePedido(vmDPedid);
        }
        private void VoltarPagePrincipal()
        {
            Navigation.PopModalAsync();
        }

        private async void ChamarTelaListaPedidos()
        {
            //var frmLP = new PedidosPage(VmLP);
            //await Task.Run(async () =>  progressUpdate);

            await DependencyService.Get<INavigationHelper>().GoPedidosNM(VmLP);

            //await Navigation.PushAsync(frmLP);

        }
        /// <summary>
        ///  estranho dps ver
        /// </summary>
        private void ChamarTelaPedidos()
        {
            DependencyService.Get<INavigationHelper>().GoPedidosN(VmLP);
        }

        private void DiminuirQtde()
        {
            VmDProd.Quantidade = VmDProd.Quantidade <= 1 ? 1 : VmDProd.Quantidade -= 1;
        }

        private void AdicionarQtde(object obj)
        {
            VmDProd.Quantidade++;
        }


        private async void ChamarTelaCarrinhoProdutos()
        {
            VmCC.ProdutosCarrinhoCompra = new ObservableCollection<ItemPedido>(itensDoPedido);
            VmCC.ValorTotal = itensDoPedido.Sum(p => p.Produto.ValorTotal);
            await DependencyService.Get<INavigationHelper>().GoCarrinhoCompra(VmCC);

            //VmCC.ProdutosCarrinhoCompra.Sum(pd => pd.SubTotal);
        }

        private async void ChamarTelaDetalheProduto(Produto produtoSelect)
        {
            VmDProd.ListarCategoriaProdutos(produtoSelect);
            await DependencyService.Get<INavigationHelper>().GoDetalheProduto(VmDProd);

        }

        private async void ChamarTelaListaProduto(CategoriaProduto categoriaProduto)
        {
            VmP.ListaProdutos = new ProdutoServices().GetProdutos().Where(p => p.CategoriaProdutoId == categoriaProduto.CategoriaProdutoId).ToList(); // colocar vm 
            //VmDProd.AdicionarProdutoCommand = new Command(async () =>
            //{
            //    if (VmDProd.Quantidade > 0)
            //    {
            //        if (vmConfUser.Account.Logado)
            //        {
            //            VmDProd.AdicionarProdutoCarrinhoPedido(itensDoPedido);
            //            await Navigation.PopAsync();

            //        }
            //        else
            //        {
            //            if (await DisplayAlert("Você ainda não esta logado!", "Desejá logar ou criar uma nova conta?", "Sim", "Não"))
            //            {

            //                await DependencyService.Get<INavigationHelper>().GoTelaConfig(vmConfUser);
            //            }

            //        }
            //        //DisplayAlert("Alert", $"Sucesso ", "Ok");
            //        //Navigation.PopAsync();

            //    }

            //});
            await DependencyService.Get<INavigationHelper>().GoListaProduto(VmP);

        }
        private async void ChamarTelaCategoriaProdutos(Estabelecimento estabelecimento)
        {
            if (estabelecimento.AbertoFechado != "Fechado")
            {
                VmCE.ListarCategoriaProdutos(estabelecimento);
                //var FrmCE = new CategoriaEstasbelecimentosPage(VmCE);
                //Navigation.PushAsync(FrmCE);
                await DependencyService.Get<INavigationHelper>().GoCategoriaEstabelecimento(VmCE);
                estabelecimentoSelect = estabelecimento;
            }
            else
            {
                await DisplayAlert("Alert", "Estabelecimento Fechado no momento! Abre as 20:00h", "Ok");
            }
        }
    }
}