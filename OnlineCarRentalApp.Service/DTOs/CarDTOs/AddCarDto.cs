using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCarRentalApp.Service.DTOs.CarDTOs
{
    public class AddCarDto
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal PricePerDay { get; set; }
    }
}
