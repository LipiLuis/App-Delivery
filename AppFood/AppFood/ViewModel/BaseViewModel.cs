using System;
using AppFooD.Helps;
using System.Windows.Input;
using AppFood.ViewModel;

namespace AppFooD.ViewModel
{
    public class BaseViewModel : NotifyBase
    {
        private bool _Isbusy;
        public bool Isbusy
        {
            get { return _Isbusy; }
            set { SetProperty(ref _Isbusy, value); }
        }

        private bool _IsClicked;
        public bool IsClicked
        {
            get { return _IsClicked; }
            set { SetProperty(ref _IsClicked, value); }
        }
        public ICommand VoltarPageCommand { get; set; }
        public ICommand ChamarTelaPedidosCommand { get; set; }
        public ICommand ChamarTelaEstabelecimento { get; set; }
        public ICommand ChamarTelaConfigUser { get; set; }


    }
}
