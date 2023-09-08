using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor_cm_a_m.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conversor : ContentPage
    {
        double cm;
        double m;
        public Conversor()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            lb_result.Text = m.ToString() + " m";
        }
        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", " Ingrese una cantidad", " OK");
            }
        }
        private void btn_volver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}

