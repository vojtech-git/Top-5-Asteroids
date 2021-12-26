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
    }
}