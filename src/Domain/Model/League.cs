using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace EspnFantasyFootballApi.Domain.Model
{
    public class League
    {

        [JsonProperty("settings")]
        public LeagueSettings LeagueSettings { get; set; }
        
        [JsonProperty("status")]
        public LeagueStatus LeagueStatus { get; set; }
    }

}
