using System.Collections.Generic;

namespace WowAPI.Item
{
    public class ItemSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SetBonus> SetBonuses { get; set; }
        public long[] Items { get; set; }

        public ItemSet(string setId, string region, string locale)
        {
            var itemSetData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/item/set/{setId}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (itemSetData == null)
                return;

            Id = itemSetData["id"];
            Name = itemSetData["name"];
            SetBonuses = itemSetData["setBonuses"].ToObject<List<SetBonus>>();
            Items = itemSetData["items"].ToObject<long[]>();
        }
    }
}
