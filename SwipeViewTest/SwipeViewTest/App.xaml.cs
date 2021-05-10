using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace SwipeViewTest
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Scrollview());
            //MainPage = new Scrollview();

            //MainPage = new Benefits();
            Xamarin.Forms.TabbedPage tabbedPage = new Xamarin.Forms.TabbedPage();

            tabbedPage.On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            tabbedPage.BarBackgroundColor = Color.FromHex("#00569d");

            tabbedPage.Children.Add(new NavigationPage(new Scrollview()) { Title = "Nyheter" });
            tabbedPage.Children.Add(new Login() { Title = "Logga in"});
            

            MainPage = tabbedPage;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
