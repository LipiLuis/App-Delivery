using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFooD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCartoesPage : ContentPage
    {
        public ListCartoesPage(FormasPagamentosViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}