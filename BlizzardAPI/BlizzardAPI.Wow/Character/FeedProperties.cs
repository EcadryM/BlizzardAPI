using System.Collections.Generic;

namespace BlizzardAPI.Wow.Character
{
    public class FeedProperties
    {
        public string Type { get; set; }
        public object Timestamp { get; set; }
        public Achievement Achievement { get; set; }
        public bool FeatOfStrength { get; set; }
        public int? ItemId { get; set; }
        public string Context { get; set; }
        public List<object> BonusLists { get; set; }
        public Criteria Criteria { get; set; }
        public int? Quantity { get; set; }
        public string Name { get; set; }
    }
}
