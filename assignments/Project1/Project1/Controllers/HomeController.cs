using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context { get; set; }

        public HomeController(TripContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var session = new TripSession(HttpContext.Session);
            session.ClearTrip();
            TempData.Clear();
            var trips = context.Trips.
                OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }
    }
}
