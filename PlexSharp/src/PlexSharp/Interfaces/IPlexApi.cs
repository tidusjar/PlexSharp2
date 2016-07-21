using System;
using System.Threading.Tasks;

using PlexSharp.Models;

namespace PlexSharp.Interfaces
{
    public interface IPlexApi
    {
        string PlexProduct { get; set; }
        string PlexClientIdentifier { get; set; }
        PlexAuthentication SignIn(string username, string password);
        Task<PlexAuthentication> SignInAsync(string username, string password);
        PlexFriends GetFriends(string authToken);
        Task<PlexFriends> GetFriendsAsync(string authToken);
        PlexSearch SearchContent(string authToken, string searchTerm, Uri plexFullHost);
        Task<PlexSearch> SearchContentAsync(string authToken, string searchTerm, Uri plexFullHost);
    }
}