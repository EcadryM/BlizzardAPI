using System.Collections.Generic;
using System.Numerics;

namespace BlizzardAPI.SC2.DataResources
{
    public class Category
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public BigInteger FeaturedAchievementId { get; set; }
        public List<Child> Children { get; set; }
    }
}
