﻿namespace BlizzardAPI.Wow.Character
{
    public class Bracket
    {
        public string Slug { get; set; }

        public int Rating { get; set; }
        public int WeeklyPlayed { get; set; }
        public int WeeklyWon { get; set; }
        public int WeeklyLost { get; set; }
        public int SeasonPlayed { get; set; }
        public int SeasonWon { get; set; }
        public int SeasonLost { get; set; }
    }
}
