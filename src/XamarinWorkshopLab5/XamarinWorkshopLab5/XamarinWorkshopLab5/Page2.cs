using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinWorkshopLab5
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            Button button = new Button { Text = "Back" };
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 2" },
                    button
                }
            };

            button.Clicked += delegate
            {
                Navigation.PopAsync();
            };
        }
    }
}
