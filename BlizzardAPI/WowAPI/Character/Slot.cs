namespace WowAPI.Character
{
    public class Slot
    {
        public int PetSlot { get; set; }

        public bool IsEmpty { get; set; }
        public bool IsLocked { get; set; }

        public string BattlePetGuid { get; set; }

        public int[] Abilities { get; set; }
    }
}
