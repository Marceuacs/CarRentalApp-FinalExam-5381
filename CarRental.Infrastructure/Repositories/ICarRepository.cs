using CarRental.Domain.Entities;

namespace CarRental.Infrastructure.Repositories;

public interface ICarRepository
{
    Task<List<Car>> GetAllAsync();
    Task<Car?> GetByIdAsync(int id);
    Task<Car> CreateAsync(Car car);
    Task UpdateAsync(Car car);
    Task DeleteAsync(Car car);
}
