using System.Collections;
using System.Collections.Generic;
using JustEatTechTest.Core.Models;

namespace JustEatTechTest.Core.Interfaces
{
    public interface IJustEatWebApi
    {
        IList<JustEatRestaurant> GetRestaurantsFromOutcode(string outcode);
    }
}