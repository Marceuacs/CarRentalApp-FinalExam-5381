using CarRental.Application.DTOs;

namespace CarRental.Application.Interfaces;

public interface IClientService
{
    Task<List<ClientDto>> GetAllAsync();
    Task<ClientDto> GetByIdAsync(int id);
    Task<ClientDto> CreateAsync(ClientDto dto);
    Task UpdateAsync(int id, ClientDto dto);
    Task DeleteAsync(int id);
}
