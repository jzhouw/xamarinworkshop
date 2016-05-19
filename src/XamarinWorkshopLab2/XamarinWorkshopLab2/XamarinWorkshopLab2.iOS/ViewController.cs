using System;

using UIKit;


namespace XamarinWorkshopLab1.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";

			Button.TouchUpInside += async delegate {

                XamarinWorkshopLab2.MyClass myClass = new XamarinWorkshopLab2.MyClass();
                LabelWeather.Text = await myClass.GetWeather();
                //LabelDevice.Text = $"{UIKit.UIDevice.CurrentDevice.Name} {UIKit.UIDevice.CurrentDevice.Model}";//ios native相关的代码，不能放在PCL中
                LabelDevice.Text = myClass.GetDevice();
            };

        }

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

