using EspnFantasyFootballApi.Domain.Model;
using EspnFantasyFootballApi.Domain.Provider;
using EspnFantasyFootballApi.Domain.Service;

namespace EspnFantasyFootballApi.Client
{
    public class EspnFantasyFootballApiClient
    {
        private readonly EspnFantasyFootballApiService _espnFantasyFootballApiService;
        
        /// <summary>
        /// Creates the ESPN Fantasy football client for a private league.
        /// </summary>
        /// <param name="leagueId"></param>
        /// <param name="swid"></param>
        /// <param name="espnS2"></param>
        public EspnFantasyFootballApiClient(int leagueId, string swid, string espnS2)
        {
            _espnFantasyFootballApiService = new EspnFantasyFootballApiService(new HttpProvider(swid, espnS2), new UrlConfigurationProvider(), leagueId);
        }
        
    
        /// <summary>
        /// Returns ESPN fantasy football league data.
        /// </summary>
        /// <param name="seasonId">Year the season took place.</param>
        /// <returns></returns>
        public Task<League> GetLeagueAsync(int seasonId)
        {
            return _espnFantasyFootballApiService.GetLeagueAsync(seasonId);
        }

        public Task<BoxScore[]> GetBoxScoreForWeekAsync(int seasonId, int matchupPeriodId, int scoringPeriodId)
        {
            return _espnFantasyFootballApiService.GetBoxScoreForWeek(seasonId, matchupPeriodId, scoringPeriodId);
        }
    }
}