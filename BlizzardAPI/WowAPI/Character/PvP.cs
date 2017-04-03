using System.Collections.Generic;

namespace WowAPI.Character
{
    public class PvP
    {
        public List<Bracket> brackets = new List<Bracket>();

        public PvP(string name, string realm, string region, string locale)
        {
            var pvpData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=pvp&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (pvpData == null || pvpData["pvp"]["brackets"] == null)
                return;

            foreach (var bracket in pvpData["pvp"]["brackets"].Children())
            {
                brackets.Add(new Bracket
                {
                    Slug = bracket.First["slug"],
                    WeeklyPlayed = bracket.First["weeklyPlayed"],
                    WeeklyWon = bracket.First["weeklyWon"],
                    WeeklyLost = bracket.First["weeklyLost"],
                    SeasonPlayed = bracket.First["seasonPlayed"],
                    SeasonWon = bracket.First["seasonWon"],
                    SeasonLost = bracket.First["seasonLost"]
                });
            }
        }
    }
}
