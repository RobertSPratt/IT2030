using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using Microsoft.AspNetCore.Http;

namespace Project1.Controllers
{
    public class TripController : Controller
    {
        private TripContext context { get; set; }

        public TripController(TripContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            var trip = new Trip();

            return View(trip);
        }

        [HttpPost]
        public IActionResult Add(Trip trip)
        {
            var session = new TripSession(HttpContext.Session);
            var next = trip.Accommodation != null ? "Accommodation" : "ThingsToDo";
            session.SetTrip(trip);

            return RedirectToAction(next, "Trip");
        }

        [HttpGet]
        public IActionResult Accommodation()
        {
            var session = new TripSession(HttpContext.Session);
            Trip trip = session.GetTrip();
            ViewBag.Action = "Add Info for " + trip.Accommodation;

            return View(trip);
        }

        [HttpPost]
        public IActionResult Accommodation(Trip trip)
        {
            var session = new TripSession(HttpContext.Session);
            session.ClearTrip();
            session.SetTrip(trip);

            return RedirectToAction("ThingsToDo", "Trip");
        }

        [HttpGet]
        public IActionResult ThingsToDo()
        {
            var session = new TripSession(HttpContext.Session);
            Trip trip = session.GetTrip();
            ViewBag.Action = "Add Things To Do in " + trip.Destination;

            return View(trip);
        }

        [HttpPost]
        public IActionResult ThingsToDo(Trip trip)
        {
            var session = new TripSession(HttpContext.Session);
            context.Trips.Add(trip);
            context.SaveChanges();
            session.ClearTrip(trip);

            return RedirectToAction("Index", "Home");
        }
    }
}
