using JustEatTechTest.Core.Interfaces;
using JustEatTechTest.Core.Services;
using Moq;
using Xunit;

namespace JustEatTechTest.UnitTests
{
    public class RestaurantServiceTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void EmptyOutcodeShouldReturnError(string outcode)
        {
            IJustEatWebApi justEatWebApi = new Mock<IJustEatWebApi>().Object;
            IRestaurantService restaurantService = new RestaurantService(justEatWebApi);

            var result = restaurantService.GetRestaurantsForOutcode(outcode);

            Assert.True(result.Error);
        }

        [Theory]
        [InlineData("124")]
        [InlineData("ABC")]
        [InlineData("Wibble")]
        [InlineData(" 11 ")]
        [InlineData("RG111")]
        [InlineData("RGG1")]
        public void InvalidOutcodesReturnsError(string outcode)
        {
            IJustEatWebApi justEatWebApi = new Mock<IJustEatWebApi>().Object;
            IRestaurantService restaurantService = new RestaurantService(justEatWebApi);

            var result = restaurantService.GetRestaurantsForOutcode(outcode);

            Assert.True(result.Error);
        }

        [Theory]
        [InlineData("RG1")]
        [InlineData("W1")]
        [InlineData("SN12")]
        [InlineData(" RG1")]
        [InlineData("RG1 ")]
        public void ValidOutcodesShouldReturnSuccess(string outcode)
        {
            IJustEatWebApi justEatWebApi = new Mock<IJustEatWebApi>().Object;
            IRestaurantService restaurantService = new RestaurantService(justEatWebApi);

            var result = restaurantService.GetRestaurantsForOutcode(outcode);

            Assert.False(result.Error);

        }
    }
}