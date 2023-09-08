using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Conversor_cm_a_m.Vistas;

namespace Conversor_cm_a_m
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
    }
}
