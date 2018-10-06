using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchResultWebApi.Models
{
    public class LeaderBoard
    {
        public int playerID { get; set; }
        public string player { get; set; }
        public int rank { get; set; }
        public int score { get; set; }
    }
}
