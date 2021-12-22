using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Top5Asteroids.Model
{

    public class AsteroidsOfDay
    {
        static Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");

        public Asteroid[] Asteroids { get; set; }
    }
}
