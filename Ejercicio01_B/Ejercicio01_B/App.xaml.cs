using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio01_B
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridDemo();
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
