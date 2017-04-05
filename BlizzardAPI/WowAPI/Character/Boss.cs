namespace WowAPI.Character
{
    public class Boss
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public int? NormalKills { get; set; }
        public int? NormalTimestamp { get; set; }
        public int? HeroicKills { get; set; }
        public int? HeroicTimestamp { get; set; }
    }
}
