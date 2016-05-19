using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinWorkshopLab1.Droid
{
	[Activity (Label = "XamarinWorkshopLab1.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += async delegate {
                MyClass myClass = new MyClass();

                TextView tvWeather = FindViewById<TextView>(Resource.Id.weather);
                tvWeather.Text = await myClass.GetWeather();

                TextView tvDevice = FindViewById<TextView>(Resource.Id.myDevice);
                tvDevice.Text = myClass.GetDevice();
			};
        }
	}
}


