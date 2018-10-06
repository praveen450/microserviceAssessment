using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatchResultWebApi.Models;

namespace MatchResultWebApi.Controllers
{
    public class LeaderBoardController : Controller
    {
        public List<LeaderBoard> dbLeaderboardContext = MatchResultDBContext.leaderBoardDetails;
        public List<Match> dbMatchContext = MatchResultDBContext.matchDetails;

        [HttpGet]
        [Route("api/leaderboard")]
        public List<LeaderBoard> Get()
        {
            return dbLeaderboardContext.ToList();

        }

        [HttpGet("{id}")]
        [Route("api/leaderboard/{id}")]
        public LeaderBoard Get(int id)
        {
            return dbLeaderboardContext.Find(tr => tr.playerID == id);
        }

        [HttpPost]
        [Route("api/leaderboard/reset")]
        public List<LeaderBoard> Reset()
        {
            dbLeaderboardContext.RemoveAll(tr => tr.playerID != 0);
            dbMatchContext.RemoveAll(tr => tr.matchId != 0);
            return dbLeaderboardContext.ToList();
        }
    }
}