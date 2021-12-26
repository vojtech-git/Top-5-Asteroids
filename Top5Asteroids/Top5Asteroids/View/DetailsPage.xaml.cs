using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Top5Asteroids.Model;

namespace Top5Asteroids.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Asteroid asteroid)
        {
            InitializeComponent();

            Title = asteroid.Name;

            HazardousLabel.Text = $"Is Hazardous: " + asteroid.IsHazardous;
        }
    }
}