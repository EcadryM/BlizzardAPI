using System.Collections.Generic;

namespace BlizzardAPI.Wow.Item
{
    public class BonusSummary
    {
        public List<object> DefaultBonusLists { get; set; }
        public List<object> ChanceBonusLists { get; set; }
        public List<object> BonusChances { get; set; }
    }
}
