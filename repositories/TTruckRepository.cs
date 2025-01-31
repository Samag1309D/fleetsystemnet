using fleetsystem.entities;

namespace fleetsystem.repositories{

public interface TTruckRepository
{
    Task<IEnumerable<Truck>> GetAllTrucksAsync();
    Task<Truck?> GetTruckByIdAsync(int id);
    Task<Truck> AddTruckAsync(Truck truck);
    Task<Truck?> UpdateTruckAsync(Truck truck);
    Task<bool> DeleteTruckAsync(int id);
}}


