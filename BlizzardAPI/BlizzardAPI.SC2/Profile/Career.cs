namespace BlizzardAPI.SC2.Profile
{
    public class Career
    {
        public string PrimaryRace { get; set; }
        public int TerranWins { get; set; }
        public int ProtossWins { get; set; }
        public int ZergWins { get; set; }
        public string Highest1v1Rank { get; set; }
        public string HighestTeamRank { get; set; }
        public int SeasonTotalGames { get; set; }
        public int CareerTotalGames { get; set; }
    }
}
