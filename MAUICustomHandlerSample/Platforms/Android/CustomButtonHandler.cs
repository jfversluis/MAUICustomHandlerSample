using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUICustomHandlerSample
{
    // Android: method 3
    public partial class CustomButtonHandler
    {
        static partial void CustomHandle()
        {
            Microsoft.Maui.Handlers.ButtonHandler.ButtonMapper["MyCustomization"] = (handler, view) =>
            {
                handler.NativeView.SetBackgroundColor(Android.Graphics.Color.Yellow);
            };
        }
    }
}
