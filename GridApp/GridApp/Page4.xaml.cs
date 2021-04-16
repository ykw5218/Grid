using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridApp
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

        private async void Say_Monkey(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Monkey");
            await Navigation.PushAsync(new Page3());
        }
        private async void Say_Elephant(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Elephant");
            await Navigation.PushAsync(new Page5());
        }

        async void Add_button(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Add?", "Would you like to add a button?", "Yes", "No");
            if (response == true)
            {
                Button n = new Button();
                Item.Children.Add(n);
                n.Text = "Zebra";
                n.Margin = 0;
                n.Padding = 0;
                n.CornerRadius = 20;
                n.Clicked += Say_Zebra;
            }
            else
            {
                await DisplayAlert("Alert", "Add button failed.", "OK");
            }

        }

        private async void Say_Zebra(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Zebra");
        }
    }
}