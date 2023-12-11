namespace EspnFantasyFootballApi.Domain.Model
{
    public class LeagueStatus
    {

        public int CurrentMatchupPeriod { get; set; }
        public int FinalScoringPeriod { get; set; }
        public int FirstScoringPeriod { get; set; }
        public bool IsActive { get; set; }
        public bool IsExpired { get; set; }
        public bool IsFull { get; set; }
        public bool isPlayoffMatchupEdited { get; set; }
        public int LatestScoringPeriod { get; set; }
        public int[] PreviousSeasons { get; set; }
        public long StandingsUpdateDate { get; set; }
        public int TeamsJoined { get; set; }
        public int TransactionScoringPeriod { get; set; }
        public long WaiverLastExecutionDate { get; set; }
    }
}
