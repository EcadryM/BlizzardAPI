namespace BlizzardAPI.SC2.Profile
{
    public class Ladder
    {
        public string LadderName { get; set; }
        public int LadderId { get; set; }
        public int Division { get; set; }
        public int Rank { get; set; }
        public string League { get; set; }
        public string MatchMakingQueue { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public bool Showcase { get; set; }
    }
}
