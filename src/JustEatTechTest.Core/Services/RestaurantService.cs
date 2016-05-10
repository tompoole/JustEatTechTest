using System.Collections.Generic;
using System.Text.RegularExpressions;
using JustEatTechTest.Core.Interfaces;
using JustEatTechTest.Core.Models;
using static JustEatTechTest.Core.ServiceResponse<System.Collections.Generic.List<JustEatTechTest.Core.Models.JustEatRestaurant>>;

namespace JustEatTechTest.Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        public ServiceResponse<List<JustEatRestaurant>> GetRestaurantsForOutcode(string outcode)
        {
            return CreateSuccess(new List<JustEatRestaurant>());
        }

        private bool IsValidOutcode(string outcode)
        {
            if (string.IsNullOrEmpty(outcode))
            {
                return false;
            }

            Regex.IsMatch()
            
        }
    }
}