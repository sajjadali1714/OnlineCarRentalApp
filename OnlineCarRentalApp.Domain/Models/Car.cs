using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCarRentalApp.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public string Transmission { get; set; } = string.Empty; // e.g., Automatic, Manual

        public string FuelType { get; set; } = string.Empty;     // e.g., Petrol, Diesel, Electric

        public int Year { get; set; }

        public decimal PricePerDay { get; set; }

        public bool IsAvailable { get; set; } = true;

        public string? ImageUrl { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
