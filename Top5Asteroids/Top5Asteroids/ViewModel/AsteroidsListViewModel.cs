using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Top5Asteroids.Model;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;

namespace Top5Asteroids.ViewModel
{
    class AsteroidsListViewModel
    {
        public ObservableCollection<Asteroid> asteroids;

        public AsteroidsListViewModel()
        {
            asteroids = new ObservableCollection<Asteroid>();
        }

        public ICommand LoadAsteroidsCommand => new Command(LoadAsteroids);
        async void LoadAsteroids()
        {
            var loadedAsteroids = await ApiProcessor.LoadAsteroids(DateTime.Now, DateTime.Now);
            
            foreach (Asteroid asteroid in loadedAsteroids.Near_earth_objects.Asteroids)
            {
                asteroids.Add(asteroid);
            }
        }
    }
}
