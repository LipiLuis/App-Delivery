using AppFooD.Helps.Enum;
using AppFooD.Models;
using AppFooD.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class DetalheProdutoViewModel : BaseViewModel
    {

        private Produto _ProdutoSelect;
        public Produto ProdutoSelect
        {
            get { return _ProdutoSelect; }
            set { SetProperty(ref _ProdutoSelect, value); }
        }
        private int _QtdItensPedido;
        public int QtdItensPedido
        {
            get { return _QtdItensPedido; }
            set { SetProperty(ref _QtdItensPedido, value); }
        }

        private int _Quantidade;
        public int Quantidade
        {
            get { return _Quantidade; }
            set
            {
                if (SetProperty(ref _Quantidade, value))
                {
                    ValorTotal = Quantidade * ProdutoSelect.Preco + (PrecoTamanhoPizza * Quantidade);
                }

            }
        }
        public TamanhoPizzaEnum TamanhoPizza { get; set; }
        private decimal _ValorTotal;
        public decimal ValorTotal
        {
            get { return _ValorTotal; }
            set { SetProperty(ref _ValorTotal, value); }
        }

        //public Produto Produto { get; set; }


        private decimal _PrecoTamanhoPizza;
        public decimal PrecoTamanhoPizza
        {
            get { return _PrecoTamanhoPizza; }
            set { SetProperty(ref _PrecoTamanhoPizza, value); }
        }
        private string _Observacao;
        public string Observacao
        {
            get { return _Observacao; }
            set { SetProperty(ref _Observacao, value); }
        }

        private int _IndexSelect;
        public int IndexSelect
        {
            get { return _IndexSelect; }
            set
            {
                if (SetProperty(ref _IndexSelect, value))
                {
                    CalcularValorTamanhoPizza(IndexSelect);
                    if (Quantidade > 1)
                    {
                        TamanhoPizza = (TamanhoPizzaEnum)Enum.Parse(typeof(TamanhoPizzaEnum), _IndexSelect.ToString());
                        ValorTotal = Quantidade * ProdutoSelect.Preco + (PrecoTamanhoPizza * Quantidade);

                    }
                }
            }
        }

        private void CalcularValorTamanhoPizza(int IndexSelect)
        {
            switch (IndexSelect)
            {
                case 0:
                    PrecoTamanhoPizza = 0.00M;
                    break;
                case 1:
                    PrecoTamanhoPizza = 2.00M;
                    break;
                case 2:
                    PrecoTamanhoPizza = 3.00M;
                    break;
                case 3:
                    PrecoTamanhoPizza = 5.00M;
                    break;
                default:
                    break;
            }


        }
        public ICommand AddQtde { get; set; }
        public ICommand DiminQtde { get; set; }
        public ICommand AdicionarProdutoCommand { get; set; }
        //public ICommand VoltarTelaCommand { get; set; }
        public ICommand AbrirTelaCarrinhoCompraCommand { get; set; }
        public DetalheProdutoViewModel()
        {
            IndexSelect = -1;
            Observacao = "";
        }



        public void AdicionarProdutoCarrinhoPedido(ObservableCollection<ItemPedido> itensDoPedido)
        {
            // quando voltar arrumar isso  :)
            itensDoPedido.Add(new ItemPedido()
            {
                Produto = ProdutoSelect,
                Quantidade = Quantidade

            });
            ProdutoSelect.Qtde = Quantidade;
            ProdutoSelect.tamanhoProduto = TamanhoPizza;
            ProdutoSelect.Observacao = Observacao;
            //ProdutoSelect = null;
            IndexSelect = -1;
            ValorTotal = ProdutoSelect.Preco;
            Quantidade = 1;
        }
        public void ListarCategoriaProdutos(Produto produtoSelect)
        {
            ProdutoSelect = new ProdutoServices().GetProdutos().FirstOrDefault(p => p.ProdutoID == produtoSelect.ProdutoID);
            ProdutoSelect = produtoSelect;
            IndexSelect = -1;
            ValorTotal = produtoSelect.Preco;
            Quantidade = 1;
            PrecoTamanhoPizza = 0;
        }
    }
}
