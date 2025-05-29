using CarRental.Application.DTOs;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Repositories;

namespace CarRental.Infrastructure.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _repo;

    public ClientService(IClientRepository repo) => _repo = repo;

    public async Task<List<ClientDto>> GetAllAsync() =>
        (await _repo.GetAllAsync()).Select(c => new ClientDto
        {
            FirstName = c.FirstName,
            LastName = c.LastName,
            DOB = c.DOB,
            Address = c.Address,
            Nationality = c.Nationality,
            RentalStartDate = c.RentalStartDate,
            RentalEndDate = c.RentalEndDate,
            CarId = c.CarId
        }).ToList();

    public async Task<ClientDto> GetByIdAsync(int id)
    {
        var client = await _repo.GetByIdAsync(id) ?? throw new Exception("Client not found");
        return new ClientDto
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            DOB = client.DOB,
            Address = client.Address,
            Nationality = client.Nationality,
            RentalStartDate = client.RentalStartDate,
            RentalEndDate = client.RentalEndDate,
            CarId = client.CarId
        };
    }

    public async Task<ClientDto> CreateAsync(ClientDto dto)
    {
        var client = new Client
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            DOB = dto.DOB,
            Address = dto.Address,
            Nationality = dto.Nationality,
            RentalStartDate = dto.RentalStartDate,
            RentalEndDate = dto.RentalEndDate,
            CarId = dto.CarId
        };
        await _repo.CreateAsync(client);
        return dto;
    }

    public async Task UpdateAsync(int id, ClientDto dto)
    {
        var client = await _repo.GetByIdAsync(id) ?? throw new Exception("Client not found");
        client.FirstName = dto.FirstName;
        client.LastName = dto.LastName;
        client.DOB = dto.DOB;
        client.Address = dto.Address;
        client.Nationality = dto.Nationality;
        client.RentalStartDate = dto.RentalStartDate;
        client.RentalEndDate = dto.RentalEndDate;
        client.CarId = dto.CarId;
        await _repo.UpdateAsync(client);
    }

    public async Task DeleteAsync(int id)
    {
        var client = await _repo.GetByIdAsync(id) ?? throw new Exception("Client not found");
        await _repo.DeleteAsync(client);
    }
}
