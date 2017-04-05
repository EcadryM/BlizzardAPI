using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Reputation
    {
        private List<ReputationInfo> reputation = new List<ReputationInfo>();
        public List<ReputationInfo> CharacterReputation { get => reputation; set => reputation = value; }

        public Reputation(string name, string realm, string region, string locale)
        {
            var reputationData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=reputation&locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (reputationData == null || reputationData["reputation"] == null)
                return;

            for (var i = 0; i < (reputationData["reputation"] as JArray).Count; i++)
            {
                CharacterReputation.Add(new ReputationInfo
                {
                    Name = reputationData["reputation"][i]["name"],
                    Id = reputationData["reputation"][i]["id"],
                    Standing = reputationData["reputation"][i]["standing"],
                    Value = reputationData["reputation"][i]["value"],
                    Max = reputationData["reputation"][i]["max"]
                });
            }
        }
    }
}
