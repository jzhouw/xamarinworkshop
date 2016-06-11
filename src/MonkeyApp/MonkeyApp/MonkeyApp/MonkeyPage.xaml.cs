using MonkeyApp.Model;
using MonkeyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MonkeyApp
{
    public partial class MonkeyPage : ContentPage
    {
        public MonkeyPage(Monkey monkey)
        {
            InitializeComponent();

            BindingContext = new MonkeyViewModel(monkey);
        }

        public void ButtonDismiss_Clicked(object sender, EventArgs args)
        {
            Navigation.PopAsync(true);
        }
    }
}
