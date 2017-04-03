using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Reputation
    {
        public List<ReputationInfo> reputation = new List<ReputationInfo>();

        public Reputation(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
