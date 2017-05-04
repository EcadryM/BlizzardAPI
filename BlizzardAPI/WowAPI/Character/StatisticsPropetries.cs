using System.Collections.Generic;

namespace WowAPI.Character
{
    public class StatisticsPropetries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
