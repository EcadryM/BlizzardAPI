﻿namespace WowAPI.Guild
{
    public class GroupTime
    {
        public long Time { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Milliseconds { get; set; }
        public bool IsPositive { get; set; }
    }
}
