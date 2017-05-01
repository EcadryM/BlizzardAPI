using System.Collections.Generic;

namespace WowAPI.Guild
{
    public class Challenge
    {
        public Realm Realm { get; set; }
        public Map Map { get; set; }
        public List<Group> Groups { get; set; }
    }
}
