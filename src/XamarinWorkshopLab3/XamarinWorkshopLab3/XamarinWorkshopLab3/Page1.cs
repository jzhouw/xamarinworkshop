using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinWorkshopLab3
{
	public class Page1 : ContentPage
	{
		public Page1 ()
		{

            Xamarin.Forms.Label label = new Xamarin.Forms.Label { Text = "选择城市" };
            Picker cityPicker = new Picker();
            cityPicker.Items.Add("Beijing");
            cityPicker.Items.Add("Shanghai");

            Button button = new Button { Text = "获取" };

            Xamarin.Forms.Label lblWeather = new Xamarin.Forms.Label { Text = "当前天气" };
            Xamarin.Forms.Label lblDevice = new Xamarin.Forms.Label { Text = "设备信息" };

            button.Clicked += async delegate
            {
                MyClass myClass = new MyClass();
                lblWeather.Text = await myClass.GetWeather(cityPicker.Items[cityPicker.SelectedIndex]);
                lblDevice.Text = myClass.GetDevice();
            };
            

			Content = new StackLayout { Padding = 20,
				Children = {
                    label,
                    cityPicker,
                    button ,
                    lblWeather,
                    lblDevice
                }
			};
		}
	}
}
