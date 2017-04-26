namespace WowAPI.Guild
{
    public class News
    {
        public string Type { get; set; }
        public string Character { get; set; }
        public object Timestamp { get; set; }
        public int ItemId { get; set; }
        public string Context { get; set; }
        public long[] BonusLists { get; set; }
        public Achievement Achievement { get; set; }
    }
}
