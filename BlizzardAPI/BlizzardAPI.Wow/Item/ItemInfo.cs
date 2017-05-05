namespace BlizzardAPI.Wow.Item
{
    public class ItemInfo
    {
        ItemProperties Item { get; set; }
        public ItemInfo(string itemId, string region, string locale)
        {
            var itemData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/item/{itemId}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (itemData == null)
                return;

            Item = itemData.ToObject<ItemProperties>();
        }
    }
}
