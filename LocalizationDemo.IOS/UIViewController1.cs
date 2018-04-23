using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using LocalizationDemo;

namespace LocalizationDemo.IOS
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }

    [Register("UIViewController1")]
    public class UIViewController1 : UIViewController
    {
        public UIViewController1()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }


        //LOCALIZATON
        public override void ViewDidLoad()
        {
            View = new UniversalView();

            base.ViewDidLoad();

            
            var ci = GetCurrentCultureInfo();
            //Hello is key declared in PCL in AppReources.resx and AppResources.ru.resx
            var hello = LocalizationDemo.TranslationHelper.GetString("Hello", ci);
        }
        private System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var netLanguage = "en";
            if(NSLocale.PreferredLanguages.Length>0)
            {
                var pref = NSLocale.PreferredLanguages[0];
                netLanguage = pref.Replace("_", "-");
            }
            return new System.Globalization.CultureInfo(netLanguage);
        }
        //LOCALIZATON ENDED
    }
}