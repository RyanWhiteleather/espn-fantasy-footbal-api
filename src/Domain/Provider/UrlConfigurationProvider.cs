using EspnFantasyFootballApi.Domain.Model;

namespace EspnFantasyFootballApi.Domain.Provider
{
    /// <summary>
    /// URL provides for ESPN's Fantasy Football API
    /// </summary>
    public class UrlConfigurationProvider
    {
        /// <summary>
        /// URL for getting the base league settings.
        /// </summary>
        /// <param name="leagueId"></param>
        /// <param name="seasonId"></param>
        /// <returns></returns>
        public static string GetLeagueEndpointUrl(int leagueId, int seasonId)
        {
            return new Route(
                $"{GetFantasyUrlBase()}{seasonId}/segments/0/leagues/{leagueId}", 
                "?view=mSettings")
                .ToString();
        }
        

        /// <summary>
        /// Base URL for the V3 ESPN api
        /// </summary>
        /// <returns></returns>
        private static string GetFantasyUrlBase()
        {
            return "https://fantasy.espn.com/apis/v3/games/ffl/seasons/";
        }
    }
}
