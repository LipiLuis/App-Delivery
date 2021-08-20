using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFood.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhePedidoPage : ContentPage
    {
        public DetalhePedidoPage(DetalhePedidoViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}