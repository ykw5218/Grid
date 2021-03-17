using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        private async void Go_Page3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void Go_Page5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}