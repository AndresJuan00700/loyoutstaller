using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loyoutstaller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Inicio.Clicked += (sender, e) =>
            {

                Navigation.PushAsync(new registro());



            };




        }



    }
}
