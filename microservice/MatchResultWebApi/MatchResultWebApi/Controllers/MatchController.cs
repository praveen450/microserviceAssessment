using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatchResultWebApi.Models;

namespace MatchResultWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MatchController : Controller
    {        
        public List<LeaderBoard> dbLeaderboardContext = MatchResultDBContext.leaderBoardDetails;
        public List<Match> dbMatchContext = MatchResultDBContext.matchDetails;

        [HttpGet]
        public List<Match> Get()
        {
            return dbMatchContext.ToList();

        }

        [HttpGet("{id}")]
        public Match Get(int id)
        {
            return dbMatchContext.Find(tr => tr.matchId == id);
        }

        [HttpPost]
        public List<Match> Post([FromBody]Match matchResult)
        {
            int MatchData = 0;
            if (dbMatchContext.Count == 0)
                matchResult.matchId = 1;
            else
            {
                MatchData = dbMatchContext.Max(tr => tr.matchId);
                MatchData = MatchData + 1;
                matchResult.matchId = MatchData;
            }
            matchResult.status = "in-progess";
            matchResult.potentialPoints = (matchResult.level + matchResult.opponentLevel) * 10;
            matchResult.winner = "";

            dbMatchContext.Add(matchResult);
            return dbMatchContext.ToList();
        }

        [HttpPut("{id}")]
        public Match Put(int id, [FromBody]Match matchResult)
        {

            var matchData = dbMatchContext.Find(tr => tr.matchId == id);
            if (matchData == null)
            {
                return null;
            }
            var data = dbMatchContext.Where(tr => tr.matchId == id)
             .Select(tr => { tr.winner = matchResult.winner; tr.status = matchResult.status; return tr; })
             .ToList();

            var getPlayerData = dbLeaderboardContext.Find(tr => tr.player == matchResult.winner);
            if (getPlayerData == null)
            {
                int LeaderData = 0;
                if (dbLeaderboardContext.Count == 0)
                    LeaderData = 1;
                else
                {
                    LeaderData = dbLeaderboardContext.Max(tr => tr.playerID);
                    LeaderData = LeaderData + 1;

                }
                dbLeaderboardContext.Add(new LeaderBoard() { playerID = LeaderData, player = matchResult.winner, rank = 0, score = data[0].potentialPoints });
            }
            else
            {
                getPlayerData.score = getPlayerData.score + data[0].potentialPoints;
            }
            if (dbLeaderboardContext.Count > 0)
            {
                var descScoreData = dbLeaderboardContext.OrderByDescending(tr => tr.score);
                int RankCount = 1;
                foreach (LeaderBoard xy in descScoreData)
                {
                    xy.rank = RankCount;
                    RankCount = RankCount + 1; ;
                }
            }

            return dbMatchContext.Find(tr => tr.matchId == id);

        }
    }
}