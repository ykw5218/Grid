using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page8 : ContentPage
    {
        public Page8()
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

        private async void Change_style_to_medium(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Let me help you:", "Add: Click ADD will create a new button linked to the item page.\n\nHelp: Click HELP will give you instructions.\n\nStyle: Click STYLE will change the size of grid to MEDIUM.\n\nTitle: Click title buttons below will jump to the item page.", "Get It!");
        }

        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Add?", "Would you like to add a button?", "Yes", "No");
            if (response == true)
            {
                Button n = new Button();
                Title_small.Children.Add(n);
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
            Title_small.Children.Add(n);
            n.Text = "New button";
            n.Margin = 10;
            n.Padding = 10;
            n.CornerRadius = 20;
            n.Clicked += Go_Item;
        }
    }
}