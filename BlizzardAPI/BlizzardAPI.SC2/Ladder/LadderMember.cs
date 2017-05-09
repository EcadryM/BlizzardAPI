namespace BlizzardAPI.SC2.Ladder
{
    public class LadderMember
    {
        public Character Character { get; set; }
        public int JoinTimestamp { get; set; }
        public double Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int HighestRank { get; set; }
        public int PreviousRank { get; set; }
        public string FavoriteRaceP1 { get; set; }
    }
}
