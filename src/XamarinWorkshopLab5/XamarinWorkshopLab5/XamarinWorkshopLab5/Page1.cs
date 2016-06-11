using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinWorkshopLab5
{
    public class Page1:ContentPage
    {
        public Page1()
        {
            Button button = new Button { Text = "Go to Page 2" };
            
            this.Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Page 1" },  
                    button
                }
            };

            button.Clicked += delegate
            {
                Navigation.PushAsync(new Page2());
            };
        }

    }
}
