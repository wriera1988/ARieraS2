using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ARieraS2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         private void BtnSumar_Clicked(object sender, EventArgs e)
        {
            try {
                //Almacenar en variables, lo que el usuario ingresa en las cajas de texto
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);
                //operacion
                double suma = valor1 + valor2;
                //visualizar el resultado en pantalla
                txtResultado.Text = Convert.ToString(suma);
            }
            catch(Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }
        }

        private async void BtnAbrir_Clicked(object sender, EventArgs e)
        {
            try {
                string Usuario = txtUsuario.Text;
                string Clave = txtClave.Text;
                //abrir ventana formulario 2
                await Navigation.PushAsync(new Formulario2(Usuario, Clave));

            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje deadvertencia", ex.Message, "ok");
    }
}
    }
}