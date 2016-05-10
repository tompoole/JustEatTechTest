using System.Collections.Generic;

namespace JustEatTechTest.Core.Models
{
    public class JustEatRestaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RatingStars { get; set; }

        public List<JustEatCuisineType> CuisineTypes { get; set; }
    }
}