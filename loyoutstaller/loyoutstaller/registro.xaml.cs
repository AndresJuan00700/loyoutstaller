using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loyoutstaller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();

            Registro.Clicked += (sender, e) =>
            {

                Navigation.PushModalAsync(new Aplicacion());



            };



        }
    }
}