using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Top5Asteroids.Model;

namespace Top5Asteroids
{
    public class ApiProcessor
    {
        static string key = "7tJ7YsQKZ3KsOMhGNGWAOD3WyOWBhP1T2VFNz5Le";

        public static async Task<AstronomyPicture> LoadApod()
        {
            string url = $"https://api.nasa.gov/planetary/apod?api_key={key}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    AstronomyPicture apod = await response.Content.ReadAsAsync<AstronomyPicture>();

                    return apod;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<AsteroidsToDate> LoadAsteroids(DateTime startDate, DateTime endDate)
        {
            string url = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={startDate.Year}-{startDate.Month}-{startDate.Day}&end_date={endDate.Year}-{endDate.Month}-{endDate.Day}&detailed=false&api_key={key}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Trying to get data from: " + url);

                    AsteroidsToDate asteroids = await response.Content.ReadAsAsync<AsteroidsToDate>();

                    Console.WriteLine("response = " + asteroids);

                    return asteroids;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
