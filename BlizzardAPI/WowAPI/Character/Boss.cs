namespace WowAPI.Character
{
    public class Boss
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public long? NormalKills { get; set; }
        public long? NormalTimestamp { get; set; }
        public long? HeroicKills { get; set; }
        public long? HeroicTimestamp { get; set; }
    }
}
