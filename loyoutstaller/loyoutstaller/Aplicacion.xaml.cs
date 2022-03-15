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
    public partial class Aplicacion : FlyoutPage
    {
        public Aplicacion()
        {
            InitializeComponent();

            this.Flyout = new botones();
            this.Detail = new NavigationPage(new perfil());

            App.FloyoutP = this;


        }
    }
}