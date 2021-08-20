using AppFood.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.View.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigUserPage : ContentPage
    {
        public ConfigUserPage(ConfigUserViewModel vm)
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