using System.Collections.Generic;
using JustEatTechTest.Core.Models;

namespace JustEatTechTest.UnitTests
{
    public static class TestData
    {
        public static List<JustEatRestaurant> Restaurants
        {
            get
            {
                return new List<JustEatRestaurant>
                {
                    new JustEatRestaurant { Id = 1, Name = "Wok on Wheels", RatingAverage = 5},
                    new JustEatRestaurant { Id = 2, Name = "Papa John's", RatingAverage = 4}
                };
            }
        }
        
    }
}