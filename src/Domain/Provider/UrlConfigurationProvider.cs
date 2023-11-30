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
        /// <param name="year"></param>
        /// <returns></returns>
        public string GetLeagueEndpointUrl(int leagueId, int year)
        {
            const string leagueEndpointFormat = "{0}leagueSettings?leagueId={1}&seasonId={2}";
            return string.Format(leagueEndpointFormat, GetFantasyUrlBase(), leagueId, year);
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
