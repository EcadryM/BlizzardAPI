namespace WowAPI.Character
{
    public class HunterPet
    {
        public int Creature { get; set; }
        public int Slot { get; set; }
        public int FamilyId { get; set; }

        public string Name { get; set; }
        public string CalcSpec { get; set; }
        public string FamilyName { get; set; }

        public Spec Spec;
    }
}
