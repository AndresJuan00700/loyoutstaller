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
    public partial class botones : ContentPage
    {
        public botones()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new calendario());
            App.FlyoutP.IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new calendariobienhecho());
            App.FlyoutP.IsPresented = false;
        }


    }
}