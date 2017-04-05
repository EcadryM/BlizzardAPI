﻿namespace WowAPI.PvP
{
    public class LeaderboardRow
    {
        public int Ranking { get; set; }
        public int Rating { get; set; }
        public int RealmId { get; set; }
        public int RaceId { get; set; }
        public int ClassId { get; set; }
        public int SpecId { get; set; }
        public int FactionId { get; set; }
        public int GenderId { get; set; }
        public int SeasonWins { get; set; }
        public int SeasonLosses { get; set; }
        public int WeeklyWins { get; set; }
        public int WeeklyLosses { get; set; }

        public string Name { get; set; }
        public string RealmName { get; set; }
        public string RealmSlug { get; set; }
    }
}
