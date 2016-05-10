using System.Linq;
using JustEatTechTest.Core.Interfaces;
using JustEatTechTest.Core.Models;
using JustEatTechTest.Core.Services;
using JustEatTechTest.Core.WebApi;
using Xunit;

namespace JustEatTechTest.IntegrationTests
{
    public class RestaurantServiceIntegrationTests
    {
        [Fact]
        public void ValidCallToServiceReturnsRestaurants()
        {
            IJustEatWebApi justEatWebApi = new JustEatWebApi();
            IRestaurantService restaurantService = new RestaurantService(justEatWebApi);

            var response = restaurantService.GetRestaurantsForOutcode("RG1");

            Assert.False(response.Error);
            Assert.NotEmpty(response.Data);
        }


        [Fact]
        public void FirstRestaurantContainsAtLeastOneCuisine()
        {
            IJustEatWebApi justEatWebApi = new JustEatWebApi();
            IRestaurantService restaurantService = new RestaurantService(justEatWebApi);

            var response = restaurantService.GetRestaurantsForOutcode("RG1");
            JustEatRestaurant firstRestaurant = response.Data.First();

            Assert.False(response.Error);
            Assert.NotEmpty(firstRestaurant.CuisineTypes);
        }


        [Fact]
        public void InvalidCallToServiceReturnsNoRestaurants()
        {
            IJustEatWebApi justEatWebApi = new JustEatWebApi();
            IRestaurantService restaurantService = new RestaurantService(justEatWebApi);

            // Pass a "valid" yet non-existant outcode. Should pass validation, but return no restaurant data.
            var response = restaurantService.GetRestaurantsForOutcode("ZZ99");

            Assert.False(response.Error);
            Assert.Empty(response.Data);
        }
    }
}