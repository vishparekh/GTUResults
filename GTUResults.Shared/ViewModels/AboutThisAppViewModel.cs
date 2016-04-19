using System;

using Windows.ApplicationModel;

namespace GTUResults.ViewModels
{
    public class AboutThisAppViewModel
    {
        public string Publisher
        {
            get
            {
                return "Vishal Parekh";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "This is not the official application of GTU. It is our sincere effort to help you" +
    ".";
            }
        }
    }
}

