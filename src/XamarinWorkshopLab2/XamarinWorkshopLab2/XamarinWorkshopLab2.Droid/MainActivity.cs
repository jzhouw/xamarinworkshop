using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinWorkshopLab1.Droid
{
	[Activity (Label = "XamarinWorkshopLab2.Droid", MainLauncher = true, Icon = "@drawable/icon")]
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
                XamarinWorkshopLab2.MyClass myClass = new XamarinWorkshopLab2.MyClass();

                TextView tvWeather = FindViewById<TextView>(Resource.Id.weather);
                tvWeather.Text = await myClass.GetWeather();

                TextView tvDevice = FindViewById<TextView>(Resource.Id.myDevice);
                //tvDevice.Text = $"{Android.OS.Build.Brand} {Android.OS.Build.Model}";//android native相关的代码，不能放在PCL中
                tvDevice.Text = myClass.GetDevice();
            };
        }
	}
}


