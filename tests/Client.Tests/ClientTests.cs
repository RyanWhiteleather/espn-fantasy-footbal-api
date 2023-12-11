using EspnFantasyFootballApi.Domain.Model;
using FluentAssertions;
using NUnit.Framework;

namespace EspnFantasyFootballApi.Client.Tests
{
    [TestFixture]
    public class ClientTests
    {
        private const int LEAGUE_ID = 324746;
        private const string SWID = "{C807AE6E-DA5E-4263-87AE-6EDA5E5263D3}";
        private const string ESPN_S2 = "AEBETYgH5ZK1fsO3xF9iH2GPiV7D%2BPzjcLrv%2F%2FJCBw2avLHhUEd04AA6xu9jn7M6IDr%2By8DwWkQjdpwiJEJlJPxyLl5UetHSUDlvIHp0hbJVU3SdCrNaSHW4Up1FS6m0NrBrE4glOh6hEmQMKAjU5ExhXBQ1n%2Bhz6RHqBfm0KzOBWsu032NgbjHf9D5%2FaulrJmHbqOOzErwN2hR4Uh47UoAG2aLT2A9lkOgvy9GLZoVYNzqmtU64eXbYqr0AbyjeJ7E1kISpJ4h7KWZCqnHDmnHQaIWKRndj35ns6zwKQLBQXeA5GFHSTlOnRcBKWFqxURMf%2FMoq80ETpil8yXyr58uo";

        [Test]
        public async Task Should_GetLeagueAsync()
        {
            //arrange
            const int seasonId = 2023;
            EspnFantasyFootballApiClient espnFantasyFootballApiClient = new(LEAGUE_ID,SWID, ESPN_S2);

            //act
            League league = await espnFantasyFootballApiClient.GetLeagueAsync(seasonId);
            

            //assert
            league.Should().NotBeNull();
            league.LeagueSettings.Should().NotBeNull();
            league.LeagueStatus.Should().NotBeNull();
        }
    }
}