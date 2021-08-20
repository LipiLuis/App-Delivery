using AppFood.Helps.Interfaces;
using AppFood.View;
using AppFood.View.Account;
using AppFood.View.Home;
using AppFood.View.Home.Account;
using AppFood.ViewModel;
using AppFooD.View;
using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFood.Helps
{
    public class NavigationHelper : INavigationHelper
    {
        private bool _isNavigating = false;

        public async Task GoCadastroEndereco(CadastroEnderecoViewModel vm)
        {
            await NavigateModal(new CadastroEnderecoPage(vm));

        }

        public async Task GoCadastroPedido(CadastroPedidoViewModel vm)
        {
            await NavigateModal(new CadastroPedidoPage(vm));

        }
        public async Task GoEstabelecimento(EstabelecimentoViewModel vm)
        {
            await Navigate(new EstabelecimentoPage(vm));

        }

        public async Task GoCarrinhoCompra(CarrinhoComprasViewModel vm)
        {
            await Navigate(new CarrinhoCompraPage(vm));
        }
        public async Task GoTelaLogin(LoginViewModel vm)
        {
            await Navigate(new LoginPage(vm));
        }
        public async Task GoRegister(RegisterViewModel vm)
        {
            await Navigate(new RegisterPage(vm));
        }
        public async Task GoTelaConfig(ConfigUserViewModel vm)
        {
            await Navigate(new ConfigUserPage(vm));
        }

        public async Task GoCategoriaEstabelecimento(CategoriaEstasbelecimentoViewModel vm)
        {
            await Navigate(new CategoriaEstasbelecimentosPage(vm));
        }

        public async Task GoDetalhePedido(DetalhePedidoViewModel vm)
        {
            await Navigate(new DetalhePedidoPage(vm));
        }

        public async Task GoDetalheProduto(DetalheProdutoViewModel vm)
        {
            await Navigate(new DetalheProdutoPage(vm));
        }

        public async Task GoEListCartoes(FormasPagamentosViewModel vm)
        {
            await NavigateModal(new ListCartoesPage(vm));

        }

        public async Task GoEndereco(EnderecoViewModel vm)
        {
            await NavigateModal(new EnderecoPage(vm));
        }


        public async Task GoListaProduto(ListaProdutoViewModel vm)
        {
            await Navigate(new ListaProdutoPage(vm));
        }

        public async Task GoPedidosN(PedidosViewModel vm)
        {
            await Navigate(new PedidosPage(vm));
        }
        public async Task GoPedidosNM(PedidosViewModel vm)
        {
            await NavigateModal(new PedidosPage(vm));
        }

        private async Task Navigate(Page page)
        {
            if (_isNavigating)
                return;

            _isNavigating = true;
            await Application.Current.MainPage.Navigation.PushAsync(page);

            Device.StartTimer(
                TimeSpan.FromMilliseconds(500),
                () => _isNavigating = false
            );
        }

        private async Task NavigateModal(Page page)
        {
            if (_isNavigating)
                return;

            _isNavigating = true;
            await Application.Current.MainPage.Navigation.PushModalAsync(page);

            Device.StartTimer(
                TimeSpan.FromMilliseconds(500),
                () => _isNavigating = false
            );
        }
    }
}