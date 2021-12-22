using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace Top5Asteroids.Model
{
    public class Asteroid
    {
        public string Name { get; set; }

        [JsonProperty("absolute_magnitute_h")]
        public float AbsoluteMagnitude { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsHazardous { get; set; }

        public Dictionary<string, Asteroid[]> AsteroidsToDate { get; set; }
    }

    public class AsteroidData
    {
        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("miss_distance")]
        public AsteroidMissDistance MissDistance { get; set; }

    }

    public class AsteroidMissDistance
    {
        public string Astronomical { get; set; }
        public string Kilometers { get; set; }
    }
}
