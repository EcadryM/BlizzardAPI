using System.Collections.Generic;

namespace WowAPI.Guild
{
    public class Challenge
    {
        public Realm Realm { get; set; }
        public Map Map { get; set; }
        private List<Group> groups = new List<Group>();
        public List<Group> Groups { get => groups; set => groups = value; }
    }
}
