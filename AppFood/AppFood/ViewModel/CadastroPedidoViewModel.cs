using AppFood;
using AppFood.Helps.Enum;
using AppFooD.Models;
using AppFooD.Models.FormasPagamentos;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class CadastroPedidoViewModel : BaseViewModel
    {
        private Pedido _Pedidos;
        public Pedido Pedidos
        {
            get { return _Pedidos; }
            set
            {
                SetProperty(ref _Pedidos, value);
                _Pedidos.Total = SubTotal + Frete;
            }
        }

        public List<Pedido> pedidos { get; set; }

        private decimal _Total;
        public decimal Total
        {
            get { return _Total; }
            set { SetProperty(ref _Total, value); }
        }
        private decimal _Frete;
        public decimal Frete
        {
            get { return _Frete; }
            set { SetProperty(ref _Frete, value); }
        }

        private decimal _SubTotal;
        public decimal SubTotal
        {
            get { return _SubTotal; }
            set { SetProperty(ref _SubTotal, value); }
        }

        private Endereco _EnderecoSelect;
        public Endereco EnderecoSelect
        {
            get { return _EnderecoSelect; }
            set { SetProperty(ref _EnderecoSelect, value); }
        }

        private List<Produto> _ProdutoPedido;
        public List<Produto> ProdutoPedido
        {
            get { return _ProdutoPedido; }
            set { SetProperty(ref _ProdutoPedido, value); }
        }

        private Cartao _CartaoSelect;
        public Cartao CartaoSelect
        {
            get { return _CartaoSelect; }
            set { SetProperty(ref _CartaoSelect, value); }
        }
        public ICommand PagamentoAPPCommand { get; set; }
        public ICommand PagamentoEntregaCommand { get; set; }
        public ICommand ConfirmarPedidoCommand { get; set; }
        public CadastroPedidoViewModel()
        {
            Pedidos = new Pedido();
            CartaoSelect = null;
        }

        public void CalcularPrecoPedidos(decimal subTotal, decimal frete)
        {
            this.Frete = frete;
            this.SubTotal = subTotal;
            this.Total = subTotal + frete;

        }


        public async void VerificacaoTroco(Cartao cartao, string result)
        {
            var sum = 0M;
            if (result != null && result[0] != ',' && result[0] != '-' && result != "-,") // arrumar isso dps
            {
                var troco = decimal.Parse(result);
                if (troco >= Total)
                {
                    sum = troco - Total;
                    await App.Current.MainPage.DisplayAlert("Troco", $"Valor do Troco: R$ {sum}", "Ok");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Valor do Troco menor que o valor do pedido",
                        "Ok");
                    Isbusy = false;
                    CartaoSelect = null;
                }

                troco = sum;
                //CartaoSelect = cartao;
            }
        }

        public string GerarCodigoPedido()
        {
            string text = "";
            char[] abcNumber = new[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z','0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            //char[] Numero = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random Rd = new Random();
            var d = Guid.NewGuid().ToString();
            for (int i = 0; i < 6; i++)
            {
                text += abcNumber[Rd.Next(abcNumber.Length)];
            }

            return text;
        }
        public void PegarEndereco(Endereco endereco)
        {
            EnderecoSelect = endereco;
            CartaoSelect = null;
            IsClicked = true;
            Isbusy = false;
        }

        public List<Pedido> AdicionarPedido(Estabelecimento estabelecimento, Pedido pedido)
        {

            if (Pedidos != null)
            {
                return new List<Pedido>()
                {
                    new Pedido()
                    {
                        PedidoId =+  1,
                        Estabelecimento = estabelecimento,
                        Total = Total,
                        EstabelecimentoID = estabelecimento.EstabelecimentoID,
                        Endereco = EnderecoSelect,
                        Cartao = CartaoSelect,
                        itensPedido = pedido.itensPedido,
                        DataPedido = DateTime.Now,
                        CodigoPedido = pedido.CodigoPedido,
                        DataPrevisaoEntrega = estabelecimento.DataEntrega,
                        EnumTrackDelivery = EnumTrackDelivery.Pendente,

                    }
                };
            }

            return null;
        }

        //public void IsCheck()
        //{
        //    CartaoSelect = null;
        //    IsClicked = true;
        //    Isbusy = false;
        //}

    }

}
