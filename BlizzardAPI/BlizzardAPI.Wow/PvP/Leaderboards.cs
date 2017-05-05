using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlizzardAPI.Wow.PvP
{
    public class Leaderboards
    {
        private List<LeaderboardRow> leaderboards = new List<LeaderboardRow>();
        public List<LeaderboardRow> LeaderboardsList { get => leaderboards; set => leaderboards = value; }

        public Leaderboards(string bracketSlug, string region, string locale)
        {
            var leaderboardsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/leaderboard/{bracketSlug}?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (leaderboardsData == null)
                return;

            for (var i = 0; i < (leaderboardsData["rows"] as JArray).Count; i++)
            {
                LeaderboardsList.Add(new LeaderboardRow
                {
                    Ranking = leaderboardsData["rows"][i]["ranking"],
                    Rating = leaderboardsData["rows"][i]["rating"],
                    RealmId = leaderboardsData["rows"][i]["realmId"],
                    RaceId = leaderboardsData["rows"][i]["raceId"],
                    ClassId = leaderboardsData["rows"][i]["classId"],
                    SpecId = leaderboardsData["rows"][i]["specId"],
                    FactionId = leaderboardsData["rows"][i]["factionId"],
                    GenderId = leaderboardsData["rows"][i]["genderId"],
                    SeasonWins = leaderboardsData["rows"][i]["seasonWins"],
                    SeasonLosses = leaderboardsData["rows"][i]["seasonLosses"],
                    WeeklyWins = leaderboardsData["rows"][i]["weeklyWins"],
                    WeeklyLosses = leaderboardsData["rows"][i]["weeklyLosses"],
                    Name = leaderboardsData["rows"][i]["name"],
                    RealmName = leaderboardsData["rows"][i]["realmDate"],
                    RealmSlug = leaderboardsData["rows"][i]["realmSlug"]
                });
            }
        }
    }
}