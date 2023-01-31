using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace API_JSON
{
    public class WeatherGetter
    {
        public string weatherURL { get; set; } = "https://api.openweathermap.org/data/2.5/weather";

        public static string GetAPIKey()
        {
            Console.WriteLine("Please enter your API Key for OpenWeatherMap.org:  ");
            string apiKey = Console.ReadLine();
            Console.WriteLine($"Your API Key entered was: {apiKey}");

            return apiKey;
        }

        public static string GetLocation()
        {
            Console.WriteLine("Enter City in the United States: ");
            string city = Console.ReadLine();
 
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();

            return city + "," + state;
        }

        public void  ShowWeather()
        {

        }





    }
}
