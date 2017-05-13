using System.Numerics;

namespace BlizzardAPI.SC2.DataResources
{
    public class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public BigInteger AchievementId { get; set; }
        public int CategoryId { get; set; }
        public int Points { get; set; }
        public Icon Icon { get; set; }
    }
}
