using EspnFantasyFootballApi.Domain.Model;
using EspnFantasyFootballApi.Domain.Provider;
using System.Net;

namespace EspnFantasyFootballApi.Domain.Service;

public class EspnFantasyFootballApiService
{
    private readonly HttpClient _httpClient;
    private readonly UrlConfigurationProvider _urlConfigurationProvider;
    private readonly string _swid;
    private readonly string _espnS2;
    
    public EspnFantasyFootballApiService(string SWID, string espnS2)
    {
        //CookieContainer cookies = new CookieContainer();
        //cookies.Add(new Cookie { Name = "SWID", Value = SWID});
        //cookies.Add(new Cookie { Name = "espn_s2", Value = espnS2 });
        _swid = SWID;
        _espnS2 = espnS2;   

        _httpClient = new HttpClient();
    }

    public async Task<League> GetLeagueAsync(int leagueId, int year)
    {
        string url = _urlConfigurationProvider.GetLeagueEndpointUrl(leagueId, year);
        _httpClient.
    }

}