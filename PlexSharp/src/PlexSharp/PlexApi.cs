#region Copyright
// /************************************************************************
//    Copyright (c) 2016 Jamie Rees
//    File: PlexApi.cs
//    Created By: Jamie Rees
//   
//    Permission is hereby granted, free of charge, to any person obtaining
//    a copy of this software and associated documentation files (the
//    "Software"), to deal in the Software without restriction, including
//    without limitation the rights to use, copy, modify, merge, publish,
//    distribute, sublicense, and/or sell copies of the Software, and to
//    permit persons to whom the Software is furnished to do so, subject to
//    the following conditions:
//   
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//   
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ************************************************************************/
#endregion

using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Newtonsoft.Json;

using PlexSharp.Interfaces;
using PlexSharp.Models;

using RestSharp;
using RestSharp.Newtonsoft.Json;

using RestRequest = RestSharp.RestRequest;

namespace PlexSharp
{
    public class PlexApi
    {
        static PlexApi()
        {
            Version = Guid.NewGuid().ToString("N");
        }

        private readonly JsonSerializer _settings = new JsonSerializer
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        private IApiRequest _api;
        private IApiRequest Api
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

        private const string SignInUri = "https://plex.tv/users/sign_in.json";
        private const string FriendsUri = "https://plex.tv/pms/friends/all";
        private const string GetAccountUri = "https://plex.tv/users/account";
        private static string Version { get; }

        public PlexAuthentication SignIn(string username, string password)
        {
            var userModel = new PlexUserRequest
            {
                User = new UserRequest
                {
                    Password = password,
                    Login = username
                }
            };
            var request = new RestRequest
            {
                Method = Method.POST,
                RequestFormat = DataFormat.Json
            };
            Setup(ref request);
            AddHeaders(ref request, true);
            request.AddBody(userModel);


            var obj = Api.Execute<PlexAuthentication>(request, new Uri(SignInUri));

            return obj;
        }

        public async Task<PlexAuthentication> SignInAsync(string username, string password)
        {
            var userModel = new PlexUserRequest
            {
                User = new UserRequest
                {
                    Password = password,
                    Login = username
                }
            };
            var request = new RestRequest
            {
                Method = Method.POST,
                RequestFormat = DataFormat.Json
            };
            Setup(ref request);
            AddHeaders(ref request);

            request.AddJsonBody(userModel);

            var obj = await Api.ExecuteAsync<PlexAuthentication>(request, new Uri(SignInUri));

            return obj;
        }

        public PlexFriends GetFriends(string authToken)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Xml
            };
            Setup(ref request);
            AddHeaders(ref request, authToken);

            var users = Api.Execute<PlexFriendsWrapper>(request, new Uri(FriendsUri));

            return users.PlexFriends;
        }
        public async Task<PlexFriends> GetUsersAsync(string authToken)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
            };

            AddHeaders(ref request, authToken);

            var users = await Api.ExecuteAsync<PlexFriendsWrapper>(request, new Uri(FriendsUri));

            return users.PlexFriends;
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <param name="authToken">The authentication token.</param>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="plexFullHost">The full plex host.</param>
        /// <returns></returns>
        public PlexSearch SearchContent(string authToken, string searchTerm, Uri plexFullHost)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "search?query={searchTerm}"
            };

            request.AddUrlSegment("searchTerm", searchTerm);
            AddHeaders(ref request, authToken);

            var search = Api.Execute<PlexSearchWrapper>(request, plexFullHost);

            return search.PlexSearch;
        }

        public async Task<PlexSearch> SearchContentAsync(string authToken, string searchTerm, Uri plexFullHost)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "search?query={searchTerm}"
            };

            request.AddUrlSegment("searchTerm", searchTerm);
            AddHeaders(ref request, authToken);

            var search = await Api.ExecuteAsync<PlexSearchWrapper>(request, plexFullHost);

            return search.PlexSearch;
        }

        public PlexStatus GetStatus(string authToken, Uri uri)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
            };

            AddHeaders(ref request, authToken);

            var users = Api.Execute<PlexStatusWrapper>(request, uri);

            return users.PlexStatus;
        }

        public async Task<PlexStatus> GetStatusAsync(string authToken, Uri uri)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
            };

            AddHeaders(ref request, authToken);

            var users = await Api.ExecuteAsync<PlexStatusWrapper>(request, uri);

            return users.PlexStatus;
        }

        public PlexAccount GetAccount(string authToken)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
            };

            AddHeaders(ref request, authToken);

            var account = Api.Execute<PlexAccountWrapper>(request, new Uri(GetAccountUri));

            return account.PlexAccount;
        }

        public async Task<PlexAccount> GetAccountAsync(string authToken)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
            };

            AddHeaders(ref request, authToken);

            var account = await Api.ExecuteAsync<PlexAccountWrapper>(request, new Uri(GetAccountUri));

            return account.PlexAccount;
        }

        public PlexLibraries GetLibrarySections(string authToken, Uri plexFullHost)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "library/sections"
            };

            AddHeaders(ref request, authToken);

            var lib = Api.Execute<PlexLibrariesWrapper>(request, plexFullHost);

            return lib.PlexLibraries;
        }

        public async Task<PlexLibraries> GetLibrarySectionsAsync(string authToken, Uri plexFullHost)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "library/sections"
            };

            AddHeaders(ref request, authToken);

            var lib = await Api.ExecuteAsync<PlexLibrariesWrapper>(request, plexFullHost);

            return lib.PlexLibraries;
        }

        public PlexSearch GetLibrary(string authToken, Uri plexFullHost, string libraryId)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "library/sections/{libraryId}/all"
            };

            request.AddUrlSegment("libraryId", libraryId);
            AddHeaders(ref request, authToken);

            var lib = Api.Execute<PlexSearchWrapper>(request, plexFullHost);

            return lib.PlexSearch;
        }

        public async Task<PlexSearch> GetLibraryAsync(string authToken, Uri plexFullHost, string libraryId)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "library/sections/{libraryId}/all"
            };

            request.AddUrlSegment("libraryId", libraryId);
            AddHeaders(ref request, authToken);

            var lib = await Api.ExecuteAsync<PlexSearchWrapper>(request, plexFullHost);

            return lib.PlexSearch;
        }

        private void AddHeaders(ref RestRequest request, string authToken)
        {
            request.AddHeader("X-Plex-Token", authToken);
            AddHeaders(ref request);
        }

        private void AddHeaders(ref RestRequest request, bool json = false)
        {
            request.AddHeader("X-Plex-Client-Identifier", "Test213");
            request.AddHeader("X-Plex-Product", "Request Plex");
            request.AddHeader("X-Plex-Version", Version);
            request.AddHeader("Content-Type", json ? "application/json" : "application/xml");
        }

        private void Setup(ref RestRequest request)
        {
            request.JsonSerializer = new NewtonsoftJsonSerializer(_settings);
        }
    }
}
