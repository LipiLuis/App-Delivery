using AppFood.ViewModel;
using AppFooD.Models;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PedidosPage : ContentPage
    {
        public PedidosPage(PedidosViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }


}
