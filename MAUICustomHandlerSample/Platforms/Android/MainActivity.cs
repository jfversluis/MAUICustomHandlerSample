using Android.App;
using Android.Content.PM;
using Microsoft.Maui;

namespace MAUICustomHandlerSample
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class MainActivity : MauiAppCompatActivity
	{
		public MainActivity()
        {
            // Method 2
            //Microsoft.Maui.Handlers.ButtonHandler.ButtonMapper["MyCustomization"] = (handler, view) =>
            //{
            //    handler.NativeView.SetBackgroundColor(Android.Graphics.Color.White);
            //};
        }
	}
}