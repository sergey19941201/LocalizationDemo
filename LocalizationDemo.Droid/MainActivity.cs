using Android.App;
using Android.Widget;
using Android.OS;
using LocalizationDemo;
using System;

namespace LocalizationDemo.Droid
{
    [Activity(Label = "LocalizationDemo.Droid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //LOCALIZATON
            var ci = GetCurrentCultureInfo();
            //Hello is key declared in PCL in AppReources.resx and AppResources.ru.resx
            var d = LocalizationDemo.TranslationHelper.GetString("Hello", ci);
            Toast.MakeText(this, d.ToString(), ToastLength.Long).Show();
        }

        private System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_","-");
            return new System.Globalization.CultureInfo(netLanguage);
        }
        //LOCALIZATON ENDED
    }
}

