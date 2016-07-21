using Newtonsoft.Json;

using PlexSharp.Interfaces;

namespace PlexSharp
{
    public class BasePlexApi
    {
        private IApiRequest _api;
        internal IApiRequest Api
        {
            get
            {
                if (_api != null)
                {
                    return _api;
                }
                _api = new ApiRequest();
                return _api;
            }
        }

        protected const string SignInUri = "https://plex.tv/users/sign_in.json";
        protected const string FriendsUri = "https://plex.tv/pms/friends/all";
        protected const string GetAccountUri = "https://plex.tv/users/account";

        protected string _plexClientIdentifier;
        protected string _plexProduct;

        protected readonly JsonSerializer Settings = new JsonSerializer
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };


    }
}