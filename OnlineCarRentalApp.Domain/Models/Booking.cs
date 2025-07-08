﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCarRentalApp.Domain.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalPrice { get; set; }

        public bool IsCancelled { get; set; } = false;

        public Car? Car { get; set; }
    }
}
