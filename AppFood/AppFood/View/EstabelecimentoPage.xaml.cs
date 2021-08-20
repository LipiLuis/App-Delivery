using AppFooD.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstabelecimentoPage : ContentPage
    {
        public EstabelecimentoPage(EstabelecimentoViewModel vm)
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