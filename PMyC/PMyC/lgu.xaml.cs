using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMyC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lgu : ContentPage
    {
        public lgu()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtN1.Text) && !String.IsNullOrEmpty(txtN2.Text ) && !String.IsNullOrEmpty(txtN3.Text) && !String.IsNullOrEmpty(txtN4.Text))
            {
                var g = double.Parse(txtN1.Text);
                var m1 = double.Parse(txtN2.Text);
                var m2 = double.Parse(txtN3.Text);
                var d2 = double.Parse(txtN4.Text);
                var fuerza = (g*((m1*m2)/(d2*d2))) +" N";
                resultado.Text = fuerza.ToString();
            }
            else
            {
                DisplayAlert("Datos incompletos", "Escribe todos los datos", "ok");
            }

        }
    }
}

