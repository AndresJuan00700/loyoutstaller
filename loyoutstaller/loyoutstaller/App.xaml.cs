using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loyoutstaller
{
    public partial class App : Application
    {
        public static Aplicacion FloyoutP { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage ( new MainPage());
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
