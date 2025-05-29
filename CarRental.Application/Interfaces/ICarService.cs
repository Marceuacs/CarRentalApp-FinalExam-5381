using CarRental.Application.DTOs;

namespace CarRental.Application.Interfaces;

public interface ICarService
{
    Task<List<CarDto>> GetAllAsync();
    Task<CarDto> GetByIdAsync(int id);
    Task<CarDto> CreateAsync(CarDto dto);
    Task UpdateAsync(int id, CarDto dto);
    Task DeleteAsync(int id);
}
