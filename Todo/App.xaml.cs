using Xamarin.Forms;
using NCMBClient;

namespace Todo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            new NCMB("9170ffcb91da1bbe0eff808a967e12ce081ae9e3262ad3e5c3cac0d9e54ad941", "9e5014cd2d76a73b4596deffdc6ec4028cfc1373529325f8e71b7a6ed553157d");

            MainPage = new NavigationPage(new TodoListPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"]
            };
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

