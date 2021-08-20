using AppFooD.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarrinhoCompraPage : ContentPage
    {
        public CarrinhoCompraPage(CarrinhoComprasViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}