using System.Collections.Generic;

namespace BlizzardAPI.SC2.DataResources
{
    public class Rewards
    {
        public List<Portrait> Portraits { get; set; }
        public List<TerranDecal> TerranDecals { get; set; }
        public List<ZergDecal> ZergDecals { get; set; }
        public List<ProtossDecal> ProtossDecals { get; set; }
        public List<Skin> Skins { get; set; }
        public List<Animation> Animations { get; set; }

        public Rewards(string region, string locale)
        {
            var rewardsData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/sc2/data/rewards?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (rewardsData == null)
                return;

            Portraits = rewardsData["portraits"].ToObject<List<Portrait>>();
            TerranDecals = rewardsData["terranDecals"].ToObject<List<TerranDecal>>();
            ZergDecals = rewardsData["zergDecals"].ToObject<List<ZergDecal>>();
            ProtossDecals = rewardsData["protossDecals"].ToObject<List<ProtossDecal>>();
            Skins = rewardsData["skins"].ToObject<List<Skin>>();
            Animations = rewardsData["animations"].ToObject<List<Animation>>();
        }
    }
}
