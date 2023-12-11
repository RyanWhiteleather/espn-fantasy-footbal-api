namespace EspnFantasyFootballApi.Domain.Model
{
    /// <summary>
    /// Creates the route to call the ESPN api.
    /// </summary>
    /// <param name="urlBase"></param>
    /// <param name="urlParams"></param>
    public class Route(string urlBase, string urlParams)
    {
        public override string ToString()
        {
            return urlBase + urlParams;
        }
    }
}