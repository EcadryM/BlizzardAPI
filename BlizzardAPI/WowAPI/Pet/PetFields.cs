using System.Collections.Generic;

namespace WowAPI.Pet
{
    public class PetFields
    {
        public bool CanBattle { get; set; }
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Icon { get; set; }
        public int QualityId { get; set; }
        public Stats Stats { get; set; }
        public List<string> StrongAgainst { get; set; }
        public int TypeId { get; set; }
        public List<string> WeakAgainst { get; set; }
    }
}
