using System.Collections.Generic;
using System.Net;
using JustEatTechTest.Core.Interfaces;
using JustEatTechTest.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JustEatTechTest.Core.WebApi
{
    public class JustEatWebApi : IJustEatWebApi
    {
        public List<JustEatRestaurant> GetRestaurantsFromOutcode(string outcode)
        {
            using (WebClient client = new WebClient())
            {
                client.BaseAddress = "https://public.je-apis.com";
                client.Headers.Add("Accept-Tenant" , "uk");
                client.Headers.Add("Accept-Language", "en-GB");

                // This probably should be loaded from config, rather than being hardcoded.// This probably should be loaded from config, rather than being hardcoded.
                client.Headers.Add("Authorization", "Basic VGVjaFRlc3RBUEk6dXNlcjI="); 

                string response = client.DownloadString($"/restaurants?q={outcode}");

                JToken jsonObject = JsonConvert.DeserializeObject<JToken>(response);
                List<JustEatRestaurant> restaurants = jsonObject["Restaurants"].ToObject<List<JustEatRestaurant>>();

                return restaurants;
            }
        }
    }
}