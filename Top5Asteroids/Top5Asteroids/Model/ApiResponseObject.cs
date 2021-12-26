using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Top5Asteroids.Model
{
    public class ApiResponseObject
    {
        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("element_count")]
        public int ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public Dictionary<string, Asteroid[]> AsteroidsToDate { get; set; }
    }

    public class Links
    {
        public string Prev { get; set; }
        public string Self { get; set; }
        public string Next { get; set; }
    }
}
