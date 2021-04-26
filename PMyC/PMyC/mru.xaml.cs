using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMyC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtN1.Text) && !String.IsNullOrEmpty(txtN2.Text))
            {
                var distancia = double.Parse(txtN1.Text);
                var tiempo = double.Parse(txtN2.Text);
                var velocidad = distancia/tiempo+" m/s";
                resultado.Text = velocidad.ToString();
            }
            else
            {
                DisplayAlert("Datos incompletos", "Escribe todos los datos", "ok");
            }

        }
    }
}
