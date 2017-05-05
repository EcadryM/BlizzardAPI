using System.Collections.Generic;

namespace BlizzardAPI.Wow.Character
{
    public class StatisticsPropetries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
