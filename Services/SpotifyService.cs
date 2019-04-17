using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace SpotifyApp.Services
{

    public class SpotifyService
    {

        TokenSwapWebAPIFactory webApiFactory;
        SpotifyWebAPI spotify;
        private static SpotifyWebAPI _spotify = new SpotifyWebAPI();

        public SpotifyService()
        {
            webApiFactory = new TokenSwapWebAPIFactory("/")
            {
                Scope = Scope.UserReadPrivate | Scope.UserReadEmail | Scope.PlaylistReadPrivate,
                AutoRefresh = true
            };
        }

        public FullTrack GetTrack(string id)
        {
            //bd3959874f734f0e96685a28c5af6c0f
            FullTrack res = _spotify.GetTrack(id);
            return res;
        }

    }
}