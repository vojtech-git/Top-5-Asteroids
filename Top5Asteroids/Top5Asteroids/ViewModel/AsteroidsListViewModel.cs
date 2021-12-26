using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Top5Asteroids.Model;
using Top5Asteroids.View;
using Xamarin.Forms;

namespace Top5Asteroids.ViewModel
{
    class AsteroidsListViewModel : BindableObject
    {
        public AsteroidsListViewModel()
        {
            Asteroids = new ObservableCollection<Asteroid>();

            SelectedDate = DateTime.Now;
        }

        
        public ObservableCollection<Asteroid> Asteroids { get; set; }

        private DateTime selectedDate;
        public DateTime SelectedDate 
        {
            get { return selectedDate; }
            set
            {
                if (value == selectedDate)
                    return;

                selectedDate = value;

                LoadAsteroidsIntoListView(selectedDate);

                OnPropertyChanged();
            }
        }


        public async void LoadAsteroidsIntoListView(DateTime date)
        {
            Asteroids.Clear();

            ApiResponseObject loadedAsteroids = await ApiProcessor.LoadAsteroids(date);
            
            foreach (Asteroid[] asteroids in loadedAsteroids.AsteroidsToDate.Values)
            {
                foreach (Asteroid asteroid in asteroids)
                {
                    this.Asteroids.Add(asteroid);
                }
            }
        }

        public ICommand OpenDetailsPageCommand => new Command(OpenDetailsPage);
        public async void OpenDetailsPage(object obj)
        {
            Asteroid asteroidClicked = obj as Asteroid;
            await App.Current.MainPage.Navigation.PushAsync(new DetailsPage(asteroidClicked));
        }

        public ICommand AddDayCommand => new Command(AddDay);
        public void AddDay()
        {
            SelectedDate = SelectedDate.AddDays(1);
        }

        public ICommand SubtractDayCommand => new Command(SubtractDay);
        public void SubtractDay()
        {
            SelectedDate = SelectedDate.AddDays(-1);
        }
    }
}