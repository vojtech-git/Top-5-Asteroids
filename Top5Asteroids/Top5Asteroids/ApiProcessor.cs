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

        public static async Task<ApiResponseObject> LoadAsteroids(DateTime startDate)
        {
            string url = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={startDate.Year}-{startDate.Month}-{startDate.Day}&end_date={startDate.Year}-{startDate.Month}-{startDate.Day}&detailed=false&api_key={key}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ApiResponseObject asteroids = await response.Content.ReadAsAsync<ApiResponseObject>();

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
