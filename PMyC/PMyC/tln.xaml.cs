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
    public partial class tln : ContentPage
    {
        public tln()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtN1.Text))
            {
                var m = double.Parse(txtN1.Text);
                var fuerza = m + "  N";

                resultado.Text = fuerza.ToString();
            }
            else
            {
                DisplayAlert("Datos incompletos", "Escribe todos los datos", "ok");
            }

        }
    }
}
