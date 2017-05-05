namespace BlizzardAPI.Wow.Guild
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool HasChallengeMode { get; set; }
        public BronzeCriteria BronzeCriteria { get; set; }
        public SilverCriteria SilverCriteria { get; set; }
        public GoldCriteria GoldCriteria { get; set; }
    }
}
