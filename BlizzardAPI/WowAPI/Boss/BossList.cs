using System.Collections.Generic;

namespace WowAPI.Boss
{
    public class BossList
    {
        private List<Boss> bosses = new List<Boss>();
        public List<Boss> Bosses { get => bosses; set => bosses = value; }

        public BossList(string region, string locale)
        {
            var bossListData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/boss/?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (bossListData == null)
                return;

            Bosses = bossListData["bosses"].ToObject<List<Boss>>();
        }
    }
}
