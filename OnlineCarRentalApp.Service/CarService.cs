using OnlineCarRentalApp.Domain.Models;
using OnlineCarRentalApp.Domain.Repository;
using OnlineCarRentalApp.Service.DTOs.CarDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCarRentalApp.Service
{
    public class CarService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddCarAsync(AddCarDto dto)
        {
            var car = new Car { Brand = dto.Brand, Model = dto.Model, PricePerDay = dto.PricePerDay };
            await _unitOfWork.Cars.AddAsync(car);
            await _unitOfWork.SaveAsync();
            return "Car added successfully";
        }
    }

}
