using System.Numerics;

namespace BlizzardAPI.SC2.DataResources
{
    public class Skin
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public BigInteger Id { get; set; }
        public Icon Icon { get; set; }
        public BigInteger AchievementId { get; set; }
    }
}
