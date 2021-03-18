using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [Required(ErrorMessage = "Please enter a destination.")]
        [Column(TypeName = "nvarchar(max)")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Please enter a valid start date.")]
        [Column(TypeName = "datetime2(7)")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter a valid end date.")]
        [Column(TypeName = "datetime2(7)")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Accommodation { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string AccommodationPhone { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string AccommodationEmail { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string ThingToDo1 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string ThingToDo2 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string ThingToDo3 { get; set; }

        public string Slug =>
            Destination?.Replace(' ', '-').ToLower() + '-' +
            StartDate.ToString() + '-' + EndDate.ToString();
    }
}
