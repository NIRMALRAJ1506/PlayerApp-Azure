using Microsoft.AspNetCore.Mvc;
using PlayerApp.Models;

namespace PlayerApp.Controllers
{
    public class PlayersController : Controller
    {

        static List<Player> players = new List<Player>()
 {
     new Player() {PId=1,PName="MS Dhoni",PCountry="India",PType="Wicket Keeper" },
    new Player() {PId=2,PName="Virat Kohli",PCountry="India",PType="Batsman" },
    new Player() {PId=3,PName="Ben Stokes",PCountry="England",PType="All Rounder" },
    new Player() {PId=4,PName="Bumrah",PCountry="India",PType="Bowler" },
    new Player() {PId=5,PName="Devon Conway",PCountry="New Zealand",PType="Wicket Keeper" },
 };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player pro)
        {
            if (ModelState.IsValid)
            {
                players.Add(pro);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
