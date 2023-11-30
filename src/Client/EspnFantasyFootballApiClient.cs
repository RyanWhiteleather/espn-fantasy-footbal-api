using EspnFantasyFootballApi.Domain.Model;
using EspnFantasyFootballApi.Domain.Service;

namespace EspnFantasyFootballApi.Client;

public class EspnFantasyFootballApiClient
{
    private readonly EspnFantasyFootballApiService _espnFantasyFootballApiService;

    /// <summary>
    /// 
    /// </summary>
    public EspnFantasyFootballApiClient()
    {
        _espnFantasyFootballApiService = new EspnFantasyFootballApiService();
    }

    /// <summary>
    /// Creates the EspnFantasyFootballApiClient for a private league.
    /// </summary>
    /// <param name="SWID"></param>
    /// <param name="espnS2"></param>
    public EspnFantasyFootballApiClient(string SWID, string espnS2)
    {
        _espnFantasyFootballApiService = new EspnFantasyFootballApiService(SWID, espnS2);
    }
    
    public async Task<League> GetLeagueAsync(int leagueId, int year)
    {
        return await _espnFantasyFootballApiService.GetLeagueSync(leagueId, year);
    }
}