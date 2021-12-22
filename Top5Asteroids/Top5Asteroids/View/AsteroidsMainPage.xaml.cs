using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top5Asteroids.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Top5Asteroids.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsteroidsMainPage : ContentPage
    {
        public AsteroidsMainPage()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            await LoadApod();
        }

        private async Task LoadApod()
        {
            var apod = await ApiProcessor.LoadApod();

            BackgroundImageSource = apod.Url;
        }

    }
}