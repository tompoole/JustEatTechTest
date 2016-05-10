using System.Collections.Generic;
using JustEatTechTest.Core.Models;

namespace JustEatTechTest.Core.Interfaces
{
    public interface IRestaurantService
    {
        ServiceResponse<List<JustEatRestaurant>> GetRestaurantsForOutcode(string outcode);
    }
}