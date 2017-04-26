using System.Collections.Generic;

namespace WowAPI.Guild
{
    public class Group
    {
        public int Ranking { get; set; }
        public GroupTime Time { get; set; }
        public string Date { get; set; } 
        public string Fanction { get; set; }
        public bool IsRecurring { get; set; }
        public List<ChallegeMember> Members { get; set; } = new List<ChallegeMember>();
        public GuildInfo Guild { get; set; }
    }
}
