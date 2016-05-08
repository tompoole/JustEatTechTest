using System.Collections.Generic;

namespace JustEatTechTest.Core.Models
{
    public class JustEatRestaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RatingAverage { get; set; }

        public List<JustEatCusineType> CusineTypes { get; set; }
    }
}