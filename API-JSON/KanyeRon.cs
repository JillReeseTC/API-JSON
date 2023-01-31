using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API_JSON
{
    static class KanyeRon
    {


        public static void KanyeRonResponses()
        {
            var client = new HttpClient();
            var client2 = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";
            var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";


            for (var i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var ronResponse = client2.GetStringAsync(ronSwansonURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine($" Kanye:  {kanyeQuote}");
                Console.WriteLine($" Ron  :  {ronQuote}");
            };
        }

    }
}
