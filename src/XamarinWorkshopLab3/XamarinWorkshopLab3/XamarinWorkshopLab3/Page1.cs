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
            Button button = new Button { Text = "获取" };
            Xamarin.Forms.Label lblWeather = new Xamarin.Forms.Label { Text = "当前天气" };
            Xamarin.Forms.Label lblDevice = new Xamarin.Forms.Label { Text = "设备信息" };

            button.Clicked += async delegate
            {
                MyClass myClass = new MyClass();
                lblWeather.Text = await myClass.GetWeather();
                lblDevice.Text = myClass.GetDevice();
            };
            

			Content = new StackLayout {
				Children = {
                    button ,
                    lblWeather,
                    lblDevice
                }
			};
		}
	}
}
