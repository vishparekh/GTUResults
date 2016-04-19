using Windows.UI.Xaml.Controls;
using GTUResults.ViewModels;

namespace GTUResults.Views
{
    public sealed partial class AboutFlyout : SettingsFlyout
    {
        public AboutFlyout()
        {
            this.InitializeComponent();
            AboutThisAppModel = new AboutThisAppViewModel();
            this.DataContext = this;
        }

        public AboutThisAppViewModel AboutThisAppModel { get; private set; }
    }
}
