using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Go_Item(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private async void Go_NextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

    }
}