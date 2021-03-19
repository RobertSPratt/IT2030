using Microsoft.EntityFrameworkCore;
using System;

namespace Project1.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                    Destination = "Boise",
                    StartDate = new DateTime(2020, 6, 6),
                    EndDate = new DateTime(2020, 6, 20),
                    ThingToDo1 = "Visit Tammy"
                },
                new Trip
                {
                    TripId = 2,
                    Destination = "Portland",
                    StartDate = new DateTime(2021, 1, 1),
                    EndDate = new DateTime(2021, 1, 7),
                    Accommodation = "The Benson Hotel",
                    AccommodationPhone = "503-555-1234",
                    AccommodationEmail = "staff@bensonhotel.com",
                    ThingToDo1 = "Go To Voodoo Doughnuts",
                    ThingToDo2 = "Walk in the rain",
                    ThingToDo3 = "Go to Powell"
                });
        }
    }
}