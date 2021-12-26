using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Top5Asteroids.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsteroidsListPage : ContentPage
    {
        public AsteroidsListPage()
        {
            InitializeComponent();

            LoadApodIntoBackground();
        }

        public async void LoadApodIntoBackground()
        {
            var apod = await ApiProcessor.LoadApod();

            BackgroundImageSource = apod.Url;
        }
    }
}