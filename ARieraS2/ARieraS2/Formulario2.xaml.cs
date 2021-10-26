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
    public partial class Formulario2 : ContentPage
    {
        public Formulario2()
        {
        }

        public Formulario2(string Usuario, string Clave)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            lblClave.Text = Clave;
            txtUsuario.Text = Usuario;
            txtClave.Text = Clave;

        }
    }
}