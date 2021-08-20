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
    public partial class CadastroEnderecoPage : ContentPage
    {
        public CadastroEnderecoPage(CadastroEnderecoViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}