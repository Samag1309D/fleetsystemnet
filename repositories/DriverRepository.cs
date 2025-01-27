using Microsoft.EntityFrameworkCore;
using fleetsystem.config;
using fleetsystem.entities;
using fleetsystem.repositories;
namespace fleetsystem.repositories{
    public class DriverRepository: DDriverRepository{
            private readonly DriverDbContext _context;

    public DriverRepository(DriverDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Driver>> GetAllDriversAsync() => await _context.Drivers.ToListAsync();
    }
}