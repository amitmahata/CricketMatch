using CricketMatch.DAL;
using CricketMatch.DAL.Repository;
using CricketMatch.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketMatch.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMatchPlayerRepository _repo;

        public HomeController(IMatchPlayerRepository repo)
        {
            _repo  = repo;
        }

        public ActionResult Index()
        {
            MatchPlayerViewModel model  =  new MatchPlayerViewModel();
            model.Players  =  new List<PlayerDetail>();
            return View(model);
        }
        public ActionResult SubmitData(MatchPlayerViewModel model)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}