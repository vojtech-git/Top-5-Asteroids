using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Top5Asteroids.Model;
using System.Globalization;

namespace Top5Asteroids.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public Asteroid RecievedAsteroid { get; set; }
        public List<Grid> ApproachDataGrids { get; set; }

        Dictionary<int, CloseApproachData> indexToCloseApproach;

        public DetailsPage(Asteroid asteroid)
        {
            InitializeComponent();

            RecievedAsteroid = asteroid;

            Title = RecievedAsteroid.Name;

            if (RecievedAsteroid.AbsoluteMagnitude == 0)
            {
                AbsoluteMagnitudeLabel.Text = "?";
            }
            else
            {
                AbsoluteMagnitudeLabel.Text = RecievedAsteroid.AbsoluteMagnitude.ToString();
            }

            if (RecievedAsteroid.IsHazardous) IsHazardousLabel.Text = "Yes";
            else IsHazardousLabel.Text = "No";

            if (RecievedAsteroid.IsSentryObject) IsSentryLabel.Text = "Yes";
            else IsSentryLabel.Text = "No";

            DiameterPicker.SelectedIndex = 0; // tohle setne index na nulu a tim padem i nastavi text do respective label

            // indexToCloseApproach - Dic který naplním podle toho kolík má asteroid instancí přiblížení se k zemi
            // + jsem si vytvořil List<string> abych mohl naplnit picker příslušnými stringy na vybíraní
            #region closeApproachPicker population logic
            indexToCloseApproach = new Dictionary<int, CloseApproachData>();
            for (int i = 0; i < RecievedAsteroid.CloseApproachData.Length; i++)
            {
                indexToCloseApproach.Add(i, RecievedAsteroid.CloseApproachData[i]);
            }

            List<string> stringsForApproachesPicker = new List<string>();
            for (int i = 0; i < RecievedAsteroid.CloseApproachData.Length; i++)
            {
                stringsForApproachesPicker.Add($"Approach {i + 1}");
            }
            AproachesPicker.ItemsSource = stringsForApproachesPicker;

            AproachesPicker.SelectedIndex = 0;
            #endregion

            RelativeVelocityPicker.SelectedIndex = 0; // stejna logika jako u DiameterPickeru
            MissDistancePicker.SelectedIndex = 0;
        }

        private void AproachesPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = AproachesPicker.SelectedIndex;

            ApproachDateLabel.Text = indexToCloseApproach[selectedIndex].CloseApproachDateFull;
            OrbitingBodyLabel.Text = indexToCloseApproach[selectedIndex].OrbitingBody;
        }

        private void RelativeVelocityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RelativeVelocityPicker.SelectedIndex == 0)
            {
                RelativeVelocityLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].RelativeVelocity.InKilometersPerHour.ToString("N2");
            }
            if (RelativeVelocityPicker.SelectedIndex == 1)
            {
                RelativeVelocityLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].RelativeVelocity.InKilometersPerSecond.ToString("N2");
            }
            if (RelativeVelocityPicker.SelectedIndex == 2)
            {
                RelativeVelocityLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].RelativeVelocity.InMileshPerHour.ToString("N2");
            }
        }
        private void MissDistancePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MissDistancePicker.SelectedIndex == 0)
            {
                MissDistanceLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].MissDistance.InAstronomical.ToString("N2");
            }
            if (MissDistancePicker.SelectedIndex == 1)
            {
                MissDistanceLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].MissDistance.InLunar.ToString("N2");
            }
            if (MissDistancePicker.SelectedIndex == 2)
            {
                MissDistanceLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].MissDistance.InKilometers.ToString("N0");
            }
            if (MissDistancePicker.SelectedIndex == 3)
            {
                MissDistanceLabel.Text = indexToCloseApproach[AproachesPicker.SelectedIndex].MissDistance.InMiles.ToString("N0");
            }

            
        }

        private void DiameterPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiameterPicker.SelectedIndex == 0)
            {
                DiameterLabel.Text = RecievedAsteroid.DiameterInfo.InKilometers.MinimalEstimate.ToString("N2") + " - " + RecievedAsteroid.DiameterInfo.InKilometers.MaximalEstimate.ToString("N2");
            }
            else if (DiameterPicker.SelectedIndex == 1)
            {
                DiameterLabel.Text = RecievedAsteroid.DiameterInfo.InMeters.MinimalEstimate.ToString("N2") + " - " + RecievedAsteroid.DiameterInfo.InMeters.MaximalEstimate.ToString("N2");
            }
            else if (DiameterPicker.SelectedIndex == 2)
            {
                DiameterLabel.Text = RecievedAsteroid.DiameterInfo.InMiles.MinimalEstimate.ToString("N2") + " - " + RecievedAsteroid.DiameterInfo.InMiles.MaximalEstimate.ToString("N2");
            }
            else if (DiameterPicker.SelectedIndex == 3)
            {
                DiameterLabel.Text = RecievedAsteroid.DiameterInfo.InFeet.MinimalEstimate.ToString("N2") + " - " + RecievedAsteroid.DiameterInfo.InFeet.MaximalEstimate.ToString("N2");
            }
        }
    }
}