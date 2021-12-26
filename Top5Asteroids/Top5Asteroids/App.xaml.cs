using System;
using Top5Asteroids.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using Top5Asteroids.Model;

namespace Top5Asteroids
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ApiHelper.InitializeClient();

            MainPage = new NavigationPage(new AsteroidsListPage());
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
