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
        
        async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert", "OK");
        }

        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Add?", "Would you like to add a button?", "Yes", "No");
            if (response == true)
            {
                Button n = new Button();
                Title.Children.Add(n);
                n.Text = "New button";
                n.Margin = 10;
                n.Padding = 10;
                n.CornerRadius = 20;
                n.Clicked += Go_Item;
            }
            else
            {
                await DisplayAlert("Alert", "Add button failed.", "OK");
            }
        }
        private void Add_button(object sender, EventArgs e)
        {
            Button n = new Button();
            Title.Children.Add(n);
            n.Text = "New button";
            n.Margin = 10;
            n.Padding = 10;
            n.CornerRadius = 20;
            n.Clicked += Go_Item;
        }

    }
}