using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using WowAPI.Mounts;

namespace WowAPI.Character
{
    public class Mounts
    {
        public int NumCollected { get; set; }
        public int NumNotCollected { get; set; }

        public List<MountInfo> collected = new List<MountInfo>();

        public Mounts(string name, string realm, string region, string locale)
        {
            var mountsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=mounts&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (mountsData == null)
                return;

            NumCollected = mountsData.mounts["numCollected"];
            NumNotCollected = mountsData.mounts["numNotCollected"];

            for (var i = 0; i < (mountsData.mounts["collected"] as JArray).Count; i++)
            {
                collected.Add(new MountInfo
                {
                    Name = mountsData.mounts["collected"][i]["name"],
                    Icon = mountsData.mounts["collected"][i]["icon"],
                    SpellId = mountsData.mounts["collected"][i]["spellId"],
                    CreatureId = mountsData.mounts["collected"][i]["creatureId"],
                    ItemId = mountsData.mounts["collected"][i]["itemId"],
                    QualityId = mountsData.mounts["collected"][i]["qualityId"],
                    IsGround = mountsData.mounts["collected"][i]["isGround"],
                    IsFlying = mountsData.mounts["collected"][i]["isFlying"],
                    IsAquatic = mountsData.mounts["collected"][i]["isAquatic"],
                    IsJumping = mountsData.mounts["collected"][i]["isJumping"]
                });
            }
        }
    }
}
