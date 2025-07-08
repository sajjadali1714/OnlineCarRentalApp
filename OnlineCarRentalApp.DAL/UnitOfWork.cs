using OnlineCarRentalApp.DAL;
using OnlineCarRentalApp.Domain.Models;
using OnlineCarRentalApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCarRentalApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGenericRepository<Car> Cars { get; private set; }
        public IGenericRepository<Booking> Bookings { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Cars = new GenericRepository<Car>(_context);
            Bookings = new GenericRepository<Booking>(_context);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
