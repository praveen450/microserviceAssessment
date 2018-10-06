using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeaderBoardSummary.Models;
using LeaderBoardSummary.ViewModels;

namespace LeaderBoardSummary.Controllers
{
    public class LeaderboardController : Controller
    {
        public IActionResult Index()
        {
            LeaderBoardDataCalls dc = new LeaderBoardDataCalls();
            ViewBag.listAllLeaderboard = dc.getAllResults().OrderBy(sc => sc.rank).Take(10);
            ViewBag.listAllScores = dc.getMatchSummary();
            return View();
        }


        public ActionResult Reset()
        {
            LeaderBoardDataCalls dc = new LeaderBoardDataCalls();
            dc.Reset();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Create(MatchViewModel mvm)
        {
            if (!String.IsNullOrEmpty(mvm.Match.player) && !String.IsNullOrEmpty(mvm.Match.opponentName)
               && (mvm.Match.level >= 0) && (mvm.Match.opponentLevel >= 0))
            {
                mvm.Match.player = mvm.Match.player.ToUpper();
                mvm.Match.opponentName = mvm.Match.opponentName.ToUpper();
                LeaderBoardDataCalls dc = new LeaderBoardDataCalls();
                dc.CreateMatch(mvm.Match);
            }

            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            LeaderBoardDataCalls dc = new LeaderBoardDataCalls();
            MatchViewModel mvm = new MatchViewModel();
            mvm.Match = dc.FindMatch(id);
            return View("Edit", mvm);
        }

        [HttpPost]
        public ActionResult Edit(MatchViewModel mvm)
        {
            if (String.IsNullOrEmpty(mvm.Match.winner))
                return RedirectToAction("Index");

            if (mvm.Match.winner.ToUpper() != mvm.Match.player.ToUpper() && mvm.Match.winner.ToUpper() != mvm.Match.opponentName.ToUpper())
                return RedirectToAction("Index");

            mvm.Match.status = "complete";
            mvm.Match.winner = mvm.Match.winner.ToUpper();
            LeaderBoardDataCalls dc = new LeaderBoardDataCalls();
            dc.EditMatch(mvm.Match);
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
