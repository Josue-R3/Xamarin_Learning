using Conversor_cm_a_m.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Conversor_cm_a_m
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conversor());
        }
    }
}