using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using JustEatTechTest.Core.Interfaces;

namespace JustEatTechTest.Web.Controllers
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public HttpResponseMessage Get(string outcode)
        {
            var serviceResponse = _restaurantService.GetRestaurantsForOutcode(outcode);

            HttpStatusCode statusCode = serviceResponse.Error ? HttpStatusCode.BadRequest : HttpStatusCode.OK;
            return Request.CreateResponse(statusCode, serviceResponse);
        }
    }
}