namespace BlizzardAPI.Wow.Character
{
    public class Statistic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Quantity { get; set; }
        public object LastUpdated { get; set; }
        public bool Money { get; set; }
        public string Highest { get; set; }
    }
}
