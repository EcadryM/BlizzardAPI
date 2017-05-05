using System.Collections.Generic;

namespace BlizzardAPI.Wow.Character
{
    public class Talent
    {
        public bool Selected { get; set; }
        public List<Talent> Talents { get; set; }
        public Spec Spec { get; set; }
        public string CalcTalent { get; set; }
        public string CalcSpec { get; set; }
    }
}
