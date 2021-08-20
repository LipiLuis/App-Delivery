using AppFood.Helps;
using AppFood.Helps.Interfaces;
using AppFood.View.Account;
using AppFood.View.Home;
using AppFood.View.Home.Account;
using AppFood.ViewModel;
using AppFooD.View;
using AppFooD.ViewModel;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<INavigationHelper, NavigationHelper>();


            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public static Action HideLoginView
        {
            get
            {
                return new Action(() => App.Current.MainPage.Navigation.PopModalAsync());
            }
        }

        public async static Task NavigateToProfile(string msg)
        {
            if(msg == "Usuário Cancelou o login")
            {
                await App.Current.MainPage.Navigation.PopToRootAsync();
            }
            else
            {

            //await App.Current.MainPage.Navigation.PushAsync(new RegisterPage(msg));
            }
        }
    }
}
