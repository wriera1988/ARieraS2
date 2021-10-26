using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ARieraS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vista3 : ContentPage
    {
        public vista3()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacenar en variables, lo que el usuario ingresa en las cajas de texto
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);
                //operacion
                double suma = valor1 + valor2;
                //visualizar el resultado en pantalla
                txtResultado.Text = Convert.ToString(suma);
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }
        }

        private void btnSumar_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}