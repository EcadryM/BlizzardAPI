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
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
