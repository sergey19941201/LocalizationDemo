using System.Reflection;
using System.Globalization;
using System.Resources;
using LocalizationDemo.Resources;

namespace LocalizationDemo
{
    public static class TranslationHelper
    {
        public static string GetString(string key, CultureInfo ci)
        {
            ResourceManager temp = new ResourceManager(
                "LocalizationDemo.Resources.AppResources", 
                typeof(AppResources).GetTypeInfo().Assembly);
            string result = temp.GetString(key, ci);
            return result;
        }
    }
}
