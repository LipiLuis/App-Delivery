using AppFood.ViewModel;
using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Helps.Interfaces
{
    interface INavigationHelper
    {
        Task GoCategoriaEstabelecimento(CategoriaEstasbelecimentoViewModel vm);
        Task GoCadastroEndereco(CadastroEnderecoViewModel vm);
        Task GoCadastroPedido(CadastroPedidoViewModel vm);
        Task GoCarrinhoCompra(CarrinhoComprasViewModel vm);
        Task GoDetalhePedido(DetalhePedidoViewModel vm);
        Task GoEstabelecimento(EstabelecimentoViewModel vm);
        Task GoTelaConfig(ConfigUserViewModel vm);
        Task GoTelaLogin(LoginViewModel vm);
        Task GoRegister(RegisterViewModel vm);
        Task GoDetalheProduto(DetalheProdutoViewModel vm);
        Task GoEndereco(EnderecoViewModel vm);
        Task GoListaProduto(ListaProdutoViewModel vm);
        Task GoEListCartoes(FormasPagamentosViewModel vm);
        Task GoPedidosN(PedidosViewModel vm);
        Task GoPedidosNM(PedidosViewModel vm);
    }
}
