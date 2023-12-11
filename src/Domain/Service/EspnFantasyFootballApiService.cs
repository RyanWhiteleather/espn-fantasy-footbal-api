using EspnFantasyFootballApi.Domain.Model;
using EspnFantasyFootballApi.Domain.Provider;
using System.Net;

namespace EspnFantasyFootballApi.Domain.Service
{
    public class EspnFantasyFootballApiService(
        HttpProvider httpProvider,
        UrlConfigurationProvider urlConfigurationProvider,
        int leagueId)
    {
        public Task<League> GetLeagueAsync(int seasonId)
        {
            string url = UrlConfigurationProvider.GetLeagueEndpointUrl(leagueId, seasonId);
            return httpProvider.GetAsync<League>(url);
        }

        public Task<BoxScore[]> GetBoxScoreForWeek(int seasonId, int matchupPeriodId, int scoringPeriodId)
        {
            throw new NotImplementedException();
        }
    }
}