using fleetsystem.entities;
namespace fleetsystem.repositories{
    public interface DDriverRepository{
    Task<IEnumerable<Driver>> GetAllDriversAsync();
    }
}