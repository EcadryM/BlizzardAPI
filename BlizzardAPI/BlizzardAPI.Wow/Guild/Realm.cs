﻿using System.Collections.Generic;

namespace BlizzardAPI.Wow.Guild
{
    public class Realm
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Battlegroup { get; set; }
        public string Locale { get; set; }
        public string Timezone { get; set; }
        public List<string> ConnectedRealms { get; set; } = new List<string>();
    }
}
