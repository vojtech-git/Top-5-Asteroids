using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace Top5Asteroids.Model
{
    public class Asteroid
    {
        public string Name { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public float AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public EstimatedDiameter DiameterInfo { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsHazardous { get; set; }

        [JsonProperty("close_approach_data")]
        public CloseApproachData[] CloseApproachData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }

    public class EstimatedDiameter
    {
        [JsonProperty("kilometers")]
        public MinMaxEstimate InKilometers { get; set; }

        [JsonProperty("meters")]
        public MinMaxEstimate InMeters { get; set; }

        [JsonProperty("miles")]
        public MinMaxEstimate InMiles { get; set; }

        [JsonProperty("feet")]
        public MinMaxEstimate InFeet { get; set; }
    }

    public class MinMaxEstimate
    {
        [JsonProperty("estimated_diameter_min")]
        public float MinimalEstimate { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public float MaximalEstimate { get; set; }
    }

    public class CloseApproachData
    {
        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("relative_velocity")]
        public RelativeVelocityData RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public MissDistanceData MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }

    public class RelativeVelocityData
    {
        [JsonProperty("kilometers_per_second")]
        public float InKilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public float InKilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public float InMileshPerHour { get; set; }
    }

    public class MissDistanceData
    {
        [JsonProperty("astronomical")]
        public float InAstronomical { get; set; }

        [JsonProperty("lunar")]
        public float InLunar { get; set; }

        [JsonProperty("kilometers")]
        public float InKilometers { get; set; }

        [JsonProperty("miles")]
        public float InMiles { get; set; }
    }
}