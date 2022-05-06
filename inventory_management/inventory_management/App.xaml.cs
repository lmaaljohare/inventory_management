using inventory_management.Views;
using Xamarin.Forms;

namespace inventory_management
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new ShowProduct());

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
