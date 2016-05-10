using System.Collections.Generic;
using System.Text.RegularExpressions;
using JustEatTechTest.Core.Interfaces;
using JustEatTechTest.Core.Models;
using static JustEatTechTest.Core.ServiceResponse<System.Collections.Generic.List<JustEatTechTest.Core.Models.JustEatRestaurant>>;

namespace JustEatTechTest.Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IJustEatWebApi _justEatWebApi;

        public RestaurantService(IJustEatWebApi justEatWebApi)
        {
            _justEatWebApi = justEatWebApi;
        }

        public ServiceResponse<List<JustEatRestaurant>> GetRestaurantsForOutcode(string outcode)
        {
            if (IsValidOutcode(outcode) == false)
            {
                return CreateFailure($"Outcode \"{outcode}\" is not valid.");
            }

            List<JustEatRestaurant> restaurants = _justEatWebApi.GetRestaurantsFromOutcode(outcode);

            return CreateSuccess(restaurants);
        }

        private bool IsValidOutcode(string outcode)
        {
            outcode = outcode?.Trim() ?? string.Empty;

            return Regex.IsMatch(outcode, "^[a-z]{1,2}[0-9]{1,2}$", RegexOptions.IgnoreCase);
        }
    }
}