using CarRental.Application.DTOs;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Repositories;

namespace CarRental.Infrastructure.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _repo;

    public CarService(ICarRepository repo) => _repo = repo;

    public async Task<List<CarDto>> GetAllAsync() =>
        (await _repo.GetAllAsync()).Select(c => new CarDto
        {
            LicensePlate = c.LicensePlate,
            Model = c.Model,
            Manufacturer = c.Manufacturer,
            Year = c.Year
        }).ToList();

    public async Task<CarDto> GetByIdAsync(int id)
    {
        var car = await _repo.GetByIdAsync(id) ?? throw new Exception("Car not found");
        return new CarDto
        {
            LicensePlate = car.LicensePlate,
            Model = car.Model,
            Manufacturer = car.Manufacturer,
            Year = car.Year
        };
    }

    public async Task<CarDto> CreateAsync(CarDto dto)
    {
        var car = new Car
        {
            LicensePlate = dto.LicensePlate,
            Model = dto.Model,
            Manufacturer = dto.Manufacturer,
            Year = dto.Year
        };
        await _repo.CreateAsync(car);
        return dto;
    }

    public async Task UpdateAsync(int id, CarDto dto)
    {
        var car = await _repo.GetByIdAsync(id) ?? throw new Exception("Car not found");
        car.LicensePlate = dto.LicensePlate;
        car.Model = dto.Model;
        car.Manufacturer = dto.Manufacturer;
        car.Year = dto.Year;
        await _repo.UpdateAsync(car);
    }

    public async Task DeleteAsync(int id)
    {
        var car = await _repo.GetByIdAsync(id) ?? throw new Exception("Car not found");
        await _repo.DeleteAsync(car);
    }
}
