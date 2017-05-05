using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlizzardAPI.Wow.Mounts
{
    public class Mounts
    {
        private List<MountInfo> mounts = new List<MountInfo>();
        public List<MountInfo> MountsList { get => mounts; set => mounts = value; }

        public Mounts(string region, string locale)
        {
            var mountsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/mount/?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (mountsData == null)
                return;

            for (var i = 0; i < (mountsData["mounts"] as JArray).Count; i++)
            {
                MountsList.Add(new MountInfo
                {
                    Name = mountsData["mounts"][i]["name"],
                    Icon = mountsData["mounts"][i]["icon"],
                    SpellId = mountsData["mounts"][i]["spellId"],
                    CreatureId = mountsData["mounts"][i]["creatureId"],
                    ItemId = mountsData["mounts"][i]["itemId"],
                    QualityId = mountsData["mounts"][i]["qualityId"],
                    IsGround = mountsData["mounts"][i]["isGround"],
                    IsFlying = mountsData["mounts"][i]["isFlying"],
                    IsAquatic = mountsData["mounts"][i]["isAquatic"],
                    IsJumping = mountsData["mounts"][i]["isJumping"]
                });
            }
        }
    }
}
