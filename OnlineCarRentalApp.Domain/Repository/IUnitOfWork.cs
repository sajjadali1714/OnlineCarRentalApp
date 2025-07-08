using OnlineCarRentalApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCarRentalApp.Domain.Repository
{
    public interface IUnitOfWork
    {
        IGenericRepository<Car> Cars { get; }
        IGenericRepository<Booking> Bookings { get; }
        Task<int> SaveAsync();
    }
}
