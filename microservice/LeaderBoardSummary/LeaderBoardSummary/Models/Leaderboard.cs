using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeaderBoardSummary.Models
{
    public class Leaderboard
    {
        public int playerID { get; set; }
        public string player { get; set; }
        public int rank { get; set; }
        public int score { get; set; }
    }
}
