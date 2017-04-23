using System.Collections.Generic;

namespace WowAPI.Guild
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public List<long> RewardItems { get; set; }
        public string Icon { get; set; }
        public List<Criterion> Criteria { get; set; } = new List<Criterion>();
        public bool AccountWide { get; set; }
        public int? FactionId { get; set; }
    }
}
