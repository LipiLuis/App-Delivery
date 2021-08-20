using System;
using AppFooD.Models;
using AppFooD.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class CategoriaEstasbelecimentoViewModel : BaseViewModel
    {

        private Estabelecimento _Estabelecimento;
        public Estabelecimento Estabelecimento
        {
            get { return _Estabelecimento; }
            set { SetProperty(ref _Estabelecimento, value); }
        }

        public DateTime Time { get; set; }

        private int _TimeDelivery;
        public int TimeDelivery
        {
            get { return _TimeDelivery; }
            set { SetProperty(ref _TimeDelivery, value); }
        }
        public CategoriaProduto categoriaProduto { get; set; }
        public List<CategoriaProduto> listCategoriaProdutos { get; set; }
        private List<Produto> _ProodutosPromocoes;

        public List<Produto> ProodutosPromocoes
        {
            get { return _ProodutosPromocoes; }
            set { SetProperty(ref _ProodutosPromocoes, value); }
        }

        public ICommand ExibirProdutosCommand { get; set; }
        public ICommand ExibirDetalheProdutos { get; set; }
        //public ICommand ChamarTelaPedidosCommand { get; set; }
        public CategoriaEstasbelecimentoViewModel()
        {
            categoriaProduto = new CategoriaProduto();
               ProodutosPromocoes = new List<Produto>();
            Time = DateTime.Now;
        }


        public void ListarCategoriaProdutos(Estabelecimento estabelecimento)
        {
            TimeDelivery = 0;
            categoriaProduto = new CategoriaProdutoServices().GetCategoriaProdutos().FirstOrDefault(c => c.EmpresaId == estabelecimento.EstabelecimentoID) ;
            ProodutosPromocoes = new ProdutoServices().GetProdutos().Where(p => p.Promocao == true && p.CategoriaProdutoId == categoriaProduto.CategoriaProdutoId).ToList();
            listCategoriaProdutos = new CategoriaProdutoServices().GetCategoriaProdutos().Where(l => l.EmpresaId == estabelecimento.EstabelecimentoID).ToList();
            Estabelecimento = estabelecimento;
            if (TimeDelivery == 0)
            {
                TimeDelivery = (int)estabelecimento.DataEntrega.Subtract(Time.TimeOfDay).Minute;

                //TimeDelivery = (int)(Estabelecimento.DataEntrega.TimeOfDay.TotalMinutes - DateTime.Now.TimeOfDay.TotalMinutes);
            }

        }
    }
}
