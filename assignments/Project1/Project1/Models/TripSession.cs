using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Project1.Models
{
    public class TripSession
    {
        private const string TripKey = "trip";
        private const string MessageKey = "message";

        private ISession session { get; set; }

        public TripSession(ISession session)
        {
            this.session = session;
        }

        public void SetTrip(Trip trip)
        {
            session.SetObject<Trip>(TripKey, trip);
        }

        public Trip GetTrip() => session.GetObject<Trip>(TripKey);

        public void ClearTrip()
        {
            session.Clear();
        }
    }
}