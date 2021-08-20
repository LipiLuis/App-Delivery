using AppFooD.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriaEstasbelecimentosPage : ContentPage
    {
        public CategoriaEstasbelecimentosPage(CategoriaEstasbelecimentoViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

    }
}