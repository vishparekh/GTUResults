using System;
using AppStudio.Data;

namespace GTUResults.ViewModels
{
    public class PrivacyViewModel : BindableBase
    {
        public Uri Url
        {
            get
            {
                return new Uri(UrlText, UriKind.RelativeOrAbsolute);
            }
        }
        public string UrlText
        {
            get
            {
                return "http://appstudio.windows.com/home/appprivacyterms";
            }
        }
    }
}

