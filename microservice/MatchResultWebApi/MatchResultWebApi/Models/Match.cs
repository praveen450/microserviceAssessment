using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchResultWebApi.Models
{
    public class Match
    {
        public int matchId { get; set; }
        public string player { get; set; }
        public int level { get; set; }
        public string opponentName { get; set; }
        public int opponentLevel { get; set; }
        public string status { get; set; }
        public int potentialPoints { get; set; }
        public string winner { get; set; }
    }
}
