using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUICustomHandlerSample
{
    // Shared code: method 3
    public partial class CustomButtonHandler
    {
        public static void Handle()
        {
            CustomHandle();
        }

        static partial void CustomHandle();
    }
}
