using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardAPI.D3.Profile
{
    public class ProfileInfo
    {
        ProfileProperties Profile { get; set; }

        public ProfileInfo(string battleTag, string region, string locale)
        {
            var profileData = ApiHelper.GetJsonFromUrl(
              $"https://{region}.api.battle.net/d3/profile/{battleTag}/?locale={locale}&apikey={ApiHandler.ApiKey}"
          );

            if (profileData == null)
                return;

            Profile = profileData.ToObject<ProfileProperties>();
        }
    }
}
