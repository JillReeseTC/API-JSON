using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace API_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This program requires the Newtonsoft.json NUGet package

            //Exercise 1

            var client = new HttpClient();
            var client2 = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";
            var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";


            for (var i = 0; i < 5; i++) {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var ronResponse = client2.GetStringAsync(ronSwansonURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine($" Kanye:  {kanyeQuote}");
                Console.WriteLine($" Ron  :  {ronQuote}");
            };

            //Exercise 2


            

        }
    }
}