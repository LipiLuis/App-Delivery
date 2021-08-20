using System;
using AppFooD.Models;
using AppFooD.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using Timer = System.Timers.Timer;
using AppFood.Models;

namespace AppFood.ViewModel
{
    public class PedidosViewModel : BaseViewModel
    {

        private ObservableCollection<Pedido> _listPedidos;

        public ObservableCollection<Pedido> ListPedidos
        {
            get { return _listPedidos; }
            set
            {
                SetProperty(ref _listPedidos, value);
            }
        }


        private AccountUser _account;
        public AccountUser ContaUser
        {
            get { return _account; }
            set
            {
                SetProperty(ref _account, value);
            }
        }

        public ICommand VoltarTelaInicial { get; set; }
        public ICommand ExibirDetalhePedidoCommand { get; set; }

        private Estabelecimento _estabelecimento;

        public Estabelecimento Estabelecimento
        {
            get { return _estabelecimento; }
            set { SetProperty(ref _estabelecimento, value); }
        }

        public PedidosViewModel()
        {
            ListPedidos = new ObservableCollection<Pedido>();
            Estabelecimento = new Estabelecimento();

        }
        //public void CronometroPedido()
        //{
        //    //fazer Temporizador >;

        //    var Timer = new Timer();
        //    Timer.Interval =1000;

        //    // Hook up the Elapsed event for the timer. 
        //    Timer.Elapsed += OnTimedEvent;

        //    // Have the timer fire repeated events (true is the default)
        //    Timer.AutoReset = true;

        //    // Start the timer
        //    Timer.Enabled = true;

        //}

        //private async void OnTimedEvent(object sender, ElapsedEventArgs e)
        //{
        //    await Task.Run(() =>
        //  {
        //        foreach (var pedido in listPedidos)
        //        {
        //            pedido.Temporizador = pedido.Temporizador.AddSeconds(1);
        //        }

        //    });

        //}

        public void GravarPedido(List<Pedido> pedidos, Estabelecimento estabelecimento)
        {
            Estabelecimento = estabelecimento;
            //ListPedidos.Add(pedidos.FirstOrDefault(p => p.itensPedido != null));

            ContaUser.Pedidos.Add(pedidos.FirstOrDefault(p => p.itensPedido != null));
        }
    }
}
