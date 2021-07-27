using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace MAUICustomHandlerSample
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			// Method 1
			//#if __ANDROID__
			//			Microsoft.Maui.Handlers.ButtonHandler.ButtonMapper["MyCustomization"] = (handler, view) =>
			//			{
			//				handler.NativeView.SetBackgroundColor(Android.Graphics.Color.Green);
			//			};
			//#endif

			// Method 3
			CustomButtonHandler.Handle();
		}
	}
}