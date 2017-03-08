using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Challonge.API
{
    public enum TournamentState
    {
        Pending, In_Progress, Ended
    }

    public enum TournamentType
    {
        Single_Elimination, Double_Elimination, Round_Robin, Swiss
    }

    public class ChallongeService
    {
        private string APIKey = "";
        private string BaseServiceURL = "https://api.challonge.com/v1/";
        public void GetTournaments(TournamentState? tournamentState = null, TournamentType? tournamentType = null, DateTime? createdAfter = null, DateTime? createdBefor = null)
        {
            using (var client = new WebClient())
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                client.Encoding = Encoding.UTF8;
                string requestUrl = $"{BaseServiceURL}/tournaments.json?api_key={APIKey}";
                string result = client.DownloadString($"{BaseServiceURL}/tournaments.json?api_key={APIKey}");
                
                using (StreamWriter sw = new StreamWriter("Tournaments.json", false))
                {
                    sw.Write(result);
                }
            }
        }
    }
}
