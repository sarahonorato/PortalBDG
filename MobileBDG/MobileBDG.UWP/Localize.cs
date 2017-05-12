using System;
using System.Globalization;
using System.Threading;

[assembly:Xamarin.Forms.Dependency(typeof(MobileBDG.UWP.Localize))]

namespace MobileBDG.UWP
{
    public class Localize : MobileBDG.ILocalize
    {
        public void SetLocale(CultureInfo ci) { }
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            return CultureInfo.CurrentCulture;
        }
    }
}
