using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchResultWebApi.Models
{
    public class MatchResultDBContext
    {
        public static List<LeaderBoard> leaderBoardDetails = new List<LeaderBoard>
        {
            new LeaderBoard() { playerID = 1, player = "Rance", rank = 1, score = 80},
            new LeaderBoard() { playerID = 2, player = "Sam", rank = 2, score = 70},
            new LeaderBoard() { playerID = 3, player = "Hector", rank = 3, score = 60},
            new LeaderBoard() { playerID = 4, player = "Wong", rank = 4, score = 50},
            new LeaderBoard() { playerID = 5, player = "Allen", rank = 5, score = 40},
            new LeaderBoard() { playerID = 6, player = "Stephen", rank = 6, score = 30},
        };

        public static List<Match> matchDetails = new List<Match>
        {

        };

    }
}
