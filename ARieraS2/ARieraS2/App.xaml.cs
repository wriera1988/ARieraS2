using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ARieraS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Navegacion entre Ventanas
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
