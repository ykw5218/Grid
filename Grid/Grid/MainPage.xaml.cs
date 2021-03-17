using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grid
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new Page1());
        }
    }
}
