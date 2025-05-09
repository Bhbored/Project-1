using Project_1.MVVM.View;
using Syncfusion.Licensing;

namespace Project_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SyncfusionLicenseProvider.RegisterLicense("MzgyMDY5OEAzMjM5MmUzMDJlMzAzYjMyMzkzYlRhcVAvMFNyaVBrTW5pdlBYSElRcVR0eVNia1BsVkpEeENvNlhVVDREN1E9");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new LPView()));
        }
    }
}