using AppFooD.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPedidoPage : ContentPage
    {
        public CadastroPedidoPage(CadastroPedidoViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }

    }
}