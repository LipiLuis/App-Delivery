using AppFooD.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheProdutoPage : ContentPage
    {
        public DetalheProdutoPage(DetalheProdutoViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
        //protected override bool OnBackButtonPressed()
        //{


        //    return false;
        //}
    }
}