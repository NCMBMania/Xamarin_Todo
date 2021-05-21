using Xamarin.Forms;
using NCMBClient;

namespace Todo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            new NCMB("YOUR_APPLICATION_KEY", "YOUR_CLIENT_KEY");

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

